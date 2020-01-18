using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertor_bcd
{
    class Program
    {
        static int complemnt(int n)
            {
            int aux = n,j=0,u=0;
            while(aux!=0)
            {
                j++;
                aux /= 10;
            }
            for (int i = 0; i < j; i++)
                u = u * 10 + 9;

            return n+u;
            }
        static void Main(string[] args)
        {
            Console.Write("Numarul: ");
            int n = int.Parse(Console.ReadLine());
            bool negativ = false;
            if (n < 0)
            {
                negativ = true;
                n = complemnt(n);
            }
                string[] cifre = new string[10];
                cifre[0] = "0000 ";
                cifre[1] = "1000 ";
                cifre[2] = "0100 ";
                cifre[3] = "1100 ";
                cifre[4] = "0010 ";
                cifre[5] = "1010 ";
                cifre[6] = "0110 ";
                cifre[7] = "1110 ";
                cifre[8] = "0001 ";
                cifre[9] = "1001 ";
            StringBuilder sb = new StringBuilder();
            while(n!=0)
            {
                sb.Append(cifre[n%10]);
                n /= 10;
            }
            if (negativ)
                sb.Append("1001");
            else
                sb.Append("0000");
            Console.Write("Numarul in BCD:");
            Console.WriteLine(sb.ToString().Reverse().ToArray());
            Console.ReadKey();
        }
    }
}
