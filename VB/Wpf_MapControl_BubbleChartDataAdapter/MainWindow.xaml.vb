Imports System.Data
Imports System.Globalization
Imports System.Windows

Namespace Wpf_MapControl_BubbleChartDataAdapter
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Private Const minMag As Double = 6.5
        Private Const maxMag As Double = 9
        Private Const minYear As Integer = 1996
        Private Const maxYear As Integer = 1999
        Private Const filepath As String = "..\..\Data\Earthquakes.xml"

        Private dataTable As DataTable

        Public ReadOnly Property Data() As DataTable
            Get
                Return dataTable
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DataContext = Me
            SetData()
        End Sub

        Private Sub SetData()
            dataTable = CreateData()
            Dim magnitudeFilter As String = String.Format(CultureInfo.InvariantCulture, "mag >= {0} AND mag <= {1}", minMag, maxMag)
            Dim yearFilter As String = String.Format(CultureInfo.InvariantCulture, "yr >= {0} AND yr <= {1}", minYear, maxYear)
            dataTable.DefaultView.RowFilter = String.Format(CultureInfo.InvariantCulture, "({0}) AND ({1})", magnitudeFilter, yearFilter)
        End Sub

        Private Function CreateData() As DataTable
            Dim ds As New DataSet()
            ds.ReadXml(filepath)
            Return ds.Tables(0)
        End Function
    End Class
End Namespace





