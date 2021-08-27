<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571146/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T180068)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Wpf_MapControl_BubbleChartDataAdapter/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: automatically generate bubble chart items from a datasource


This example demonstrates how to generate bubble chart items from a datasource. Also it shows how to load a shapefile.


<h3>Description</h3>

<p>To generate bubble charts from a data source, do the following.<br />1. Create a <strong>BubbleChartDataAdapter</strong> object and assign it to the <strong>VectorLayer.Data </strong>property.<br />2. Bind a data source to the <strong>DataSource</strong> property of the object.<br />3. Specify mappings to assign data fields to bubble properties. For this, specify the <strong>Latitude</strong>, <strong>Longitude</strong> and<strong> Value</strong> properties of the <strong>MapBubbleMappingInfo</strong> object assigned to the <strong>BubbleChartDataAdapter.Mappings</strong> property.</p>

<br/>


