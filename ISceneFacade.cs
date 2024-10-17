using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab2
{
    public interface ISceneFacade
    {
        public void Show(IEnumerable<(string, string)> elements);
    }
}
