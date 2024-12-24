# How to get the PropertyType of the columns in AutoGeneratingColumn event in DataGrid ?
In this article, we will show you how to get the PropertyType of the columns in AutoGeneratingColumn event in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ColumnWidthMode="Auto"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       AutoGeneratingColumn="dataGrid_AutoGeneratingColumn" 
                       CellTapped="dataGrid_CellTapped"
                       ItemsSource="{Binding Employees}">
   
</syncfusion:SfDataGrid>
``` 

## C#
The code below demonstrates how to retrieve the PropertyType of a particular column using its mapping name in the AutoGeneratingColumn event.
```
private void dataGrid_AutoGeneratingColumn(object sender, Syncfusion.Maui.DataGrid.DataGridAutoGeneratingColumnEventArgs e)
{
    if(e.Column.MappingName == "Name")
    {
        var PropertyType = e.PropertyType;
        DisplayAlert("Type", $"{PropertyType}", "OK");
    }
}
```

 ![PropertyType.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0MzQ1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.6NXspx7XgSiFkE_6f4m-PlMWM9NDFD9uqe__dtpF5zA)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-get-the-PropertyType-of-the-columns-in-AutoGeneratingColumn-event-in-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to get the PropertyType of the columns in AutoGeneratingColumn event in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!