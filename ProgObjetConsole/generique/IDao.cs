using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObjetConsole.generique
{
    interface IDao<T>
    {
        List<T> getAll();
        T getById(int id);
        bool add(T item);
        bool update(T item);
        bool delete(int id);
        void deleteItems(List<T> items);
    }
}
