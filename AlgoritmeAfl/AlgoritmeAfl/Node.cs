using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmeAfl
{
    class Node<T>
    {
        private bool visited; 

        private Node<T> parent; 

        private T name;

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }
        public Node<T> Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public T Name
        {
            get { return name; }
            set { name = value; }
        }


        public Node(T Name)
        {
            this.name = Name;
        }


    }
}
