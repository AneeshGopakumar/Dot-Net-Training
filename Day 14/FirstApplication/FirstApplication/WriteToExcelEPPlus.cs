using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14
{
    internal class WriteToExcelEPPlus
    {
        public static void Main2()
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent;
            var filePath = directory + "\\excelfiles\\PersonData.xlsx";
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            var peopleData = new[,]
             {
              {"FirstName","LastName","Age"},
              {"ABC","DEF","10"},
               {"GHI","JKL","20"},
                {"MNO","PQR","30"},
            };

            using (var excelPackageObject = new ExcelPackage())
            {
                var workSheet = excelPackageObject.Workbook.Worksheets.Add("Sheet");
                for (int row = 0; row < peopleData.GetLength(0); row++)
                {
                    for (int col = 0; col < peopleData.GetLength(1); col++)
                    {
                        workSheet.Cells[row + 1, col + 1].Value = peopleData[row, col];
                    }
                }
                File.WriteAllBytes(filePath, excelPackageObject.GetAsByteArray());
            }

            Console.WriteLine("");
        }
    }
}