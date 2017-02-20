using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFtask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 0;
            int price = 16;
            bool discounted = false;

            //ikä alennus
            Console.Write("Ikä: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 7)
            {
                discount = 100;
                discounted = true;
            }
            else if (age >= 7 && age <= 15 && discounted == false)
            {
                discount = discount + 50;
                discounted = true;
            }
            else if (age >= 65 && discounted == false)
            {
                discount = discount + 50;
                discounted = true;
            }

            //muut alennus syyt
            if (age > 15 && age < 65)
            {
                Console.WriteLine("Oletko Varusmies? Y/N");
                string conscriptResponse = Console.ReadLine();

                if (conscriptResponse == "Y" || conscriptResponse == "y" && discounted == false)
                {
                    discount = discount + 50;
                    discounted = true;
                }

                //jos varusmies ei muita alennuksia
                else
                {
                    Console.WriteLine("Oletko Mtk:n jäsen? Y/N");
                    string mtkResponse = Console.ReadLine();

                    if (mtkResponse == "Y" || mtkResponse == "y" && discounted == false)
                    {
                        discount = discount + 15;
                        discounted = true;
                    }

                    Console.WriteLine("Oletko opiskelija? Y/N");
                    string studentResponse = Console.ReadLine();

                    if (studentResponse == "Y" || studentResponse == "y" && discounted == false)
                    {
                        discount = discount + 45;
                        discounted = true;
                    }

                    //erikoisehto
                    if (mtkResponse == "Y" || mtkResponse == "y")
                    {
                        if (studentResponse == "Y" || studentResponse == "y")
                        {
                            discount = 15 + 45;
                        }
                    }
                }
            }
            //lopullisen hinnan laskeminen
            decimal lopullinen = (price - (price * Convert.ToDecimal(discount / 100m)));

            Console.WriteLine("Lippusi hinta on: " + lopullinen);
            Console.ReadKey();
        }
    }
}
