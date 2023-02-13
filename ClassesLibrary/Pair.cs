using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kargin;

#region Вариант 7
//  https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit
#endregion

internal class Pair
{
    private DateTime start;
    private DateTime end;
    private DateTime breakStart;
    private DateTime breakEnd;
    private Shift shift;

    public Pair() : this(DateTime.Now()) {}
    public Pair(DateTime start, DateTime end, Shift shift) : this(start, end, shift) {}
    public Pair(DateTime start, DateTime end, DateTime breakStart, DateTime breakEnd)
    {
        this.start = start;
        this.end = end;
        this.breakStart = breakStart;
        this.breakEnd = breakEnd;
        this.shift = new Shift();
    }
    public void Deconstructor(out DateTime dStart, out DateTime dEnd, out DateTime dBreakStart, out DateTime dBreakEnd, out Shift dShift)
    {
        dStart = start;
        dEnd = end;
        dBreakStart = breakStart;
        dBreakEnd = breakEnd;
        dShift = shift;
    }
}