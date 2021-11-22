using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeRunner();
            Console.ReadKey();
        }

        static void MazeRunner()
        {
            char[,] maze =
            {
                {'s','-','-','*','-','-','-'},
                {'*','*','-','*','-','*','-'},
                {'-','-','-','-','-','-','-'},
                {'-','*','*','*','*','*','-'},
                {'-','-','-','-','-','-','e'}
            };
            int x = 0;
            int y = 0;
            Maze(maze, x, y);
        }

        static void Maze(char[,] maze, int x, int y)
        {
            int upx = x + 1;
            int upy = y;
            int downx = x - 1;
            int downy = y;
            int leftx = x;
            int lefty = y - 1;
            int rightx = x;
            int righty = y + 1;
            if (x + 1 > maze.GetLength(0) - 1)
            {
                upx = x;
            }
            if (x - 1 < 0)
            {
                downx = x;
            }
            if (y + 1 > maze.GetLength(1) - 1)
            {
                righty = y;
            }
            if (y - 1 < 0)
            {
                lefty = y;
            }

            if(maze[upx, upy] == 'e' || maze[downx, downy] == 'e' || maze[leftx, lefty] == 'e' || maze[rightx, righty] == 'e')
            {
                Console.WriteLine();
                for (int i = 0; i < maze.GetLength(0); i++)
                {
                    for (int j = 0; j < maze.GetLength(1); j++)
                    {
                        Console.Write(maze[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            if(maze[upx, upy] == '-')
            {
                maze[upx, upy] = '+';
                Maze(maze, upx, upy);
                maze[upx, upy] = '-';
            }

            if (maze[downx, downy] == '-')
            {
                maze[downx, downy] = '+';
                Maze(maze, downx, downy);
                maze[downx, downy] = '-';
            }

            if (maze[leftx, lefty] == '-')
            {
                maze[leftx, lefty] = '+';
                Maze(maze, leftx, lefty);
                maze[leftx, lefty] = '-';
            }

            if (maze[rightx, righty] == '-')
            {
                maze[rightx, righty] = '+';
                Maze(maze, rightx, righty);
                maze[rightx, righty] = '-';
            }
        }
    }
}
