using System.Data;
using System.Globalization;
using System.Windows;

namespace Wpf_MapControl_BubbleChartDataAdapter {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        const double minMag = 6.5;
        const double maxMag = 9;
        const int minYear = 1996;
        const int maxYear = 1999;
        const string filepath = "..\\..\\Data\\Earthquakes.xml";

        DataTable dataTable;

        public DataTable Data { get { return dataTable; } }

        public MainWindow() {
            InitializeComponent();
            DataContext = this;
            SetData();
        }

        void SetData() {
            dataTable = CreateData();
            string magnitudeFilter = string.Format(CultureInfo.InvariantCulture, "mag >= {0} AND mag <= {1}", minMag, maxMag);
            string yearFilter = string.Format(CultureInfo.InvariantCulture, "yr >= {0} AND yr <= {1}", minYear, maxYear);
            dataTable.DefaultView.RowFilter = string.Format(CultureInfo.InvariantCulture, "({0}) AND ({1})", magnitudeFilter, yearFilter);
        }

        DataTable CreateData() {
            DataSet ds = new DataSet();
            ds.ReadXml(filepath);
            return ds.Tables[0];
        }
    }
}





