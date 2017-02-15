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

           if(age < 7)
            {
                discount = 100;
                discounted = true;
            }

            else if(age >= 7 && age <= 15 && discounted == false)
            {
                discount = discount + 50;
                discounted = true;
            }

            else if(age >= 65 && discounted == false)
            {
                discount = discount + 50;
                discounted = true;
            }

            //muut alennus syyt
            if (age > 15 && age < 65)
            {
                Console.WriteLine("Oletko Varusmies? Y/N");
                string yn2 = Console.ReadLine();

                if (yn2 == "Y" || yn2 == "y" && discounted == false)
                {
                    discount = discount + 50;
                    discounted = true;
                }

                 //jos varusmies ei muita alennuksia
               else
                {
                    Console.WriteLine("Oletko Mtk:n jäsen? Y/N");
                     string yn1 = Console.ReadLine();

                      if (yn1 == "Y" || yn1 == "y" && discounted == false)
                          {
                               discount = discount + 15;
                               discounted = true;
                          }

                    Console.WriteLine("Oletko opiskelija? Y/N");
                    string yn3 = Console.ReadLine();

                          if (yn3 == "Y" || yn3 == "y" && discounted == false)
                              {
                                  discount = discount + 45;
                                  discounted = true;
                             }

                    //erikoisehto
                    if (yn1 == "Y" || yn1 == "y")
                    {
                        if (yn3 == "Y" || yn3 == "y")
                        {
                            discount = 15 + 45;
                        }
                    }
                }
            }
            //lopullisen hinnan laskeminen
           decimal lopullinen = (price - (price * Convert.ToDecimal(discount/100m)));

           Console.WriteLine("Lippusi hinta on: " + lopullinen); 
           Console.ReadKey();
        }
    }
}
