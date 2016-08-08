using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintConcentricRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 6;
            var result = new Program().prettyPrint(size);
            for (int i = 0; i < size * 2 - 1; i++)
            {
                for (int j = 0; j < size * 2 - 1; j++)
                    Console.Write(result[i, j] + " ");
                Console.WriteLine();
            }
        }

        public int[,] prettyPrint(int a)
        {
            int size = (2 * a) - 1;
            int[,] resultArr = new int[size, size];
            for (int i = a; i >= 1; i--)
            {
                fillArr(resultArr, i, i, size);
            }
            return resultArr;
        }

        public void fillArr(int[,] resultArr, int pos, int val, int size)
        {
            int offset = (size + 1) / 2 - val;
            for (int i = offset; i < size - offset; i++)
                resultArr[offset, i] = val;

            for (int i = offset; i < size - offset; i++)
                resultArr[size - offset - 1, i] = val;

            for (int i = offset; i < size - offset; i++)
                resultArr[i, offset] = val;

            for (int i = offset; i < size - offset; i++)
                resultArr[i, size - offset - 1] = val;


        }
    }
}
