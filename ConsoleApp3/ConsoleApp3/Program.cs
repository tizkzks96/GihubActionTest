using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int row;
            int col;

            bool[,] map;
            int[,] check;
            int[,] dir = new int[4, 2] { { 1, 1 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };

            Start();
            In();
            Console.WriteLine(Bfs());

            void In()
            {
                for (int i = 0; i < row; i++)
                {
                    string temp = Console.ReadLine();
                    for (int j = 0; j < col; j++)
                    {
                        if(temp[j] == 1)
                            map[i, j] = true;
                    }
                }
            }

            // Start is called before the first frame update
            void Start()
            {
                string testCase = Console.ReadLine();
                row = int.Parse(testCase.Split(" ")[0]);
                col = int.Parse(testCase.Split(" ")[1]);

                map = new bool[row, col];
                check = new int[row, col];
            }

            bool IsInside(int x, int y)
            {
                return (x >= 0 && x < row) && (y >= 0 && y < col);
            }

            int Bfs()
            {
                int cur_y = 0;
                int cur_x = 0;

                Queue<KeyValuePair<int, int>> q = new Queue<KeyValuePair<int, int>>();
                q.Enqueue(new KeyValuePair<int, int>(cur_y, cur_x));
                check[cur_y, cur_x] = 1;

                while (q.Count > 0)
                {
                    cur_y = q.Peek().Key;
                    cur_x = q.Peek().Value;
                    q.Dequeue();

                    if ((cur_y == row - 1) && (cur_x == col - 1)) break;

                    for (int i = 0; i < 4; i++)
                    {
                        int next_y = cur_y + dir[i, 0];
                        int next_x = cur_x + dir[i, 1];

                        if (IsInside(next_y, next_x) && check[next_y, next_x] == 0 && map[next_y, next_x])
                        {
                            check[next_y, next_x] = check[next_y, next_x] + 1;
                            q.Enqueue(new KeyValuePair<int, int>(next_y, next_x));
                        }
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(check[i,j]);
                    }
                    Console.WriteLine("");
                }
                return check[row - 1, col - 1];

            }

        }

    }
}