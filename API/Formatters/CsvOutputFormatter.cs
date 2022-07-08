using System.Text;
using API.DTOs;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using Shared;

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
            CsvWriter.Write<IEnumerable<TeamStatsDTO>>(buffer, context.Object as IEnumerable<TeamStatsDTO>);

        }
        else
        {
            CsvWriter.Write<TeamStatsDTO>(buffer, context.Object as TeamStatsDTO);
        }

        await response.WriteAsync(buffer.ToString(), selectedEncoding);
    }

}