// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------

namespace EasyRegex.PoC.Services
{
    public interface IExpressionService
    {
        string GetKeyChars();
        string GetStartExpression();
        string GetEndExpression();
        string GetAnyExpression();
        string GetExactExpression(string input);
        string GetDigitExpression();
        string GetNonDigitExpression();
        string GetWordExpression();
        string GetNonWordExpression();
        string GetWordBoundaryExpression();
        string GetLetterExpression();
        string GetLowercaseLetterExpression();
        string GetUppercaseLetterExpression();
        string GetWhitespaceExpression();
        string GetNonWhitespaceExpression();
        string GetTabExpression();
        string GetReturnExpression();
        string GetNewlineExpression();
    }
}