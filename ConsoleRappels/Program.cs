using ConsoleRappels.classes;
using ConsoleRappels.delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRappels
{
    class Program
    {
        #region tri generique
        static void Tri(ICompare[] aTrier) {
            ICompare temp;
            for (int i = 0; i < aTrier.Length-1; i++)
            {
                for (int j = i+1; j < aTrier.Length;j++)
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
        #endregion
        static void Main(string[] args)
        {

            //Instanciation de User
            //User u = new User("Homer", "Simpson", new DateTime(1970, 1, 1));
            //Console.WriteLine(u);

            //List<User> afip = new List<User>();

            //Stagiaire s1 = new Stagiaire("JB","D",new DateTime(1988,1,1),"CSharp");
            //Stagiaire s2 = new Stagiaire("Yendhi", "W", new DateTime(1992, 1, 1),"Asp Net");

            //Formateur f1 = new Formateur("MC", "C", new DateTime(1978, 2, 1), ".Net");
            //Formateur f2 = new Formateur("Guy", "H", new DateTime(1970, 2, 1), "Gestion Projets");

            //afip.Add(s1);
            //afip.Add(s2);
            //afip.Add(f1);
            //afip.Add(f2);

            //foreach (User x in afip)
            //{
            //    Console.WriteLine(x+" "+x.GetType().Name);
            //}


            //ICompare[] stagiaires = new ICompare[] { s2, s1 };
            //ICompare[] formateurs = new ICompare[] { f1, f2 };
            //Console.WriteLine("*****************************");
            //Console.WriteLine("Avant Tri :");
            //Console.WriteLine("*****************************");
            //foreach (var x in stagiaires)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("*****************************");
            //TriGen<ICompare> triGen1 = new TriGen<ICompare>();
            //triGen1.Tri(stagiaires);
            //triGen1.Tri(formateurs);

            ////Tri(stagiaires);
            //Console.WriteLine("Après Tri :");
            //Console.WriteLine("*****************************");
            //foreach (var x in stagiaires)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine("*****************************");
            //foreach (var x in formateurs)
            //{
            //    Console.WriteLine(x);
            //}

            new TestDelegates().Test();
            Console.WriteLine("Taper une touche pour sortir..");
            Console.ReadKey();
        }
    }
}
