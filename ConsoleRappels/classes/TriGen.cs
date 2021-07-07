using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRappels.classes
{
    /// <summary>
    /// Classe Générique : 'T' param de Type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TriGen<T> 
        //Filtre sur Types acceptés (T) 
        where T : ICompare
    {
       public void Tri(T[] aTrier)
        {
            T temp;
            for (int i = 0; i < aTrier.Length - 1; i++)
            {
                for (int j = i + 1; j < aTrier.Length; j++)
                {
                    if (aTrier[i].compare(aTrier[j]) == 1)
                    {
                        temp = aTrier[i];
                        aTrier[i] = aTrier[j];
                        aTrier[j] = temp;
                    }
                }
            }
        }
    }
}
