// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------

using System.Text;
using EasyRegex.PoC.Services;

namespace EasyRegex.PoC
{
    //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions/Cheatsheet

    public class Expression
    {
        private static IExpressionService ExpressionService =
            new ExpressionService();

        private StringBuilder expressionValue = new();

        private Expression()
        { }

        public static Expression Create() => new();

        public static Expression Start()
        {
            var expression = new Expression();

            expression.expressionValue.Append(
                    value: ExpressionService.GetStartExpression());

            return expression;
        }

        public Expression AddAClass(Expression expression)
        {
            this.expressionValue.Append($"[{expression}]");
            return this;
        }

        public Expression AddANegatedClass(Expression expression)
        {
            this.expressionValue.Append($"[^{expression}]");
            return this;
        }

        public Expression AddAGroup(Expression expression)
        {
            this.expressionValue.Append($"({expression})");
            return this;
        }

        public Expression AddAnExpression(string expression)
        {
            this.expressionValue.Append(expression);
            return this;
        }

        public Expression WithAnything()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetAnyExpression());

            return this;
        }

        public Expression WithExactly(string input)
        {
            this.expressionValue.Append(
                value: ExpressionService.GetExactExpression(input));

            return this;
        }

        public Expression WithADigit()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetDigitExpression());

            return this;
        }

        public Expression WithNonDigit()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetNonDigitExpression());

            return this;
        }

        public Expression WithAWord()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetWordExpression());

            return this;
        }

        public Expression WithNonWord()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetNonWordExpression());

            return this;
        }

        public Expression WithWordBoundary()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetWordBoundaryExpression());

            return this;
        }

        public Expression WithLetter()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetLetterExpression());

            return this;
        }

        public Expression WithLowercaseLetter()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetLowercaseLetterExpression());

            return this;
        }

        public Expression WithUppercaseLetter()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetUppercaseLetterExpression());

            return this;
        }

        public Expression WithWhitespace()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetWhitespaceExpression());

            return this;
        }

        public Expression WithNonWhitespace()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetNonWhitespaceExpression());

            return this;
        }

        public Expression WithTabKey()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetTabExpression());

            return this;
        }

        public Expression WithReturnKey()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetReturnExpression());

            return this;
        }

        public Expression WithNewlineKey()
        {
            this.expressionValue.Append(
                value: ExpressionService.GetNewlineExpression());

            return this;
        }

        public ExpressionOperator AndShouldBe() => new(this);

        public Expression End()
        {
            this.expressionValue.Append(
                    value: ExpressionService.GetEndExpression());

            return this;
        }

        public override string ToString() =>
            expressionValue.ToString();
    }
}