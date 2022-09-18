using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    /// <summary>
    /// Node can be child or root, having a key value,
    /// root node's parent will be null
    /// </summary>
    public class Node
    {
        public int Key;
        public Node Parent;
        public Node Left;
        public Node Right;
    }
}
