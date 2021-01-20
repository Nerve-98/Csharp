using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace COMInterop
{
    class MainApp
    {
        static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            for(int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)workSheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)workSheet.Cells[i + 1, 2]).Value2 = data[i, 1];
            }

            workSheet.SaveAs(savePath + "\\oldway.xlsx",
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
            excelApp.Quit();
        }

        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();


            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                workSheet.Cells[i + 1, 1] = data[i, 0];
                workSheet.Cells[i + 1, 2] = data[i, 1];
            }
            workSheet.SaveAs(savePath + "\\newway.xlsx");
            excelApp.Quit();
        }

        static void Main(string[] args)
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                { "a", "1" },
                { "b", "2" },
                { "c", "3" }
            };

            Console.WriteLine("creating in old way");
            OldWay(array, savePath);

            Console.WriteLine("creating in new way" + array.Length+array[0,1]);
            NewWay(array, savePath);

        }

    }
}
