using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinklistImp
{
    internal class Node
    {
        public Node(string data)
        {
            Data = data;
            Next = null;
        }
        public string Data { set; get; }
        public Node Next { set; get; }
        public override string ToString()
        {
            return string.Format(this.Data);
        }

    }
}
