using static System.Console;

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.ServiceModel;

namespace ConsoleTests
{
    
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public string MiddleName { get; } = "";
        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }
        //public string AllCaps()
        //{         
        //    return ToString().ToUpper();
        //}

        public string AllCaps() => ToString().ToUpper();
        //public override string ToString() => String.Format("{0} {2} {1}.", FirstName, LastName, MiddleName);
        public override string ToString() => $"{FirstName} {MiddleName} {LastName}";


    }

    public class Program
    {

        public static void Main()
        {
            //var p = new Person("Bill", "Wagner");
            //WriteLine("The name, in all caps: " + p.AllCaps());
            //WriteLine($"The name : {p}");

            //var phrase = "the quick brown fox jumps over the lazy dog";
            //var words = from word in phrase.Split(" ") select word;
            //WriteLine($"[{string.Join(", ", words)}]");

            //var lengths = from word in phrase.Split(" ") select word.Length;
            //WriteLine($"The average word length is: {lengths.Average():F2}"); //float-2

            //string s = null;

            //Write("yout name?");
            //s = ReadLine();

            //bool hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            //WriteLine(hasMore);


            //WriteLine(nameof(System.String));
            //int j = 5;
            //WriteLine(nameof(j));
            //List<string> names = new List<string>();
            //WriteLine(nameof(names));


            /**
             * Events..
             */
            //CustomEvent = new EventHandler<EventArgs>(CustomEventDoSomething);

            //Thread th = new Thread(DoLooping);
            //th.Start();

            //th.Join();

            //WriteLine("Main Thread..End!");

            /**
             * Call WebService
             */


            WriteLine("");
            MyBasicServiceReference.MyBasicWebServiceSoapClient client =
                new MyBasicServiceReference.MyBasicWebServiceSoapClient(new BasicHttpsBinding(BasicHttpsSecurityMode.Transport), 
                    new EndpointAddress("https://localhost:44385/MyBasicWebService.asmx"));

            string info = client.InfosAsync().ToString();

            WriteLine(info);


        }

        /**
         * Events
         */
        private static event EventHandler<EventArgs> CustomEvent;
        private static void CustomEventDoSomething(object sender, EventArgs e)
        {
            WriteLine($"{sender} : Hello from custom event..");
        }

        private static void DoLooping()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                    CustomEvent(i, new EventArgs());

                if (i == 50)
                    new Thread(
                        () =>
                        {
                            Console.WriteLine("Anonymous Thread job...");
                        }).Start();

                Thread.Sleep(100);
            }
                
            
        }
    }
}
