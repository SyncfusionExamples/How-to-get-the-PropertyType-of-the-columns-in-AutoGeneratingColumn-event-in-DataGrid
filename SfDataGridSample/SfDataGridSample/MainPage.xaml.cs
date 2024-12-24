namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGrid_AutoGeneratingColumn(object sender, Syncfusion.Maui.DataGrid.DataGridAutoGeneratingColumnEventArgs e)
        {
            if(e.Column.MappingName == "Name")
            {
                var PropertyType = e.PropertyType;
                DisplayAlert("Type", $"{PropertyType}", "OK");
            }
        }
    }
}
