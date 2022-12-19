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