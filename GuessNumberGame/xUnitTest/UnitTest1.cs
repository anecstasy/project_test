using Xunit;
using GuessNumberGame;

namespace GuessNumberGame.Tests
{
    public class GuessNumberGameTests
    {
        [Fact]
        public void MakeGuess_NumberIsLower_ReturnsHigherMessage()
        {
            // Arrange
            var game = new GuessNumberGame(50);

            // Act
            var result = game.MakeGuess(30);

            // Assert
            Assert.Equal("Загадане число більше.", result);
        }

        [Fact]
        public void MakeGuess_NumberIsHigher_ReturnsLowerMessage()
        {
            // Arrange
            var game = new GuessNumberGame(50);

            // Act
            var result = game.MakeGuess(70);

            // Assert
            Assert.Equal("Загадане число менше.", result);
        }

        [Fact]
        public void MakeGuess_NumberIsCorrect_ReturnsCongratulationsMessage()
        {
            // Arrange
            var game = new GuessNumberGame(50);

            // Act
            var result = game.MakeGuess(50);

            // Assert
            Assert.Contains("Вітаємо", result);
        }

        [Fact]
        public void MakeGuess_AttemptsCounterIncrements()
        {
            // Arrange
            var game = new GuessNumberGame(50);

            // Act
            game.MakeGuess(30);
            game.MakeGuess(70);
            game.MakeGuess(50);

            // Assert
            var result = game.MakeGuess(50);
            Assert.Contains("4", result); // Перевіряємо, що кількість спроб дорівнює 4
        }

        [Fact]
        public void MakeGuess_NumberIsCorrect_AttemptsCounterIsCorrect()
        {
            // Arrange
            var game = new GuessNumberGame(50);

            // Act
            game.MakeGuess(30);
            game.MakeGuess(70);
            var result = game.MakeGuess(50);

            // Assert
            Assert.Contains("3", result); // Перевіряємо, що кількість спроб дорівнює 3
        }
    }
}
