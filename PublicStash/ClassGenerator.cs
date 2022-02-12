using System.Collections.Generic;
using System.Text;

namespace PathOfExile
{
    public static class ClassGenerator
    {
        public static string Generate(string indexName, string inheritanceName, string suffixRemove, IEnumerable<string> classes)
        {
            var builder = new StringBuilder();

            foreach (var @class in classes)
            {
                builder.AppendLine($@"[{indexName}(""{@class}"")]");
                builder.AppendLine(!string.IsNullOrEmpty(suffixRemove)
                    ? $@"public class {@class.Replace(" ", "").Trim().Replace(suffixRemove, "")} : {inheritanceName}"
                    : $@"public class {@class.Replace(" ", "").Trim()} : {inheritanceName}");
                builder.AppendLine("{");
                builder.AppendLine("}");
                builder.AppendLine("");
            }

            return builder.ToString();
        }
    }
}