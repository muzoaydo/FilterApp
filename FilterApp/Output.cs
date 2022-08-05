using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterApp
{
    public class Output
    {
        public static void DumpArray(int[,] arr, string fileName, int XRes, int YRes)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    //file.Write("[");
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        file.Write(arr[j, i] + ",");
                    }
                    //file.Write("]\r\n");
                    file.Write("\r\n");
                }
                file.Close();
            }

        }
    }
}
