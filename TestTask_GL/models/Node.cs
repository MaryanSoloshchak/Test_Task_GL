using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_GL.models
{
    [Serializable]
    public class Node
    {
        public List<Node> nodes;
        public Node()
        {
            nodes = new List<Node>();
        }
    }
}
