using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRappels.delegates
{
    class TestDelegates
    {
        //Déclaration Evenenement 
        event EventHandler EventSiNegatif;
        event EventHandler<InfoEventArgs> EventInfoSiNegatif;

        int total = 0;

        //Déclaration Delegate (type de méthodes!)
        delegate int Operation(int a, int b);
        Operation op;
        public void Test() {

            EventSiNegatif += TestDelegates_EventSiNegatif;
            EventInfoSiNegatif += TestDelegates_EventInfoSiNegatif;
            op = new Operation(addition);
            op += soustraction;

            int res = op(25, 50);
            Console.WriteLine("Resultat : " + res);
            res = op(res, 100);
            Console.WriteLine("Resultat : " + res);


        }

        private void TestDelegates_EventInfoSiNegatif(object sender, InfoEventArgs e)
        {
            //Gestionnaire d'Evenement!!
            Console.WriteLine("******************************************");
            Console.WriteLine("==>Déclenchement Evenement : valeur négative = "+e.Negatif);
            Console.WriteLine("******************************************");
        }

        private void TestDelegates_EventSiNegatif(object sender, EventArgs e)
        {
            //Gestionnaire d'Evenement!!
            Console.WriteLine("******************************************");
            Console.WriteLine("==>Déclenchement Evenement : valeur négative!!");
            Console.WriteLine("******************************************");
        }
        private int soustraction(int a, int b)
        {
            Console.WriteLine("Soustraction..");
            op -= soustraction;
            if(a - b < 0)
            {
                //Declencher Event!
                EventSiNegatif(this, new EventArgs());
                EventInfoSiNegatif(this, new InfoEventArgs(a - b));
            }
            return a - b;
        }
        private int addition(int a, int b)
        {
            total = a + b;
            Console.WriteLine("Addition..");          

            return a + b;
        }
    }
}
