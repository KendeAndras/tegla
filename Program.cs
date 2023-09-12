using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace Teglalap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Szia Uram! Teglalap erdekel?");
            Console.WriteLine();

            //a es b input/bemenet
            Console.WriteLine("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Feldolgozas
            double T = a * b;
            double K = (a + b) * 2;

            //T es K output/kimenet
            Console.WriteLine("Terület: {0}, Kerület: {1}" , T , K);
            Console.WriteLine("Battya nyomsz valamit esku kilep");
            Console.ReadKey();
            */

            double a;
            double b;
            bool error;
            string input;

            //bemenet
            do
            {
                Console.WriteLine("egyik oldal(pozitiv szam): ");
                input = Console.ReadLine();
                //tryparse igazat ad ha van, de nekunk hamis kell, ezert tagadunk - ! a logikai tagadas jele
                error = !double.TryParse(input, out a);

                if (error)
                {
                    Console.WriteLine("nemjo, legyen nagyobb mint 0 es NE szoveg");
                    Console.WriteLine("ujra...egyik oldal(ami pozitiv): ");


                }
            } while (error);
                {
                    do
                    {
                        Console.WriteLine("masik oldal(pozitiv szam): ");
                        input = Console.ReadLine();
                        error = !double.TryParse(input, out b);

                    if (error)
                        {
                            Console.WriteLine("te fasz... mit nem ertessz azon, h egyen nagyobb mint 0 es szamot adj a rak egyen meg?!");
                        }

                    } while (error);

                    {
                        //Feldolgozas
                        double T = a * b;
                        double K = (a + b) * 2;

                        //T es K output/kimenet
                        Console.WriteLine("Terület: {0} cm2, Kerület: {1} cm", T, K);
                        Console.WriteLine("Battya nyomsz valamit esku kilep");
                        Console.ReadKey();
                    }

                }

            }
    
        }
    }
