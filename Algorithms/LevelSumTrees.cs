using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LevelSumTrees
    {
        public static void LevelSum(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            q.Enqueue(null);
            int lsum = 0;
            while (q.Count != 0)
            {
                Node tmp = q.Dequeue();
                if (tmp == null)
                {
                    //print or get ur level sum here
                    lsum = 0; //reset
                    if (q.Count != 0)
                        q.Enqueue(null);
                }
                else
                {
                    lsum += tmp.value;
                    if (tmp.left != null)
                        q.Enqueue(tmp.left);
                    if (tmp.right != null)
                        q.Enqueue(tmp.right);
                }
            }
        }
    }
}
