using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeHashObject
{
   interface IBinarySearchTree
    {
        Node Root { get; set; }
        void Insert(Node node);

        void InorderTreeWalk(Node node);
        
    }
}
