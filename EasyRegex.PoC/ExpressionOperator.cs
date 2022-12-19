// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------

namespace EasyRegex.PoC
{
    public class ExpressionOperator
    {
        private readonly Expression expression;

        public ExpressionOperator(Expression expression) =>
            this.expression = expression;

        public Expression RepeatedZeroOrMoreTimes =>
            this.expression.AddAnExpression("*");

        public Expression RepeatedOneOrMoreTimes =>
             this.expression.AddAnExpression("+");

        public Expression Optional =>
            this.expression.AddAnExpression("?");

        public Expression RepeatedExactly(int times) =>
            this.expression.AddAnExpression($"{{{times}}}");

        public Expression RepeatedBetween(int minTimes, int maxTimes) =>
            this.expression.AddAnExpression($"{{{minTimes},{maxTimes}}}");

        public Expression RepeatedAtLeast(int times) =>
           this.expression.AddAnExpression($"{{{times},}}");

        public Expression RepeatedAtMost(int times) =>
          this.expression.AddAnExpression($"{{,{times}}}");
    }
}