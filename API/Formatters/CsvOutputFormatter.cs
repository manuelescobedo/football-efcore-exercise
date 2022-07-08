using System.Text;
using API.DTOs;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

namespace API.Formatters;
public class CsvOutputFormatter : TextOutputFormatter
{
    public string ContentType { get; }

    public CsvOutputFormatter()
    {
        SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));

        SupportedEncodings.Add(Encoding.UTF8);
        SupportedEncodings.Add(Encoding.Unicode);
    }
    protected override bool CanWriteType(Type? type)
        => typeof(TeamStatsDTO).IsAssignableFrom(type)
            || typeof(IEnumerable<TeamStatsDTO>).IsAssignableFrom(type);
    public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
    {
        var serviceProvider = context.HttpContext.RequestServices;

        var response = context.HttpContext.Response;

        var buffer = new StringBuilder();
        if (context.Object is IEnumerable<TeamStatsDTO> matches)
        {

            Add<TeamStatsDTO>(buffer);

            foreach (TeamStatsDTO item in matches)
            {
                Add(buffer, item);
            }
        }
        else
        {
            Add<TeamStatsDTO>(buffer);

            Add<TeamStatsDTO>(buffer, context.Object as TeamStatsDTO);
        }

        await response.WriteAsync(buffer.ToString(), selectedEncoding);
    }

    void Add<T>(StringBuilder builder)
    {
        var props = typeof(T).GetProperties();

        string result = props.Aggregate("", (accum, next) => accum + $@"""{next.Name}"",");

        builder.AppendLine(result.Substring(0, result.Length - 1));
    }

    void Add<T>(StringBuilder builder, T @object)
    {
        var props = typeof(T).GetProperties();

        string result = props.Aggregate("", (accum, next) => accum + $@"""{next.GetValue(@object)}"",");

        builder.AppendLine(result.Substring(0, result.Length - 1));
    }
}