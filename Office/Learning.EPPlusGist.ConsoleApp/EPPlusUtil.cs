using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.EPPlusGist.ConsoleApp
{
    public class EPPlusUtil
    {
        public static void ReadData(string path, int sheetIndex)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            var excel = new ExcelPackage(fs);
            var sheet = excel.Workbook.Worksheets[sheetIndex];

            var row = sheet.Dimension.End.Row;
            var col = sheet.Dimension.End.Column;
            Console.WriteLine(row);
            Console.WriteLine(col);

            for (var i = 1; i <= row; i++)
            {
                for (var j = 1; j <= col; j++)
                {
                    Console.WriteLine(sheet.Cells[i, j].Value);
                }
            }

            excel.Dispose();
            fs.Dispose();
            Console.WriteLine("完成");
        }
    }
}
