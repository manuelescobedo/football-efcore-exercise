using System.Text;

namespace Shared;
public static class CsvWriter
{
    static string GetHeaders(Type T)
    {
        StringBuilder builder = new StringBuilder();

        var props = T.GetProperties();
        string result = props.Aggregate("", (accum, next) => accum + $@"""{next.Name}"",");

        builder.AppendLine(result.Substring(0, result.Length - 1));
        return builder.ToString();
    }
    static string GetLine<T>(T @object) where T : class
    {
        StringBuilder builder = new StringBuilder();
        var props = typeof(T).GetProperties();

        string result = props.Aggregate("", (accum, next) => accum + $@"""{next.GetValue(@object)}"",");

        builder.AppendLine(result.Substring(0, result.Length - 1));
        return builder.ToString();

    }

    public static void Write<T>(StringBuilder builder, T @object) where T : class
    {
        builder.Append(GetHeaders(typeof(T)));
        builder.Append(GetLine(@object));

    }


    public static void Write<T>(StringBuilder builder, IEnumerable<T> @object) where T : class
    {
        builder.Append(GetHeaders(typeof(T)));

        foreach (var item in @object)
            builder.Append(GetLine(item));

    }
}
