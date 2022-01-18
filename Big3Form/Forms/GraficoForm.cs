using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big3Form.Forms
{
    public partial class GraficoForm : Form
    {
        public GraficoForm()
        {
            InitializeComponent();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 1),
                        new ObservablePoint(1, 2),
                        new ObservablePoint(2, 3),
                        new ObservablePoint(3, 4),
                        new ObservablePoint(4, 5),
                        new ObservablePoint(5, 6),
                        new ObservablePoint(6, 7),

                    },
                    PointGeometrySize = 15
                },

                 new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 2),
                        new ObservablePoint(1, 3),
                        new ObservablePoint(2, 4),
                        new ObservablePoint(3, 5),
                        new ObservablePoint(4, 6),
                        new ObservablePoint(5, 7),
                        new ObservablePoint(6, 8),

                    },
                    PointGeometrySize = 15
                },

                  new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0, 3),
                        new ObservablePoint(1, 4),
                        new ObservablePoint(2, 5),
                        new ObservablePoint(3, 6),
                        new ObservablePoint(4, 7),
                        new ObservablePoint(5, 8),
                        new ObservablePoint(6, 9),

                    },
                    PointGeometrySize = 15
                }
            };
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
