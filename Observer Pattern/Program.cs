namespace Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We instantiate our datasource and our observers
            var datasource = new DataSource();
            var chart = new Chart();
            var spreadsheet = new SpreadSheet();

            //We add observers to our datasource
            datasource.Attach(chart);
            datasource.Attach(spreadsheet);

            //We modify our datasource
            datasource.AddData("Data1");
            datasource.RemoveData("Data1");
        }
    }
}