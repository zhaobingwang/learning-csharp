using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ExcelDataReaderGist.ConsoleApp
{
    public class SampleExcelReadService
    {
        public List<SampleModel> GetSamples()
        {
            var ds = ExcelDataReaderUtil.Read("Files/sample.xlsx");
            var sheetCount = ds.Tables.Count;
            //foreach (var item in ds.Tables)
            //{
            //    var aa = item;
            //}
            List<SampleModel> result = new List<SampleModel>();
            for (int i = 0; i < sheetCount; i++)
            {
                var sheet = ds.Tables[i];
                var rowCount = sheet.Rows.Count;
                for (int j = 0; j < rowCount; j++)
                {
                    if (j == 0)
                    {
                        // TODO:标题行单独处理
                        continue;
                    }
                    else
                    {
                        var row = sheet.Rows[j].ItemArray;
                        SampleModel sampleModel = new SampleModel();
                        if (row[0]!.GetType().Name == "DBNull")
                        {
                            continue;
                        }
                        else
                        {
                            sampleModel.ID = Convert.ToInt32(row[0]);
                        }

                        if (row[1]!.GetType().Name == "DBNull")
                        {
                            continue;
                        }
                        else
                        {
                            sampleModel.Name = row[1].ToString();
                        }

                        if (row[2]!.GetType().Name == "DBNull")
                        {
                            continue;
                        }
                        else
                        {
                            sampleModel.Gender = row[2].ToString();
                        }

                        if (row[3]!.GetType().Name == "DBNull")
                        {
                            continue;
                        }
                        else
                        {
                            sampleModel.DOB = DateTime.Parse(row[3].ToString());
                        }

                        if (row[3]!.GetType().Name == "DBNull")
                        {
                            continue;
                        }
                        else
                        {
                            sampleModel.Enable = Boolean.Parse(row[4].ToString());
                        }
                        result.Add(sampleModel);
                    }
                }
            }
            return result;
        }
    }
}
