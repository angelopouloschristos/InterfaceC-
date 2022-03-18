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
        private Queue<int> MyList;
        Timer timer1;
        Series GraphPoints;
        Title GraphTitle;
        ChartArea Area;
        public GraphsControl()
        {
            InitializeComponent();
            GraphBuilder();     
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if (MyList.Count > 99) MyList.Dequeue();
            MyList.Enqueue(rnd.Next(0, 1000));

            GraphUpdate();
        }
        public void GraphBuilder()
        {
            MyList = new Queue<int>();
            GraphPoints = new Series("MySerie");
            GraphTitle = new Title("MyTitle");
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
            Area.AxisY.Minimum = 0;
            Area.AxisY.Maximum = 1000;
            Area.AxisX.Minimum = 0;
            
            Chart.Titles.Add(GraphTitle);
            Chart.ChartAreas.Add(Area);
            Chart.Series.Add(GraphPoints);

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 200; // in miliseconds
            timer1.Start();
        }
        private void GraphUpdate()
        {
            GraphPoints.Points.Clear();

            for (int i = 0; i < MyList.Count; i++) GraphPoints.Points.AddXY(i, MyList.ElementAt(i));
        }
    }
}
