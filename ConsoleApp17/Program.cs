using ConsoleApp17;

class DataVisualizationApp
{
    static void Main()
    {
        Console.WriteLine("Enter the type of chart (Line, Bar, Pie):");
        string chartType = Console.ReadLine();

        
        GraphFactory factory = GetFactory(chartType);
        Chart chart = factory.CreateChart();

        
        chart.Draw();
        Console.ReadLine(); 
    }

    static GraphFactory GetFactory(string chartType)
    {
        switch (chartType.ToLower())
        {
            case "line":
                return new LineChartFactory();
            case "bar":
                return new BarChartFactory();
            case "pie":
                return new PieChartFactory();
            default:
                throw new ArgumentException("Invalid chart type");
        }
    }
}