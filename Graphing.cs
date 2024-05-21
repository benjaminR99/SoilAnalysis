using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Front
{
    public static class Graphing
    {
        public static void InitializePlot(PlotView plotView, List<float> listSeive, List<float> retaingPercentage)
        {

            PlotModel model = new PlotModel
            {
                Title = "Particle Size Distribution Curve",
                TitleFontSize = 14
            };

            var xAxis = new LogarithmicAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Particle Size"
            };
            LinearAxis yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Seive size"
            };

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            LineSeries distributionCurve = new LineSeries
            {
                Title = "Particle Size Distribution",
            };



            for (int i = 0; i < listSeive.Count; i++)
            {
                distributionCurve.Points.Add(new DataPoint(listSeive[i], retaingPercentage[i]));
            }

            model.Series.Add(distributionCurve);
            plotView.Model = model;
        }
    }
}
