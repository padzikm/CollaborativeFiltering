using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeFilteringUI.Core.Utils
{
    public class Pair<T,W> : BaseNotification
    {
        public Pair(T item1, W item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public T Item1 { get; set; }

        public W Item2 { get; set; }

        public override string ToString()
        {
            return "Pair {" + Item1.ToString() + " , " + Item2.ToString() + "}";
        }
    }
}
