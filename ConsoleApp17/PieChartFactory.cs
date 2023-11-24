using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class PieChartFactory:GraphFactory
    {
        public override Chart CreateChart()
        {
            return new PieChart();
        }
    }
}
