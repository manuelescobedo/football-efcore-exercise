using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddStatsView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"
                CREATE VIEW if not exists vmTeamsGoalsScore AS
                    select team, sum(goalsinfavor) as goalsinfavor, sum(goalsagainst) as goalsagainst
                    from (
                        SELECT visitor as team, sum(visitorscore) as goalsinfavor, sum(LocalScore) as goalsagainst FROM matches group by visitor
                        union all                     
                        SELECT local as team, sum(LocalScore) as goalsinfavor, sum(visitorscore) as goalsagainst FROM matches group by local
                    ) group by team;
            ");

            migrationBuilder.Sql(@"
                create view if not exists vmTeamWins as
                    select w.team, sum(w.wins) as wins from (
                        select local as team, count(id) as wins from matches where localscore > visitorscore group by local
                        union all
                        select visitor as team, count(id) as wins from matches where visitorscore >localscore   group by visitor
                    ) w
                    group by team;
            ");
            migrationBuilder.Sql(@"
                create view if not exists vmTeamLosts as
                    select team, sum(losts) as losts from (
                        select local as team, count(id) as losts from matches where localscore < visitorscore group by local
                        union all
                        select visitor as team, count(id) as losts from matches where visitorscore < localscore   group by visitor
                    ) l
                    group by team ;
            ");
            migrationBuilder.Sql(@"
                create view if not exists vmTeamDraws as
                    select team, sum(draws) as draws from (
                        select local as team, count(id) as draws from matches where localscore = visitorscore group by local
                        union all
                        select visitor as team, count(id) as draws from matches where visitorscore = localscore   group by visitor
                    ) d
                    group by team;
            ");

            migrationBuilder.Sql(@"
                create view if not exists vmGames as
                    select team, sum(games) as games from (
                        select local as team, count(id) as games from matches group by local
                        union all
                        select visitor as team, count(id) as games from matches group by visitor
                    ) d
                    group by team;
            ");


            migrationBuilder.Sql(@"
                 create view if not exists vmStats as
                    select 
                        g.team, g.games, 
                        coalesce(w.wins, 0) as wins, coalesce(d.draws,0) as draws, coalesce(l.losts,0) as losts, 
                        coalesce(s.goalsinfavor,0) as goalsinfavor, coalesce(s.goalsagainst,0) as goalsagainst, 
                        coalesce(s.goalsinfavor,0) - coalesce(s.goalsagainst,0) as GoalsDiff , 
                        3*coalesce(w.wins,0)+coalesce(d.draws,0) as points
                    from vmgames g
                        left join vmteamwins w on w.team = g.team 
                        left join vmteamlosts l on l.team = g.team 
                        left join vmTeamDraws d on d.team = g.team
                        left join vmTeamsGoalsScore s on s.team = g.team
                    order by points desc,  GoalsDiff desc, goalsinfavor desc, goalsagainst, games, g.team;
             ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"
                drop VIEW if  exists vmTeamsGoalsScore 
            ");

            migrationBuilder.Sql(@"
                drop view if  exists vmTeamWins 
            ");
            migrationBuilder.Sql(@"
                drop view if exists vmTeamLosts
            ");
            migrationBuilder.Sql(@"
                drop view if exists vmTeamDraws 
            ");

            migrationBuilder.Sql(@"
                drop view if exists vmGames 
            ");

            migrationBuilder.Sql("drop view if exists vmStats");


        }
    }
}
