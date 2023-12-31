using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Template.Bot.Extensions
{
    public static class StringExtensions
    {
        public static string EscapeText(this string source)
        {
            if (source != null)
            {
                var regex = new Regex(@"<(\w*|\/\w*)>");
                source = regex.Replace(source, string.Empty);

                var charactersToEscape = new[] { "_", "*", "[", "]", "(", ")", "~", "`", "<", ">", "#", "+", "-", "=", "|", "{", "}", ".", "!" };
                foreach (var item in charactersToEscape)
                {
                    source = source.Replace(item, $@"\{item}");
                }
            }
            return source;
        }
    }
}
