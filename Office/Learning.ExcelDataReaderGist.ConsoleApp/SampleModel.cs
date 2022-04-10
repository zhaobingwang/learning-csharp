using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ExcelDataReaderGist.ConsoleApp
{
    public class SampleModel
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public bool Enable { get; set; }
    }
}
