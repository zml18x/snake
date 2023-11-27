namespace Snake
{
    public class SnakeGame
    {
        private int ScreenWidth {get; set;}
        private int ScreenHeight { get; set;}
        private int Score { get; set; }
        private SnakeHead SnakeHead { get; set; }
        private Fruit Fruit { get; set; }
        private List<int> SnakeSegments { get; set;}




        public SnakeGame(int screenWidth, int screenHeright,ConsoleColor snakeColor, ConsoleColor fruitColor)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeright;
            Score = 0;
            SnakeSegments = new List<int>();

            SnakeHead = new SnakeHead
            {
                Xpos = screenWidth / 2,
                Ypos = screenHeright / 2,
                Color = snakeColor,
                Character = "■"
            };

            Fruit = new Fruit
            {
                Xpos = new Random().Next(1, ScreenWidth-1),
                Ypos = new Random().Next(1, ScreenHeight-1),
                Color = fruitColor,
                Character = "*"
            };
        }


        public void Run()
        {
            while (true)
            {
                Console.Clear();

                DrawFruit();
                DrawBoard();
                DrawResult();
                DrawSnake();
                Move();
                CheckIfEatenFruit();
                CheckCollision();

                Thread.Sleep(50);
            }     
        }


        private void DrawFruit()
        {
            Console.ForegroundColor = Fruit.Color;
            Console.SetCursorPosition(Fruit.Xpos, Fruit.Ypos);
            Console.Write(Fruit.Character);
        }

        private void DrawBoard()
        {
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < ScreenWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
            }

            for (int i = 0; i < ScreenWidth; i++)
            {
                Console.SetCursorPosition(i, ScreenHeight - 1);
                Console.Write("■");
            }

            for (int i = 0; i < ScreenHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
            }

            for (int i = 0; i < ScreenHeight; i++)
            {
                Console.SetCursorPosition(ScreenWidth - 1, i);
                Console.Write("■");
            }
        }

        private void DrawResult()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n\nScore: " + Score);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void DrawSnake()
        {
            Console.ForegroundColor = SnakeHead.Color;

            for (int i = 0; i < SnakeSegments.Count(); i++)
            {         
                Console.SetCursorPosition(SnakeSegments[i], SnakeSegments[i + 1]);
                Console.Write(SnakeHead.Character);
            }

            Console.SetCursorPosition(SnakeHead.Xpos, SnakeHead.Ypos);
            Console.Write(SnakeHead.Character);
        }

        private void Move()
        {
            var move = Console.ReadKey().Key;

            if (move == ConsoleKey.UpArrow)
                SnakeHead.Ypos--;

            if (move == ConsoleKey.DownArrow)
                SnakeHead.Ypos++;

            if (move == ConsoleKey.LeftArrow)
                SnakeHead.Xpos--;

            if (move == ConsoleKey.RightArrow)
                SnakeHead.Xpos++;
        }

        private void CheckIfEatenFruit()
        {
            if (SnakeHead.Xpos == Fruit.Xpos && SnakeHead.Ypos == Fruit.Ypos)
            {
                Fruit.Xpos = new Random().Next(1, ScreenWidth-1);
                Fruit.Ypos = new Random().Next(1, ScreenHeight-1);

                Score++;
            }
        }

        private void CheckCollision()
        {
            if (SnakeHead.Xpos == 0 || SnakeHead.Xpos == ScreenWidth - 1 || SnakeHead.Ypos == 0 || SnakeHead.Ypos == ScreenHeight - 1)
                GameOver();

            for (int i = 0; i < SnakeSegments.Count(); i += 2)
                if (SnakeHead.Xpos == SnakeSegments[i] && SnakeHead.Ypos == SnakeSegments[i + 1])
                    GameOver();
        }

        private void GameOver()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("GAME OVER");
            Console.WriteLine("YOUR SCORE: " + Score);

            Environment.Exit(0);
        }
    }
}