using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CO2_Interface.Controls
{
    public partial class GraphsControl : UserControl
    {
        Series GraphPoints;
        Title GraphTitle;
        ChartArea Area;
        public string current_id;
        public int cpt = 0;
        public GraphsControl()
        {
            InitializeComponent();
            GraphBuilder();
            
        }
        
        public void GraphBuilder()
        {
            GraphPoints = new Series("Taux de co2");
            GraphTitle = new Title("Local avec id "+current_id);
            Area = new ChartArea("MyChartArea");


            GraphPoints.ChartType = SeriesChartType.Spline;
            GraphPoints.Color = Color.DarkRed;

            Area.AxisX.InterlacedColor =Color.White;
            Area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            Area.AxisY.MajorGrid.LineColor = Color.DimGray;
            Area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            Area.BackColor = Color.FromArgb(224, 224,224);
            Area.BorderColor = Color.DarkGray;
            Area.AxisY.IsStartedFromZero = false;
            Area.AxisY.Minimum = 5000;
            Area.AxisY.Maximum = 70000;
            Area.AxisX.Minimum = 0;
            
            Chart.Titles.Add(GraphTitle);
            Chart.ChartAreas.Add(Area);
            Chart.Series.Add(GraphPoints);

        }
        public void GraphUpdate(uint value)
        {
            //GraphPoints.Points.Clear();
            GraphPoints.Points.AddXY(cpt, value);

        }
    }
}
