using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmeAfl
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //doakodsaodkaokdosa
        }
        private static Cell DFS(List<Cell> cells, string goal)
        {

            Stack<Cell> stack = new Stack<Cell>();

            Cell currentCell = cells[0];

            stack.Push(currentCell);

            while (stack.Count > 0)
            {
                currentCell = stack.Pop();

                if (currentCell.Name.Equals(goal))
                {
                    return currentCell;
                }
                if (!currentCell.Visited)
                {
                    currentCell.Visited = true;

                    foreach (Edge e in currentCell.MyEdge)
                    {

                        if (!e.To.Visited)
                        {
                            e.To.Parent = currentCell;
                            stack.Push(e.To);
                        }
                    }
                }
            }

            return null;
        }

    }
}
