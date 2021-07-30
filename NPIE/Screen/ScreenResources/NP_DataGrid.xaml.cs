using Models;
using NPIE.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NPIE.Screen.ScreenResources
{
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class NP_DataGrid : UserControl
    {
        public NP_DataGrid()
        {
            InitializeComponent();
           
        }

        public ObservableCollection<GridColumn> ColumnsList = new ObservableCollection<GridColumn>();
        public ObservableCollection<object> GridItems = new ObservableCollection<object>();
        private void dgGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (dgGrid.CurrentCell != null && dgGrid.CurrentCell.Column != null && dgGrid.CurrentCell.Column is DataGridTextColumn)
                {
                    dynamic TextBlock = (dgGrid.CurrentCell.Column as DataGridTextColumn).GetCellContent(dgGrid.SelectedItem);
                    Clipboard.SetText(TextBlock.Text);
                }
            }
            catch (Exception ex)
            {
                Clipboard.SetText("");
            }
        }

        private void dgGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (dgGrid.CurrentCell != null && dgGrid.CurrentCell.Column != null && dgGrid.CurrentCell.Column is DataGridTextColumn)
                {
                    dynamic TextBlock = (dgGrid.CurrentCell.Column as DataGridTextColumn).GetCellContent(dgGrid.SelectedItem);
                }
                else if (dgGrid.CurrentCell != null && dgGrid.CurrentCell.Column != null && dgGrid.CurrentCell.Column is DataGridTemplateColumn)
                {
                    dynamic TextBlock = (dgGrid.CurrentCell.Column as DataGridTemplateColumn).DisplayIndex;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnUnHold_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if ((Application.Current.Resources["AppViewModel"] as HomeController).SelectedPerson != null && (Application.Current.Resources["AppViewModel"] as HomeController).SelectedPerson["Status"].ToString() == "HOLD")
                //{
                //    (Application.Current.Resources["AppViewModel"] as HomeController).UnHold((Application.Current.Resources["AppViewModel"] as HomeController).SelectedPerson.Row);
                //}
            }
            catch (Exception ex)
            {

            }
        }
    }

    public class DataGridColumnsBehavior
    {
        private static DispatcherTimer myClickWaitTimer = new DispatcherTimer(new TimeSpan(0, 0, 0, 0, 300), DispatcherPriority.Background, mouseWaitTimer_Tick, Dispatcher.CurrentDispatcher);
        static Button btnPressed = null;
        public static readonly DependencyProperty BindableColumnsProperty = DependencyProperty.RegisterAttached("BindableColumns", typeof(ObservableCollection<GridColumn>), typeof(DataGridColumnsBehavior), new UIPropertyMetadata(null, BindableColumnsPropertyChanged));
        private static void BindableColumnsPropertyChanged(DependencyObject _Source, DependencyPropertyChangedEventArgs e)
        {
            try
            {

                (_Source as System.Windows.Controls.DataGrid).Columns.Clear();
                if (e.NewValue != null && e.NewValue is ObservableCollection<GridColumn> && (e.NewValue as ObservableCollection<GridColumn>).Count > 0)
                {
                    foreach (GridColumn col in (e.NewValue as ObservableCollection<GridColumn>))
                    {
                        try
                        {
                            DataGridColumn dataGridColumn = null;
                            Style ColStyle = (new Style(typeof(DataGridCell)));
                            //Add View and Bind Values
                            switch (col.ColumnType)
                            {
                                case ColumnTypes.Selection:
                                    #region Selection Column
                                    dataGridColumn = new DataGridTemplateColumn();
                                    dataGridColumn.IsReadOnly = false;
                                    //Style  
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.VerticalAlignmentProperty, Value = VerticalAlignment.Stretch });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.HorizontalAlignmentProperty, Value = HorizontalAlignment.Stretch });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BackgroundProperty, Value = Brushes.Transparent });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderBrushProperty, Value = Brushes.Transparent });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderThicknessProperty, Value = new Thickness(0) });
                                    if (!string.IsNullOrWhiteSpace(col.ToolTip))
                                    {
                                        ColStyle.Setters.Add(new Setter() { Property = DataGridCell.ToolTipProperty, Value = col.ToolTip });
                                    }
                                    dataGridColumn.CellStyle = ColStyle; 
                                   
                                    DataTemplate CheckBoxColumnTemplate = new DataTemplate();
 
                                    (dataGridColumn as DataGridTemplateColumn).CellTemplate = CheckBoxColumnTemplate;
                                    #endregion
                                    break;
                                case ColumnTypes.Text:
                                    dataGridColumn = new DataGridTextColumn();
                                    dataGridColumn.IsReadOnly = true;
                                    (dataGridColumn as DataGridTextColumn).Binding = new Binding(col.Property) { Mode = BindingMode.OneWay };
                                    break;
                                case ColumnTypes.URLColumn:
                                    dataGridColumn = new DataGridHyperlinkColumn();
                                    dataGridColumn.IsReadOnly = true;
                                    (dataGridColumn as DataGridHyperlinkColumn).Binding = new Binding(col.Property) { Mode = BindingMode.OneWay };
                                    break;
                                case ColumnTypes.Button:
                                    #region Button Column
                                    dataGridColumn = new DataGridTemplateColumn();
                                    dataGridColumn.IsReadOnly = false;

                                    //Style 
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.CursorProperty, Value = Cursors.Hand });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.VerticalAlignmentProperty, Value = VerticalAlignment.Stretch });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.HorizontalAlignmentProperty, Value = HorizontalAlignment.Stretch });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BackgroundProperty, Value = Brushes.Transparent });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderBrushProperty, Value = Brushes.Transparent });
                                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderThicknessProperty, Value = new Thickness(0) });
                                    dataGridColumn.CellStyle = ColStyle;

                                    //Template
                                    DataTemplate ButtonColumnTemplate = new DataTemplate();

                                    //Button 
                                    FrameworkElementFactory btn = new FrameworkElementFactory(typeof(Button));
                                    btn.SetValue(Button.BackgroundProperty, Brushes.Transparent);
                                    btn.SetValue(Button.BorderBrushProperty, Brushes.Transparent);
                                    btn.SetValue(Button.BorderThicknessProperty, new Thickness(0));
                                    btn.SetValue(Button.NameProperty, "Key" + col.ID.ToString());
                                    btn.SetValue(Button.StyleProperty, Application.Current.Resources["ImageButton"]);
                                    if (!string.IsNullOrWhiteSpace(col.ToolTip))
                                    {
                                        btn.SetValue(Button.ToolTipProperty, col.ToolTip);
                                    }
                                    btn.AddHandler(Button.MouseDoubleClickEvent, new MouseButtonEventHandler((sender1, exx1) =>
                                    {
                                        try
                                        {
                                            myClickWaitTimer.Stop();
                                            if (sender1 != null && sender1 is Button)
                                            {
                                                if ((sender1 as Button).DataContext != null && (sender1 as Button).DataContext is DataRowView)
                                                {
                                                    DataRowView row = ((sender1 as Button).DataContext as DataRowView);
                                                    if (row != null)
                                                    {
                                                        string Name = (sender1 as Button).Name.Replace("Key", "");
                                                        (Application.Current.Resources["AppViewModel"] as HomeController).DataGridButtonPressed(Name, row.Row, "DOUBLECLICK");
                                                    }
                                                }
                                            }
                                            exx1.Handled = true;
                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                    }));
                                    btn.AddHandler(Button.ClickEvent, new RoutedEventHandler((sender, exx) =>
                                    {
                                        if (sender != null && sender is Button)
                                        {
                                            btnPressed = sender as Button;
                                        }
                                        myClickWaitTimer.Start();
                                    }));

                                    // btn.AddHandler(Button.ClickEvent, null);
                                    string DebugFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).ToString().Substring(6);
                                    FrameworkElementFactory Img = new FrameworkElementFactory(typeof(Image));

                                    switch (col.Property.ToUpper())
                                    {
                                        case "UPDATE":
                                            {
                                                Img.SetValue(Image.SourceProperty, new BitmapImage(new Uri(DebugFolder + @"\Resources\0\Images\UpdateButton.png")));
                                                break;
                                            }
                                        case "DELETE":
                                            {
                                                Img.SetValue(Image.SourceProperty, new BitmapImage(new Uri(DebugFolder + @"\Resources\0\Images\DeleteButton.png")));
                                                break;
                                            }  
                                    } 
                                  
                                    Img.SetValue(Image.WidthProperty, col.IconWidth);
                                    Img.SetValue(Image.HeightProperty, col.IconHeight);
                                    btn.AppendChild(Img);

                                    ButtonColumnTemplate.VisualTree = btn;

                                    (dataGridColumn as DataGridTemplateColumn).CellTemplate = ButtonColumnTemplate;
                                    #endregion
                                    break;
                            }

                            if (dataGridColumn != null)
                            {
                                //Heading
                                dataGridColumn.Header = col.Heading;

                                //Width 
                                if (col.Width.ToLower() == "auto")
                                {
                                    try { dataGridColumn.Width = new DataGridLength(1, DataGridLengthUnitType.Auto); } catch (Exception ex) { }
                                }
                                else if (col.Width.ToLower() == "*")
                                {
                                    try { dataGridColumn.Width = new DataGridLength(1, DataGridLengthUnitType.Star); } catch (Exception ex) { }
                                }
                                else
                                {
                                    try { dataGridColumn.Width = new DataGridLength(double.Parse(col.Width)); } catch (Exception ex) { }
                                }


                                if (dataGridColumn.Width != 0)
                                    (_Source as System.Windows.Controls.DataGrid).Columns.Add(dataGridColumn);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private static void mouseWaitTimer_Tick(object sender, EventArgs e)
        {
            myClickWaitTimer.Stop();

            // Handle Single Click Actions
            try
            {
                if (btnPressed != null && btnPressed is Button)
                {
                    if ((btnPressed as Button).DataContext != null && (btnPressed as Button).DataContext is DataRowView)
                    {
                        DataRowView row = ((btnPressed as Button).DataContext as DataRowView);
                        if (row != null)
                        {
                            string Name = (btnPressed as Button).Name.Replace("Key", "");
                            (Application.Current.Resources["AppViewModel"] as HomeController).DataGridButtonPressed(Name, row.Row, "CLICK");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void SetBindableColumns(DependencyObject element, ObservableCollection<DataGridColumn> value)
        {
            element.SetValue(BindableColumnsProperty, value);
        }
    }
}
