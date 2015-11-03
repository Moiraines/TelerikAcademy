////Task Description is in its respected file in same project
namespace ExamCSharp2Task2
{
    using System;
    using System.Text;

    public class BishopPathFinder
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            string[] splited = input.Split(' ');
            int rows = int.Parse(splited[0]);
            int columns = int.Parse(splited[1]);
            int[,] board = new int[rows, columns];

            board = FillingBoard(board);

            int numberOfDecorationsAndSums = int.Parse(Console.ReadLine());
            string[] directions = new string[numberOfDecorationsAndSums];
            int[] moves = new int[numberOfDecorationsAndSums];
            StringBuilder part = new StringBuilder();

            for (int i = 0; i < numberOfDecorationsAndSums; i++)
            {
                string command = Console.ReadLine();
                for (int j = 0; j < 2; j++)
                {
                    part.Append(command[j]);
                }

                directions[i] = part.ToString();
                part.Clear();

                for (int j = 3; j < command.Length; j++)
                {
                    part.Append(command[j]);
                }

                moves[i] = int.Parse(part.ToString());
                part.Clear();
            }

            int startPositionX = rows - 1;
            int startPositionY = 0;
            int col = 0;
            int row = 0;
            int counter;
            long sum = 0;

            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == "RU" || directions[i] == "UR")
                {
                    for (col = startPositionY, row = startPositionX; col < moves[i] + startPositionY; col++, row--)
                    {
                        if (col > columns - 1 || row < 0)
                        {
                            break;
                        }

                        sum += board[row, col];
                        board[row, col] = 0;
                    }

                    startPositionX = row + 1;
                    startPositionY = col - 1;
                }
                else if (directions[i] == "LU" || directions[i] == "UL")
                {
                    for (col = startPositionY, row = startPositionX, counter = 0; counter < moves[i]; col--, row--, counter++)
                    {
                        if (row < 0 || col < 0)
                        {
                            break;
                        }

                        sum += board[row, col];
                        board[row, col] = 0;
                    }

                    startPositionX = row + 1;
                    startPositionY = col + 1;
                    counter = 0;
                }
                else if (directions[i] == "DL" || directions[i] == "LD")
                {
                    for (col = startPositionY, row = startPositionX; row < moves[i] + startPositionX; col--, row++)
                    {
                        if (row > rows - 1 || col < 0)
                        {
                            break;
                        }

                        sum += board[row, col];
                        board[row, col] = 0;
                    }

                    startPositionX = row - 1;
                    startPositionY = col + 1;
                }
                else if (directions[i] == "RD" || directions[i] == "DR")
                {
                    for (col = startPositionY, row = startPositionX; col < moves[i] + startPositionY; col++, row++)
                    {
                        if (col > rows - 1 || row > columns - 1)
                        {
                            break;
                        }

                        sum += board[row, col];
                        board[row, col] = 0;
                    }

                    startPositionX = row - 1;
                    startPositionY = col - 1;
                }
            }

            Console.WriteLine(sum);
        }

        private static int[,] FillingBoard(int[,] matrix)
        {
            int rowCounter = 0;
            int colCounter = 0;

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowCounter + colCounter;
                    colCounter += 3;
                }

                rowCounter += 3;
                colCounter = 0;
            }

            return matrix;
        }
    }
}