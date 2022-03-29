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
        static Series GraphPoints;
        static Title GraphTitle;
        static ChartArea Area;
        public static string current_id="";
        public static ComboBox box = new ComboBox();
        public static int cpt = 0;
        public GraphsControl()
        {
            InitializeComponent();
            GraphBuilder();
            box = comboBox_time;
            box.Items.Add("minute");
            box.Items.Add("heure");
            
        }
        public static void setCpt() 
        {
            cpt++;
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
            Area.AxisY.Maximum = 65535;
            Area.AxisX.Minimum = 0;
            
            Chart.Titles.Add(GraphTitle);
            Chart.ChartAreas.Add(Area);
            Chart.Series.Add(GraphPoints);

        }
        public static void GraphUpdate(uint value)
        {
            if (box.Text == "minute")
            {
                //reset le tab si il depasse les 60 sec
                if (cpt>59)
                {
                    GraphPoints.Points.Clear();
                }
                cpt = cpt % 60;
                
            }
            else
            {
                if (cpt > 3599)
                {
                    GraphPoints.Points.Clear();
                }
                cpt = cpt % 3600;
            }
            //
            //GraphTitle = new Title("Local avec id " + current_id);
            GraphPoints.Points.AddXY(cpt, value);

        }
    }
}
