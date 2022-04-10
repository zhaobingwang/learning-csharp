
using Learning.ExcelDataReaderGist.ConsoleApp;

var sampleExcelReadService = new SampleExcelReadService();
var result = sampleExcelReadService.GetSamples();

foreach (var item in result)
{
    Console.WriteLine($"{item.ID}\t{item.Name}\t{item.Gender}\t{item.DOB}\t{item.Enable}");
}
