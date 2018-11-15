<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml))
<!-- default file list end -->
# How to: automatically generate bubble chart items from a datasource


This example demonstrates how to generate bubble chart items from a datasource. Also it shows how to load a shapefile.


<h3>Description</h3>

<p>To generate bubble charts from a data source, do the following.<br />1. Create a <strong>BubbleChartDataAdapter</strong> object and assign it to the <strong>VectorLayer.Data </strong>property.<br />2. Bind a data source to the <strong>DataSource</strong> property of the object.<br />3. Specify mappings to assign data fields to bubble properties. For this, specify the <strong>Latitude</strong>, <strong>Longitude</strong> and<strong> Value</strong> properties of the <strong>MapBubbleMappingInfo</strong> object assigned to the <strong>BubbleChartDataAdapter.Mappings</strong> property.</p>

<br/>


