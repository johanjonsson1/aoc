using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Common
{
    public interface IDay
    {
        void Run();
        string Title { get; }
    }
}
