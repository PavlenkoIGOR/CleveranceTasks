using System.Diagnostics.Metrics;
using System.Drawing;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            int[,] array2dEnter = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            int rowsEnterArray = array2dEnter.GetUpperBound(0) + 1;
            int columnsEnterArray = array2dEnter.GetUpperBound(1) + 1; //array2d.Length / rows;

            int[] array2dExit = new int[array2dEnter.Length];
            int index2d = 0;

            int vertDist = rowsEnterArray;
            int horizDist = columnsEnterArray - 1;
            int direction = -1;
            int iterrationQuantity = rowsEnterArray > columnsEnterArray ? columnsEnterArray : rowsEnterArray;


            int x = 0;
            int y = -1;

            for (int m = 0; m < iterrationQuantity; m++)
            {
                for (int i = 0; i < vertDist; ++i)
                {
                    y -= direction;
                    array2dExit[index2d++] = array2dEnter[y, x];
                }

                vertDist--;
                for (int i = 0; i < horizDist; ++i)
                {
                    x -= direction;
                    array2dExit[index2d++] = array2dEnter[y, x];
                }
                horizDist--;
                direction *= -1;

            }

            Console.WriteLine("****** entered Array ******");
            Console.WriteLine($"rows {rowsEnterArray}");
            Console.WriteLine($"column {columnsEnterArray}");
            Console.WriteLine($"EnterArray length {array2dEnter.Length}");
            Console.WriteLine("\n****** exited Array ******");
            for (int hh = 0; hh < array2dExit.Length; hh++)
            {

                Console.Write($"{array2dExit[hh]} ");
            }
            Console.WriteLine();
            #endregion
            
        }
    }
}
