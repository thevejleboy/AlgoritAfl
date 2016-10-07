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
        private static Node<T> DFS<T>(List<Node<T>> nodes, T goal)
        {
            
            Stack<Node<T>> stack = new Stack<Node<T>>();

            Node<T> currentNode = nodes[0]; 

            stack.Push(currentNode); 

            while (stack.Count > 0) 
            {
                currentNode = stack.Pop(); 

                if (currentNode.Name.Equals(goal)) 
                {
                    return currentNode; 
                }
                if (!currentNode.Visited)
                {
                    currentNode.Visited = true; 

                    foreach (Edge<T> e in currentNode.MyEdges) 
                    {

                        if (!e.To.Visited) 
                        {
                            e.To.Parent = currentNode;
                            stack.Push(e.To); 
                        }
                    }
                }
            }

            return null;
        }
    }
}
