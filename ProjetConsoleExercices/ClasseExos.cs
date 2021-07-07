using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsoleExercices
{
    class ClasseExos
    {
        public void ExecuterExo1()
        {
            //code..résolution exo1
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************Exercice 1 : Valeur Absolue***********");
            
            int nombre;        
            Console.WriteLine("Veuillez saisir un nombre : ");
            String saisie = Console.ReadLine();

            if (int.TryParse(saisie, out nombre))
            {
                int nombre_val_abs = (nombre < 0) ? -1 * nombre : nombre;
                Console.WriteLine("Valeur absolue de {0} est : {1}", nombre, nombre_val_abs);
            }
            else
            {
                Console.WriteLine("Saisie non valide! opération impossible.");
            }

            Console.WriteLine("****************************************************");
        }
        public void ExecuterExo2()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************Exercice 2 : Equation 2° Deg.*********");

            try
            {
                Console.Write("Entrez le nombre A :");
                float A = float.Parse(Console.ReadLine());
                Console.Write("Entrez le nombre B :");
                float B = float.Parse(Console.ReadLine());
                Console.Write("Entrez le nombre C :");
                float C = float.Parse(Console.ReadLine());

                Console.WriteLine("Ensemble des solutions de l'équation {0}X²+{1}X+{2}=0 :", A, B, C);
                if (A == 0)
                {
                    if (B == 0)
                    {
                        if (C == 0)
                        {
                            Console.WriteLine("L'ensemble des réels est solution");
                        }
                        else // C!=0
                        {
                            Console.WriteLine("Il n'y a pas de solution.");
                        }
                    }
                    else // B !=0
                    {
                        float X1 = -C / B;
                        Console.WriteLine("La solution est : " + X1);
                    }
                }
                else // A !=0
                {
                    float Delta = B * B - 4 * A * C;
                    if (Delta < 0)
                    {
                        Console.WriteLine("Il n'y a pas de solution.");
                    }
                    else if (Delta == 0)
                    {
                        float X1 = -B / (2 * A);
                        Console.WriteLine("La solution est : " + X1);
                    }
                    else // Delta > 0
                    {
                        double X1 = (-B + Math.Sqrt(Delta)) / (2 * A);
                        double X2 = (-B - Math.Sqrt(Delta)) / (2 * A);
                        Console.WriteLine("Les solutions sont {0} et {1}.", X1, X2);
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Saisie(s) non valide(s)! opération annulée.");
            }
            Console.WriteLine("****************************************************");
        }

        public void ExecuterExo3()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("************Exercice 3 : Nombres Armstrong**********");
      
            Console.WriteLine("Liste des nombres d'Armstrong : ");
            for (int i = 1; i <= 5; i++)        //Les nombres de Armstrong sont tous compris entre 100 et 500
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i * i * i + j * j * j + k * k * k == i * 100 + j * 10 + k)  //Teste si le nombre est un nombre de Armstrong
                        {
                            Console.WriteLine(i * 100 + j * 10 + k);
                        }
                    }
                }
            }
            Console.WriteLine("****************************************************");
        }
        public void ExecuterExo4()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************Exercice 4 : Nombres Parfaits*********");
            
            int compt = 0, n, k, somdiv, nbr;
            System.Console.Write("Combien de nombres parfaits? : ");
            n = Int32.Parse(System.Console.ReadLine());
            nbr = 2;
            while (compt != n)
            {
                somdiv = 1;
                k = 2;
                while (k <= nbr / 2)
                {
                    if (nbr % k == 0) somdiv += k;
                    k++;
                }
                if (somdiv == nbr)
                {
                    System.Console.WriteLine(nbr + " est un nombre parfait.");
                    compt++;
                }
                nbr++;
            }
            Console.WriteLine("****************************************************");
        }
        public void ExecuterExo5()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("**************Exercice 5 : Nombres Premiers*********");

            int divis, nbr, n, compt = 0;
            bool Est_premier;
            System.Console.Write("Combien de nombres premiers? : ");
            n = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine(2);
            nbr = 3;
            while (compt < n - 1)
            {
                divis = 2;
                Est_premier = true;
                do
                {
                    if (nbr % divis == 0) Est_premier = false;
                    else divis = divis + 1;
                }
                while ((divis <= nbr / 2) && (Est_premier == true));
                if (Est_premier)
                {
                    compt++;
                    System.Console.WriteLine(nbr);
                }
                nbr++;
            }
            Console.WriteLine("****************************************************");
        }
        public void ExecuterExo6()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("*****************Exercice 6 : Palindrome************");

            System.Console.WriteLine("Entrez une phrase :");
            string phrase = System.Console.ReadLine();
            string strMot = compresser(phrase.ToLower());
            string strInv = inverser(strMot);

            Console.WriteLine(" strMot = " + strMot);
            Console.WriteLine(" strInv = " + strInv);


            if (strMot.Equals(strInv))
                Console.WriteLine("Phrase palindrome !");
            else
                Console.WriteLine("Phrase non palindrome !");

            Console.WriteLine("****************************************************");
        }

        public void ExecuterExo7()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("***************Exercice 7 : Tri a Bulles************");
            //Déclaration + Initialisation Tableau
            //Random rnd = new Random();
            //int nb = rnd.Next(10, 15);

            //int[] tab = new int[nb];
            //for (int x = 0; x < nb; x++)
            //{
            //    tab[x] = rnd.Next(500);
            //}
            //foreach (var item in tab)
            //{
            //    Console.Write(item+"\t");
            //}
            //Console.WriteLine();
            //Array.Sort(tab);
            //foreach (var item in tab)
            //{
            //    Console.Write(item + "\t");
            //}
            //Console.WriteLine();

            int[] tableau = { 0, 25, 7, 14, 26, 25, 53, 74, 99, 24, 98, 58, 36, 91, 52 };

            System.Console.WriteLine("Tableau initial :");
            int n = tableau.Length - 1;
            for (int i = 0; i <= n; i++)
                System.Console.Write(((i == 0) ? "" : ",") + tableau[i]);
            System.Console.WriteLine();

            //Tri à Bulles
            //n = tableau.Length - 1;
            for (int i = n; i >= 1; i--)
                for (int j = 2; j <= i; j++)
                    if (tableau[j - 1] > tableau[j])
                    {
                        int temp = tableau[j - 1];
                        tableau[j - 1] = tableau[j];
                        tableau[j] = temp;
                    }

            System.Console.WriteLine("Tableau trié :");
            for (int i = 0; i <= n; i++)
                System.Console.Write(((i == 0) ? "" : ",") + tableau[i]);
            System.Console.WriteLine();
            Console.WriteLine("****************************************************");
        }

        private string compresser(string s)
        {
            String strLoc = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && s[i] != ',' && s[i] != '\'' && s[i] != '.')
                    strLoc += s[i];
            }
            return strLoc;
        }
        private string inverser(string s)
        {
            String strLoc = "";
            for (int i = 0; i < s.Length; i++)
                strLoc = s[i] + strLoc;
            return strLoc;
        }
        private string inverser2(string s)
        {
            char[] tChar = s.ToCharArray();
         
            char car;
            for (int i = 0, j = tChar.Length - 1; i < j; i++, j--)
            {
                car = tChar[i];
                tChar[i] = tChar[j];
                tChar[j] = car;
            }
            return new string(tChar);
        }
    }
}
