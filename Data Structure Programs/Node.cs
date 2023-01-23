using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Programs
{
    internal class Node
    {
        public string Data;
        public Node next;
        public Node(string Data)
        {
            this.Data = Data;
            next = null;
        }
    }
}
