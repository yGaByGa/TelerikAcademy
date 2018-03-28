using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030.SymetricArrays
{
    class SymetricArrays
    {
        static void Main()
        {
            bool symetric = true;

            int n = int.Parse(Console.ReadLine());
            string[] saySimOrNo = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] checksim = Console.ReadLine().Split();

                if (checksim.Length == 1)
                {
                    saySimOrNo[i] = "Yes";
                }
                if (checksim.Length == 2)
                {
                    if (checksim[0] == checksim[1])
                    {
                        saySimOrNo[i] = "Yes";
                    }
                    else
                    {
                        saySimOrNo[i] = "No";
                    }
                }

                symetric = true;
                for (int j = 0; j < (checksim.Length - 1) / 2; j++)
                {
                    if (checksim[j] != checksim[checksim.Length - 1 - j])
                    {
                        symetric = false;
                        saySimOrNo[i] = "No";
                        break;
                    }
                    else
                    {
                        saySimOrNo[i] = "Yes";
                    }
                }
            }

            foreach (var x in saySimOrNo)
            {
                Console.WriteLine(x);
            }
        }
    }
}
