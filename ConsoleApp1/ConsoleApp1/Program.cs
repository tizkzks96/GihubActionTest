using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            double money = 100;
            Random r = new Random();
            double count = 0;
            double bat;
            int select;
            int roboPick;
            int result;
            int co = 0;
            double ra = 0;
            while (true)
            {
                count++;
                ////Console.WriteLine("your money : " + money + "");
                ////Console.Write("bat your money: ");
                //bat = 1;// double.Parse(Console.ReadLine());
                //money -= bat;
                //// = int.Parse(Console.ReadLine());
                //roboPick = r.Next(0, 2);
                //select = roboPick;
                //if (select > 1) continue;
                result = r.Next(0, 2);

                if (result == 1) ++ra;
                else if (result == 0) --ra;
                
                ////Console.WriteLine("result : " + result + "");
                //if (select == 1)
                //{
                //    if(result == 1)
                //    {
                //        bat += bat;
                //    }
                //    else
                //    {
                //        bat = 0;
                //    }
                //}

                //if(select == 0)
                //{
                //    if (result == 0)
                //    {
                //        bat += bat;
                //    }
                //    else
                //    {
                //        bat = 0;
                //    }
                //}
                //money += bat;

                //if (money <= 0)
                //{
                //    sb.AppendLine("you lose : " + money);
                //}
                //else
                //{
                //    sb.AppendLine("result : " + money);
                //}

                if (count % 100000000 == 0) Console.WriteLine(ra + "count : " + co);
                sb.Clear();

                if (count % 1000000000 == 0)
                {
                    co++;
                    count = 0;
                }

            }
            Console.WriteLine(sb);
            sb.Clear();
        }
    }
}
