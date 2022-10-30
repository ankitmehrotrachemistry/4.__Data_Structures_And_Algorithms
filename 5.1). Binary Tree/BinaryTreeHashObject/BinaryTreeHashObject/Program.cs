using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeHashObject
{
    class Program
    {
        static void Main(string[] args)
        {
            IBinarySearchTree bst = new BinarySearchTree();

            bst.Insert(new Node() { Key = 20});
            bst.Insert(new Node() { Key = 15});
            bst.Insert(new Node() { Key = 18});
            bst.Insert(new Node() { Key = 25});
            bst.Insert(new Node() { Key = 22});
            bst.Insert(new Node() { Key = 5});

            Dictionary<int, HashObject> dict = new Dictionary<int, HashObject>();
            dict = Traverse(bst.Root, dict, 0, 0);

            //printing result

            dict.ToList().ForEach(x => { Console.WriteLine(x.Value.Node.Key); });
            Console.ReadLine();
        }

        static Dictionary<int, HashObject> Traverse(BinaryTreeHashObject.Node node, Dictionary<int, HashObject> dict, int width, int height)
        {
            if (node != null)
            {
                //left side width will decrese by one from root, but hieght always increases
                Traverse(node.Left, dict, width - 1, height + 1);
                if (!dict.ContainsKey(width))
                {
                    dict.Add(width, new HashObject { Height = height, Node = node });
                }
                else
                {
                    //if stored height is less than current height at particular width
                    if (dict[width].Height < height)
                        dict[width].Node = node;
                }
                //right side width will increase by one from root, but hieght always increases
                Traverse(node.Right, dict, width + 1, height + 1);
            }
            return dict;
        }
    }

    public class HashObject
    {
        public int Height { get; set; }
        public BinaryTreeHashObject.Node Node { get; set; }
    }
}
