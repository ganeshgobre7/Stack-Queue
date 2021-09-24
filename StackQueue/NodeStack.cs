using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    class NodeStack<Gtype>
    {
        public Gtype data;
        public NodeStack <Gtype> next;

        public NodeStack(Gtype data)
        {
            this.data = data;
        }
    }
}
