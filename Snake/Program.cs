namespace Snake
{
    class Program
    {
        static void Main()
        {
            var screenWidth = 32;
            var screenHeight = 16;
            var snakeColor = ConsoleColor.Red;
            var fruitColor = ConsoleColor.Cyan;

            var game = new SnakeGame(screenWidth, screenHeight, snakeColor, fruitColor);

            game.Run();
        }
    }
}