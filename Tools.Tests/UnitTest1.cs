namespace Tools.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsPrime_ShouldReturnTrue_WhenValueIsPrime()
        {
            // Arrange
            int x = 5;

            // Act
            bool result = x.IsPrime();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPrime_ShouldReturnFalse_WhenValueIsNotPrime()
        {
            // Arrange
            int x = 4;

            // Act
            bool result = x.IsPrime();

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(-5, "The value -5 must be > 1!")]
        [InlineData(-1, "The value -1 must be > 1!")]
        public void IsPrime_ShouldThrowInvalidOperationException_WhenValueIsNegative(int value, string errorMessage)
        {
            // Arrange
            int x = value;

            // Act & Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => x.IsPrime());

            // Assert
            Assert.Equal(errorMessage, ex.Message);
        }
    }
}