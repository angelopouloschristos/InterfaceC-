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
        static Series cMin;
        static Series wMin;
        static Series wMax;
        static Series cMax;


        static ChartArea Area;
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
            GraphPoints = new Series("Value");
            cMin = new Series("Critical Min");
            wMin = new Series("Warning Min");
            wMax = new Series("Warning Max");
            cMax = new Series("Critical Max");

            Area = new ChartArea("MyChartArea");


            

            GraphPoints.ChartType = SeriesChartType.Spline;
            GraphPoints.Color = Color.Blue;
            cMin.ChartType = SeriesChartType.Spline;
            cMin.Color = Color.Red;
            wMin.ChartType = SeriesChartType.Spline;
            wMin.Color = Color.Yellow;
            wMax.ChartType = SeriesChartType.Spline;
            wMax.Color = Color.Yellow;
            cMax.ChartType = SeriesChartType.Spline;
            cMax.Color = Color.Red;

            Area.AxisX.InterlacedColor =Color.White;
            Area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            Area.AxisY.MajorGrid.LineColor = Color.DimGray;
            Area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            Area.BackColor = Color.FromArgb(224, 224,224);
            Area.BorderColor = Color.DarkGray;
            Area.AxisY.IsStartedFromZero = false;
            Area.AxisY.Minimum = 0;
            Area.AxisY.Maximum = 65535;
            Area.AxisX.Minimum = 0;
            

            Chart.ChartAreas.Add(Area);
            Chart.Series.Add(GraphPoints);

            Chart.Series.Add(cMin);
            Chart.Series.Add(wMin);
            Chart.Series.Add(wMax);
            Chart.Series.Add(cMax);

        }
        public static void GraphUpdate(double value,byte type, int low, int high, int cmi, int wmi, int wma, int cma)
        {

            Area.AxisY.Minimum = low;
            Area.AxisY.Maximum = high;

            if (box.Text == "heure")
            {
                if (cpt > 3599)
                {
                    GraphPoints.Points.Clear();
                }
                cpt = cpt % 3600;
            }
            else
            {
                //reset le tab si il depasse les 60 sec
                if (cpt>59)
                {
                    GraphPoints.Points.Clear();
                }
                cpt = cpt % 60;
            }
            GraphPoints.Name = ""+ get_type_name(type);
            //GraphTitle = new Title("Local avec id " + current_id);
            GraphPoints.Points.AddXY(cpt, value);
            cMin.Points.AddXY(cpt, cmi);
            wMin.Points.AddXY(cpt, wmi);
            wMax.Points.AddXY(cpt, wma);
            cMax.Points.AddXY(cpt, cma);
        }
        public static string get_type_name(byte b)
        {
            if (b == 0)
            {
                return "alarme";
            }
            if (b == 1)
            {
                return "Temperature";
            }
            if (b == 2)
            {
                return "Humidite";
            }
            if (b == 3)
            {
                return "Co2";
            }

            return "type pas dans le systeme";
        }
    }
}
