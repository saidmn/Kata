using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static string compute(String Num)
        {
            String ResultFinal = ""; //Resultat Finale
            string rs = "";//rs: résultat pour la division et pour tester si le nombre contient 3,5,7 et 0

            long Number = long.Parse(Num);

            if (Number % 3 == 0)
                rs += "Foo";

            if (Number % 5 == 0)
                rs += "Bar";

            if (Number % 7 == 0)
                rs += "Qix";

            for (int i = 0; i < Num.Length; i++)
            {
                if (Num[i].Equals('3'))
                    rs += "Foo";
                else if (Num[i].Equals('5'))
                    rs += "Bar";
                else if (Num[i].Equals('7'))
                    rs += "Qix";
                else if (Num[i].Equals('0'))
                    rs += "*";
            }

            if (rs == "")
                ResultFinal = Num;
            else if (rs == "*")
            {
                for (int i = 0; i < Num.Length; i++)
                    if (Num[i].Equals('0'))
                        ResultFinal = ResultFinal + "*";
                    else ResultFinal = ResultFinal + Num[i];
            }
            else ResultFinal = rs;

            return ResultFinal;
        }

        static void Main()
        {
            string resultat;
            for (int i = 0; i < 10; i++) //choix arbitraire pour tester 10 numéros avant la fermeture du console
            {
                Console.WriteLine("\ndonner un numéro");
                String num = Console.ReadLine();
                resultat = compute(num);
                Console.WriteLine(num + "=>" + resultat);
            }
            Console.Read();
        }

    }
}
