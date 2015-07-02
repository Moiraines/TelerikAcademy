/*
 Task 4. Re-factor and improve the code

Refactor and improve the naming in the C# source project Application1.sln.
You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs. 
 */

namespace Mines
{
    using System;
    using System.Collections.Generic;

    public class Mines
    {
        private const int BoardRows = 5;
        private const int BoardColumns = 10;
        private const int MaxMoves = 35;

        public static void Main()
        {
            string command = string.Empty;
            int scoreCounter = 0;
            int row = 0;
            int col = 0;
            bool getBlowed = false;
            bool inStartState = true;
            bool isAlOpened = false;
            List<Results> champions = new List<Results>(6);
            char[,] field = BattleFieldCreate(BoardRows, BoardColumns);
            char[,] bombsLocations = CreateBombsLocations(BoardRows, BoardColumns);

            do
            {
                if (inStartState)
                {
                    Console.WriteLine("Let's play Mines”. Push your luck and try to reveal all fields without blow off." +
                    " Command 'top' show the ranking, 'restart' begins new game, 'exit' exit the game!");
                    BoardDraw(field);
                    inStartState = false;
                }

                Console.Write("Enter row and col : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (CommandTurnChecker(command, field, row, col))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "turn":
                        if (bombsLocations[row, col] != '*')
                        {
                            if (bombsLocations[row, col] == '-')
                            {
                                NextTurn(field, bombsLocations, row, col);
                                scoreCounter++;
                            }

                            if (MaxMoves == scoreCounter)
                            {
                                isAlOpened = true;
                            }
                            else
                            {
                                BoardDraw(field);
                            }
                        }
                        else
                        {
                            getBlowed = true;
                        }

                        break;
                    case "top":
                        RankList(champions);
                        break;
                    case "restart":
                        field = BattleFieldCreate(BoardRows, BoardColumns);
                        bombsLocations = CreateBombsLocations(BoardRows, BoardColumns);
                        BoardDraw(field);
                        getBlowed = false;
                        inStartState = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }

                if (getBlowed)
                {
                    BoardDraw(bombsLocations);
                    Console.Write(
                        "\nHrrrrrr! You die heroically with {0} scores. " +
                        "Enter nickname: ", 
                        scoreCounter);
                    string nickname = Console.ReadLine();
                    Results result = new Results(nickname, scoreCounter);

                    if (champions.Count < 5)
                    {
                        champions.Add(result);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Scores < result.Scores)
                            {
                                champions.Insert(i, result);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Results r1, Results r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Results r1, Results r2) => r2.Scores.CompareTo(r1.Scores));
                    RankList(champions);

                    field = BattleFieldCreate(BoardRows, BoardColumns);
                    bombsLocations = CreateBombsLocations(BoardRows, BoardColumns);
                    scoreCounter = 0;
                    getBlowed = false;
                    inStartState = true;
                }

                if (isAlOpened)
                {
                    Console.WriteLine("\nBRAVOOOS! You opened 35 cells without take any damage.");
                    BoardDraw(bombsLocations);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string imeee = Console.ReadLine();
                    Results to4kii = new Results(imeee, scoreCounter);
                    champions.Add(to4kii);
                    RankList(champions);

                    field = BattleFieldCreate(BoardRows, BoardColumns);
                    bombsLocations = CreateBombsLocations(BoardRows, BoardColumns);
                    scoreCounter = 0;
                    isAlOpened = false;
                    inStartState = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("Yahooooooo");
            Console.Read();
        }

        private static bool CommandTurnChecker(string command, char[,] field, int row, int col)
        {
            bool isTrue = int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1);

            return isTrue;
        }

        private static void RankList(List<Results> champions)
        {
            Console.WriteLine("\nTo4KI:");
            if (champions.Count > 0)
            {
                for (int i = 0; i < champions.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} cells",
                        i + 1, 
                        champions[i].Name, 
                        champions[i].Scores);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty list!\n");
            }
        }

        private static void NextTurn(char[,] field, char[,] bombs, int row, int col)
        {
            char neighbourBombs = NeighbourFieldsCheck(bombs, row, col);
            bombs[row, col] = neighbourBombs;
            field[row, col] = neighbourBombs;
        }

        private static void BoardDraw(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] BattleFieldCreate(int rows, int cols)
        {
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombsLocations(int rows, int cols)
        {
            char[,] battleField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    battleField[i, j] = '-';
                }
            }

            List<int> bombsContainer = BombGenerator();

            foreach (int i2 in bombsContainer)
            {
                int col = i2 / cols;
                int row = i2 % cols;

                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                battleField[col, row - 1] = '*';
            }

            return battleField;
        }

        private static List<int> BombGenerator()
        {
            List<int> bombsContainer = new List<int>();

            while (bombsContainer.Count < 15)
            {
                Random random = new Random();
                int bombPos = random.Next(50);
                if (!bombsContainer.Contains(bombPos))
                {
                    bombsContainer.Add(bombPos);
                }
            }

            return bombsContainer;
        }

        private static void Calculation(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char kolkoo = NeighbourFieldsCheck(field, i, j);
                        field[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char NeighbourFieldsCheck(char[,] bombsLocations, int pickedCellRow, int pickedCellCol)
        {
            int neighbourBombsCount = 0;
            int rows = bombsLocations.GetLength(0);
            int columns = bombsLocations.GetLength(1);

            if (pickedCellRow - 1 >= 0)
            {
                if (bombsLocations[pickedCellRow - 1, pickedCellCol] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if (pickedCellRow + 1 < rows)
            {
                if (bombsLocations[pickedCellRow + 1, pickedCellCol] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if (pickedCellCol - 1 >= 0)
            {
                if (bombsLocations[pickedCellRow, pickedCellCol - 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if (pickedCellCol + 1 < columns)
            {
                if (bombsLocations[pickedCellRow, pickedCellCol + 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((pickedCellRow - 1 >= 0) && (pickedCellCol - 1 >= 0))
            {
                if (bombsLocations[pickedCellRow - 1, pickedCellCol - 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((pickedCellRow - 1 >= 0) && (pickedCellCol + 1 < columns))
            {
                if (bombsLocations[pickedCellRow - 1, pickedCellCol + 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((pickedCellRow + 1 < rows) && (pickedCellCol - 1 >= 0))
            {
                if (bombsLocations[pickedCellRow + 1, pickedCellCol - 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            if ((pickedCellRow + 1 < rows) && (pickedCellCol + 1 < columns))
            {
                if (bombsLocations[pickedCellRow + 1, pickedCellCol + 1] == '*')
                {
                    neighbourBombsCount++;
                }
            }

            return char.Parse(neighbourBombsCount.ToString());
        }
    }
}
