using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.delegates
{
    class DelegateGenerique<T>
    {
        delegate int Comparaison(T c1, T c2);
    }
}
