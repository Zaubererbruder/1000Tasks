using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Zoo
    {
        public AnimalCollection Animals { get; private set; }

        public Zoo()
        {
            Animals = new AnimalCollection(this);
        }
    }
}
