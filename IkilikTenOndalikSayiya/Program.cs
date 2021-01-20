using System;

namespace IkilikTenOndalikSayiya
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string l = "";
            int i = 0;
            int k, onluk = 0;
            bool d = true;
        git:
            Console.Write("İkilik tabanda bir sayı girin:");
            int a = Convert.ToInt32(Console.ReadLine());
            l = a.ToString();
            for (int j = 0; j < l.Length; j++)
            {
                x = Convert.ToInt32(l.Substring(j, 1));
                if (x == 0 || x == 1)
                {
                    d = true;
                }
                else
                {
                    d = false;
                }

                if (d == false)
                {
                    goto git;
                }
            }
            for (; ; )
            {
                if (a == 1)
                {
                    k = 1;
                    onluk += k * (Convert.ToInt32(Math.Pow(2, i)));
                    break;
                }
                k = a % 10;
                a = a / 10;
                onluk += k * (Convert.ToInt32(Math.Pow(2, i)));
                i++;

            }
            Console.WriteLine("onluk tabanında sayımız={0}", onluk);
        }

    }
}
