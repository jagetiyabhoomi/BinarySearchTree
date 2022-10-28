using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.Leftnode;
                else if (value > after.Data)
                    before = after.Rightnode;
                else
                    return false;
            }
            Node newnode= new Node();
            newnode.Data = value;
            if(this.Root == null)
            {
                this.Root = newnode;
            }
            else
            {
                if(value < this.Root.Data)
                    after=this.Root;
                else 
                    before.Rightnode=  newnode;

            }
            return true;
            
        }
        public void TraverseTree(Node Parent)
        {
            if(Parent != null)
            {
                Console.WriteLine(Parent.Data+ " ");
                TraverseTree(Parent.Leftnode);
                TraverseTree(Parent.Rightnode);
            }
        }
    }
}
