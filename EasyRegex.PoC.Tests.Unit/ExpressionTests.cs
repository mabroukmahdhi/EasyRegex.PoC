// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// ---------------------------------------------------------------

using Xunit;

namespace EasyRegex.PoC.Tests.Unit
{
    public class ExpressionTests
    {
        [Fact]
        public void ShouldCreateExpressionWithStartKey()
        {
            Expression expression = Expression.Start();

            Assert.True(expression.ToString() == "^");
        }

        [Fact]
        public void ShouldCreateExpressionWithEndKey()
        {
            Expression expression = Expression.Start().End();

            Assert.True(expression.ToString() == "^$");
        }

        [Fact]
        public void ShouldCreateExpressionWithAnything()
        {
            Expression expression = Expression.Start().WithAnything();

            Assert.True(expression.ToString() == "^.");
        }

        [Fact]
        public void ShouldCreateExpressionWithAClass()
        {
            Expression expression =
                Expression.Create()
                .AddAClass(Expression.Create().WithLetter());

            Assert.True(expression.ToString() == "[a-zA-Z]");
        }
        
        [Fact]
        public void ShouldCreateExpression()
        {
            string expectedExpression = "^[a-zA-Z0-9]{5}$"; 

            Expression expression =
                Expression.Start()
                .AddAClass(Expression.Create().WithLetter().AddAnExpression("0-9"))
                .AndShouldBe()
                .RepeatedExactly(5)
                .End();

            Assert.True(expression.ToString() == expectedExpression);
        }
    }
}