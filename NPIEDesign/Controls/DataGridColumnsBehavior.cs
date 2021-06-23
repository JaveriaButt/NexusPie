using Models;
using NPIE.Controller;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace NPIE.Controls
{
    public class DataGridColumnsBehavior
    {
        public static readonly DependencyProperty BindableColumnsProperty = DependencyProperty.RegisterAttached("BindableColumns", typeof(ObservableCollection<GridColumn>), typeof(DataGridColumnsBehavior), new UIPropertyMetadata(null, BindableColumnsPropertyChanged));
        private static  void BindableColumnsPropertyChanged(DependencyObject _Source, DependencyPropertyChangedEventArgs e)
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
                            switch (col.ColumnType)
                            {
                                case ColumnTypes.Text:
                                    {
                                        dataGridColumn = CreateTextColumn(col);
                                        break;
                                    }
                                case ColumnTypes.Button:
                                    dataGridColumn = CreateButtonColumn(col);
                                    break;

                                //case ColumnTypes.DeleteButton:
                                //    dataGridColumn = CreateDeleteButtonColumn(col);
                                //    break;
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

                if (_Source is DataGrid)
                {

                }

            }
            catch (Exception ex)
            {

            }
        }


        private static DataGridTextColumn CreateTextColumn(GridColumn col)
        {
            DataGridTextColumn dataGridColumn = null;
            try
            {
                var converter = new System.Windows.Media.BrushConverter();
                Style ColStyle = (new Style(typeof(DataGridCell)));
                dataGridColumn = new DataGridTextColumn();
                dataGridColumn.IsReadOnly = true;
                if (!string.IsNullOrWhiteSpace(col.Property))
                    (dataGridColumn as DataGridTextColumn).Binding = new Binding(col.Property) { Mode = BindingMode.TwoWay };


                //Style 

                dataGridColumn.ElementStyle = new System.Windows.Style(typeof(TextBlock));

              
                dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.BackgroundProperty, Value = Brushes.Transparent });
                dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderBrushProperty, Value = Brushes.Transparent });
                dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderThicknessProperty, Value = new Thickness(0) });
                dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.FontSizeProperty, Value = Convert.ToDouble((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridRowTextSize) });
                dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.VerticalAlignmentProperty, Value = VerticalAlignment.Center });
                dataGridColumn.ElementStyle.Setters.Add(new Setter(TextBlock.TextWrappingProperty, TextWrapping.Wrap));

                //Trigger trigger = new Trigger(){ Property = DataGridCell.IsSelectedProperty, Value = true };
                //trigger.Setters.Add(new Setter() { Property = DataGridCell.ForegroundProperty, Value = Brushes.Black });
                //trigger.Setters.Add(new Setter() { Property = DataGridCell.BackgroundProperty, Value = Brushes.Transparent });
                //trigger.Setters.Add(new Setter() { Property = DataGridCell.BorderBrushProperty, Value = Brushes.Transparent });
                //trigger.Setters.Add(new Setter() { Property = DataGridCell.BorderThicknessProperty, Value = new Thickness(0) });

                var backgroundcolor = new SolidColorBrush((Color)ColorConverter.ConvertFromString((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridHeaderBackground));

                dataGridColumn.HeaderStyle = (new Style(typeof(DataGridColumnHeader)));
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.VerticalContentAlignmentProperty, Value = VerticalAlignment.Center });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.BackgroundProperty, Value = backgroundcolor });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.BorderBrushProperty, Value = Brushes.Transparent });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.BorderThicknessProperty, Value = new Thickness(0) });

                
                var foregroud = (Brush)converter.ConvertFromString((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridHeaderTextColor); 
                var FontFamily = new FontFamily((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.AppFontFamily);


                dataGridColumn.HeaderStyle.Setters.Add(new Setter() {Property= DataGridColumnHeader.ForegroundProperty, Value= foregroud });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.FontSizeProperty, Value = Convert.ToDouble((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridHeaderTextSize) });

             //   dataGridColumn.ElementStyle.Triggers.Add(trigger);
                if (col.HorizontalAllignment == 1)
                {
                    dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.HorizontalAlignmentProperty, Value = HorizontalAlignment.Left });
                    dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.FontFamilyProperty, Value = FontFamily });
                    dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.HorizontalContentAlignmentProperty, Value = HorizontalAlignment.Left });
                    dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.FontFamilyProperty, Value = FontFamily });

                }
                else if (col.HorizontalAllignment == 2)
                {
                    dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.HorizontalAlignmentProperty, Value = HorizontalAlignment.Center });
                    dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.HorizontalContentAlignmentProperty, Value = HorizontalAlignment.Center });
                }
                
                dataGridColumn.ElementStyle.Setters.Add(new Setter() { Property = DataGridCell.FontWeightProperty, Value = FontWeights.Bold });

                dataGridColumn.CellStyle = ColStyle;
            }
            catch (Exception ex)
            {

            }
            return dataGridColumn;
        }
        private static DataGridColumn CreateButtonColumn(GridColumn col)
        {
            DataGridColumn dataGridColumn = null;
            try
            {
                Style ColStyle = (new Style(typeof(DataGridCell)));
                dataGridColumn = new DataGridTextColumn();
                dataGridColumn.IsReadOnly = true;
                if (!string.IsNullOrWhiteSpace(col.Property))
                    (dataGridColumn as DataGridTextColumn).Binding = new Binding(col.Property) { Mode = BindingMode.OneWay }; 

                dataGridColumn = new DataGridTemplateColumn();
                dataGridColumn.IsReadOnly = false;

                 
                //Template
                DataTemplate ButtonColumnTemplate = new DataTemplate();
                FrameworkElementFactory btn = new FrameworkElementFactory(typeof(Button));
                //btn.SetValue(Button.ContentProperty, col.Property);
                btn.SetValue(Button.BackgroundProperty, Brushes.Transparent);
                btn.SetValue(Button.BorderBrushProperty, Brushes.Transparent);
                btn.SetValue(Button.BorderThicknessProperty, new Thickness(0));
                btn.SetValue(Button.MarginProperty, new Thickness(0, 2, 10, 2));
                btn.SetValue(Button.StyleProperty, Application.Current.Resources["ImageButton"]);


                FrameworkElementFactory _Grid = new FrameworkElementFactory(typeof(Grid));
                Binding dataBinding = new Binding(col.Property) { Mode = BindingMode.OneWay };
 

                btn.AddHandler(Button.ClickEvent, new RoutedEventHandler((SENDER1, exx) =>
                {
                    try
                    {
                        if (SENDER1 != null && SENDER1 is Button)
                        {
                            if ((SENDER1 as Button).DataContext != null)
                            {
                                   ClickResponse response = new ClickResponse() {SENDER = col.Property, DataObject = (SENDER1 as Button).DataContext };
                                  (Application.Current.Resources["AppViewModel"] as HomeController).CurrentScreen.SendClick(response);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }));



                FrameworkElementFactory Img = new FrameworkElementFactory(typeof(EMSImage));

                if (col.Property.ToUpper() == "UPDATE")
                    Img.SetBinding(EMSImage.ImageContentProperty, new Binding() { Source = ((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.UpdateButtonImage), UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged });
                else if (col.Property.ToUpper() == "DELETE")
                    Img.SetBinding(EMSImage.ImageContentProperty, new Binding() { Source = ((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DeleteButtonImage), UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged });

                btn.AppendChild(Img);
                ButtonColumnTemplate.VisualTree = btn;

                (dataGridColumn as DataGridTemplateColumn).CellTemplate = ButtonColumnTemplate;
                 
                //Style 
                ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BackgroundProperty, Value = Brushes.Transparent });
                ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderBrushProperty, Value = Brushes.Transparent });
                ColStyle.Setters.Add(new Setter() { Property = DataGridCell.BorderThicknessProperty, Value = new Thickness(0) });
                ColStyle.Setters.Add(new Setter() { Property = DataGridCell.VerticalAlignmentProperty, Value = VerticalAlignment.Center });
                Trigger trigger = new Trigger() { Property = DataGridCell.IsSelectedProperty, Value = true };
                trigger.Setters.Add(new Setter() { Property = DataGridCell.ForegroundProperty, Value = Brushes.Black });

                var backgroundcolor = new SolidColorBrush((Color)ColorConverter.ConvertFromString((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridHeaderBackground));

                dataGridColumn.HeaderStyle = (new Style(typeof(DataGridColumnHeader)));
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.VerticalContentAlignmentProperty, Value = VerticalAlignment.Center });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.BackgroundProperty, Value = backgroundcolor });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.BorderBrushProperty, Value = Brushes.Transparent });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.BorderThicknessProperty, Value = new Thickness(0) });

                var converter = new System.Windows.Media.BrushConverter();
                var foregroud = (Brush)converter.ConvertFromString((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridHeaderTextColor);


                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.ForegroundProperty, Value = foregroud });
                dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.FontSizeProperty, Value = Convert.ToDouble((Application.Current.Resources["AppViewModel"] as HomeController).ApplicationDesign.DataGridHeaderTextSize) });

                ColStyle.Triggers.Add(trigger);
                if (col.HorizontalAllignment == 1)
                {
                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.HorizontalAlignmentProperty, Value = HorizontalAlignment.Left });
                    dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.HorizontalContentAlignmentProperty, Value = HorizontalAlignment.Left });
                }
                else if (col.HorizontalAllignment == 2)
                {
                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.HorizontalAlignmentProperty, Value = HorizontalAlignment.Center });
                    dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.HorizontalContentAlignmentProperty, Value = HorizontalAlignment.Center });
                }
                else if (col.HorizontalAllignment == 3)
                {
                    ColStyle.Setters.Add(new Setter() { Property = DataGridCell.HorizontalAlignmentProperty, Value = HorizontalAlignment.Right });
                    dataGridColumn.HeaderStyle.Setters.Add(new Setter() { Property = DataGridColumnHeader.HorizontalContentAlignmentProperty, Value = HorizontalAlignment.Right });
                }
                ColStyle.Setters.Add(new Setter() { Property = DataGridCell.FontWeightProperty, Value = FontWeights.Bold });

                dataGridColumn.CellStyle = ColStyle;
            }
            catch (Exception ex)
            {

            }
            return dataGridColumn;
        }
         
        public static void SetBindableColumns(DependencyObject element, ObservableCollection<DataGridColumn> value)
        {
            element.SetValue(BindableColumnsProperty, value);
        }
    }
   
}
