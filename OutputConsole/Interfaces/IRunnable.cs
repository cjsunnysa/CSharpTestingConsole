using OutputConsole.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputConsole.Interfaces
{
    public interface IRunnable
    {
        string Title { get; }
        RunResult Run();
    }
}
