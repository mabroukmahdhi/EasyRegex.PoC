// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------

namespace EasyRegex.PoC.Services
{
    public class ExpressionService : IExpressionService
    {
        public string GetAnyExpression() => ".";

        public string GetDigitExpression() => "\\d";

        public string GetEndExpression() => "$";

        public string GetExactExpression(string input)
        {
            var keys = GetKeyChars();

            var formatted = string.Empty;
            foreach (char c in input)
            {
                if (keys.Contains(c))
                {
                    formatted += $"\\{c}";
                }
                else
                {
                    formatted += c;
                }
            }

            return formatted;
        }

        public string GetKeyChars() => @"^$.|{}[]()*+?\";

        public string GetLetterExpression() => "a-zA-Z";

        public string GetLowercaseLetterExpression() => "a-z";

        public string GetNewlineExpression() => "\\n";

        public string GetNonDigitExpression() => "\\D";

        public string GetNonWhitespaceExpression() => "\\S";

        public string GetNonWordExpression() => "\\W";

        public string GetReturnExpression() => "\\r";

        public string GetStartExpression() => "^";

        public string GetTabExpression() => "\\t";

        public string GetUppercaseLetterExpression() => "A-Z";

        public string GetWhitespaceExpression() => "\\s";

        public string GetWordBoundaryExpression() => "\\b";

        public string GetWordExpression() => "\\w";
    }
}