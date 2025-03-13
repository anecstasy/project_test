using System;
using System.Text;

namespace GuessNumberGame
{
    public class GuessNumberGame
    {
        private readonly int _targetNumber;
        private int _attempts;

        public GuessNumberGame(int targetNumber)
        {
            _targetNumber = targetNumber;
            _attempts = 0;
        }

        public string MakeGuess(int guess)
        {
            _attempts++;

            if (guess < _targetNumber)
            {
                return "Загадане число більше.";
            }
            else if (guess > _targetNumber)
            {
                return "Загадане число менше.";
            }
            else
            {
                return $"Вітаємо! Ви вгадали число за {_attempts} спроб.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            var game = new GuessNumberGame(targetNumber);

            Console.WriteLine("Вгадайте число від 1 до 100.");

            while (true)
            {
                Console.Write("Ваше число: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    string result = game.MakeGuess(guess);
                    Console.WriteLine(result);

                    if (result.Contains("Вітаємо"))
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Будь ласка, введіть коректне число.");
                }
            }
        }
    }
}
