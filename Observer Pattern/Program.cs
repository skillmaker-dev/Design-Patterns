namespace Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var datasource = new DataSource();
            var chart = new Chart();
            var spreadsheet = new SpreadSheet();

            datasource.Attach(chart);
            datasource.Attach(spreadsheet);

            datasource.AddData("Data1");
            datasource.RemoveData("Data1");
        }
    }
}