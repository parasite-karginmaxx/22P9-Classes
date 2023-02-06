using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    internal class Pair
    {
        private DateTime start;
        private DateTime end;
        private DateTime breakStart;
        private DateTime breakEnd;
        //ссылка на Смену
        public Pair(DateTime start, DateTime end, DateTime breakStart, DateTime breakEnd)
        {
            this.start = start;
            this.end = end;
            this.breakStart = breakStart;
            this.breakEnd = breakEnd;
        }
    }
}
