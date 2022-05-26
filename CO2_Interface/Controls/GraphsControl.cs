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
            box.SelectedIndex=0;
            
        }
        public static void setCpt() 
        {
            cpt++;
        }

        
        public void GraphBuilder()
        {
            /*
            GraphPoints = new Series("Value");
            

            Area = new ChartArea("MyChartArea");

            

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

           */

            Area = new ChartArea("MyChartArea");
            GraphPoints = new Series("Value");
            Area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            Area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;

            cMin = new Series("Critical Min");
            wMin = new Series("Warning Min");
            wMax = new Series("Warning Max");
            cMax = new Series("Critical Max");

            cMin.ChartType = SeriesChartType.Spline;
            cMin.Color = Color.Red;
            wMin.ChartType = SeriesChartType.Spline;
            wMin.Color = Color.Orange;
            wMax.ChartType = SeriesChartType.Spline;
            wMax.Color = Color.Orange;
            cMax.ChartType = SeriesChartType.Spline;
            cMax.Color = Color.Red;


            GraphPoints.ChartType = SeriesChartType.Spline;

            GraphPoints.Color = Color.Blue;
            Chart.ChartAreas.Add(Area);

            Chart.Series.Add(cMin);
            Chart.Series.Add(wMin);
            Chart.Series.Add(wMax);
            Chart.Series.Add(cMax);
            Chart.Series.Add(GraphPoints);

            GraphPoints.Points.Clear();
            /*
            for (int i = 0; i < 60; i++)
            {
                GraphPoints.Points.Add(0);
            }*/
        }
        public static void GraphUpdate(double value,byte type, int low, int high, int cmi, int wmi, int wma, int cma)
        {
            Area.AxisY.Minimum = low;
            Area.AxisY.Maximum = high;

            if (box.Text == "heure")// je le utilise pas encore
            {
                if (cpt > 3599)
                {
                    GraphPoints.Points.RemoveAt(0);
                }
                cpt = cpt % 3600;
            }
            else
            {
                //reset le tab si il depasse les 60 sec
                
            }
            
            GraphPoints.Name = ""+ SerialDataHandler.Reception.get_type_name(type);
            //GraphPoints.Points.AddXY(cpt, value);
            
            //jai mis 20 pour debug -> cv plus vite
            if (cpt>20) 
            {
                cpt = 0;
                GraphPoints.Points.Clear();
                cMin.Points.Clear();
                wMin.Points.Clear();
                wMax.Points.Clear();
                cMax.Points.Clear();
            }
            cMin.Points.Add(cmi);
            wMin.Points.Add(wmi);
            wMax.Points.Add(wma);
            cMax.Points.Add(cma);
            GraphPoints.Points.Add(value);

            //cpt = cpt % 30;

        }
    }
}
