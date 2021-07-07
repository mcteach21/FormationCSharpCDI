using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsoleExercices
{
    class Program
    {

        private static int DisplayMenu()
        {
            int choix;

            Console.WriteLine(" ******************************************************");
            Console.WriteLine(" * Choisir Exercice (0 pour tous | -1 pour quitter) : *");
            Console.WriteLine(" * 1. Valeur Absolue.                                 *");
            Console.WriteLine(" * 2. Equation Second Degré.                          *");
            Console.WriteLine(" * 3. Nombres d'Armstrong                             *");
            Console.WriteLine(" * 4. Nombres Parfaits                                *");
            Console.WriteLine(" * 5. Nombres Premiers                                *");
            Console.WriteLine(" * 6. Palindrome                                      *");
            Console.WriteLine(" * 7. Tri à Bulles                                    *");
            Console.WriteLine(" ******************************************************");

            Console.Write("===> : ");
            int.TryParse(Console.ReadLine(), out choix);
            return choix;
        }
        static void Main(string[] args)
        {
            ClasseExos exos = new ClasseExos();
 
          
            int n = DisplayMenu();
            while (n >= 0 && n <= 7)
            {
                switch (n)
                {
                    case 1:
                        exos.ExecuterExo1();
                        break;
                    case 2:
                        exos.ExecuterExo2();
                        break;
                    case 3:
                        exos.ExecuterExo3();
                        break;
                    case 4:
                        exos.ExecuterExo4();
                        break;
                    case 5:
                        exos.ExecuterExo5();
                        break;
                    case 6:
                        exos.ExecuterExo6();
                        break;
                    case 7:
                        exos.ExecuterExo7();
                        break;
                    default:
                        exos.ExecuterExo1();
                        exos.ExecuterExo2();
                        exos.ExecuterExo3();
                        exos.ExecuterExo4();
                        exos.ExecuterExo5();
                        exos.ExecuterExo6();
                        exos.ExecuterExo7();
                        break;
                }
                n = DisplayMenu();
            }

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
