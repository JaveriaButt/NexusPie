   M S B A M L   `   `   `  ����?  ;NPIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NPIE.ControlsNPIE.Controls  5      -clr-namespace:NPIE.ControlsNPIE.Controls  5      -    'NPIE.Screen.ScreenResources.NP_SaleGrid   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:NPIE.Controls     5      0Contorlsclr-namespace:NPIE.Controls     5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5           Name$  dgGrid��5         AlternatingRowBackground
 � � � �� AlternationCount$ 2��6D   +   %NPIE.Controls.DataGridColumnsBehavior   BindableColumns 6�   ��    AppViewModel �� Source# [   �� Path$ CurrentScreen.ColumnsList� �� UpdateSourceTrigger$ PropertyChanged=���6X  �� # [  $ ListOfItems�$ PropertyChanged=� � 	Resources 5       �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� Padding ��Name �� BitmapScalingMode � ColumnDefinitions � RowDefinitionsG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name7  1System.Windows.Controls.DataGridHeadersVisibility   Column �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorType ��Name �� CanContentScroll ��Name �� Orientation �� ViewportHeight �� ViewportSize  �� ScrollableHeight! � Maximum*" �� #ComputedVerticalScrollBarVisibility# � Value$ �� Mode% �� ViewportWidth& �� ScrollableWidth,' �� %ComputedHorizontalScrollBarVisibility( �� Triggers) P� Property* P� Value+ �� 	Resources=  7System.Windows.Controls.Primitives.DataGridColumnHeader, �� TextAlignment*  $System.Windows.Controls.DataGridCell- ��Name. �� Triggers/ �� 
TargetName)  #System.Windows.Controls.DataGridRow?  9System.Windows.Controls.Primitives.DataGridCellsPresenter0  Name0	  *System.Windows.Controls.DataGridCellsPanel��%d  '        7   7   7   7   7   7   7   7   7   7   �� 5      "  6   .�5      �� 	 � ��

 ���� 63   �� 5      	 � ��

 ���� 64   �� 5      	 � ��$
 0q�68   �� 5      	 � ��

 �   �63   �� 5      	 �@ CanUserReorderColumns
 .  6>   �� 5      	 �@ CanUserResizeColumns
 .  6=   �� 5      	 �@ CanUserAddRows
 .  67   �� 5      	 �@ CanUserResizeRows
 .  6:   �� 5      	 �@ EnableRowVirtualization
 . 6@   �� 5      "	 �@ EnableColumnVirtualization
 . 6C   �� 5      	 �@%�VirtualizationMode$
 	Recycling=�6R   �� 5      	 �@%�IsVirtualizing
 . 6N   �� 5      	 � ��
 63   �� 8   $" ApplicationDesign.FontFamily�$ PropertyChanged=��� 5      	 �@ SelectionMode$
 Single=�66   �� 5      	 �@ AutoGenerateColumns
 .  6<   �� 5      	 �@ GridLinesVisibility$

 None=�6<   �� 5       	 �@ RowDetailsVisibilityMode$
 	Collapsed=�6A   �� 5       	 � ��
 . 6G   �� 5!      	 �@��PanningMode$

 Both=�6B   �� 5"      	 � ��$
 Visible=�6S   �� 5#      	 �@��IsFlicksEnabled
 .  6?   �� 5$      	 � ��
 5%      �� 5&      "  6.   .R�5'   "   �� $ border��6)    . 
������ 
������ $��0q�6�   $ 0q�6�   ._�5(   &   �� $ DG_ScrollViewer��63   |�.  
���   ���5)   *   �� 5*   .   " ��6>   .R�5+   2   � .+�5,   6   �� $ HighQuality=�6�   $
��Fill=�6�   ��6<   �� 8  $* $ApplicationDesign.DataGridBackground�$ PropertyChanged=�6�   � 5-   6    5.   :   �� 5/   >   $��* �6O   �� 50   >   $
��Auto �6O    52   :   �� 53   >   $
��Auto �6L   �� 54   >   $��* �6L   �� 55   >   $
��Auto �6L   .+�57   :     $! PART_ColumnHeadersPresenter��6�   $��2��6  ��6Y   �� 8  $" ApplicationDesign.FontFamily�$ PropertyChanged=�y�6  �� *HeadersVisibility+# Z # Z  �� "  �� 58   :   $! PART_ScrollContentPresenter��6R   $��2��6w   $��1��6�   # z��6�   � 59   :   ���#F0F0F0$��Right=�6T   $��1��6p   $��1��6}   .+�5:   >   �� $ PART_VerticalScrollBar��6I   $��Right=�6i   $��2��6�   $ Vertical=�6�   # z 6�   #! z  6�   #y�z" 6
  # 6M  �� *VerticalOffset+$$ OneWay=� �� *TemplatedParent+5;   ;   � 5<   :   $��2��6?    5=   >   �� 5>   B   ��6S   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5?   B   $��* �6S   .+�5A   >   �� $ PART_HorizontalScrollBar��6H   $��1��6j   $ 
Horizontal=�6z   # z% 6�   #! z& 6�   #y�z' 6�   # 63  �� *HorizontalOffset+$$ OneWay=� �� *TemplatedParent+5B   ;   5C   7   5D   3   5E   /   .��5G   *   �� # z 69   5H   '   5I   #   5J      5L      ( 5M      P� 5N      ) �@��
IsGrouping* . . �5O      �� 	 � ��
 .  6N   5P      + 5R      ���� 5S      '        "  6    .�5T      �� 	 � ��
 5U   "   �� 5V   &   "  66   5\   '   5^      5_      �� 5a      '        "  6    .�5b      �� 	 � ��$
 Center=�6I   �� 5c      	 � ��
 5d   "   �� 5e   &   "  66   .R�5f   *   � .+�5g   .   �� #��z��6I  $��Center=�6j  $, Center=�6   . $��Center=�6F  ��68   �� 8  $" ApplicationDesign.FontFamily�$ PropertyChanged=���6�   �� 8  $/ )ApplicationDesign.DataGridHeaderTextColor�$ PropertyChanged=���6�  �� 8  $. (ApplicationDesign.DataGridHeaderTextSize�$ PropertyChanged=�6F  5h   +   5i   '   5k      5l      �� 5p      '        "  6    .�5q      �� 	 � ��

 ���� 6;   �� 5r      	 � ��

 ���� 6<   �� 5s      	 � ��$
 0q�6@   �� 5t      	 � ��$
 Stretch=�6B   �� 5u      	 � ��$
 Stretch=�6D   �� 5v      	 � ��
 5w   "   �� 5x   &   "  66   .R�5y   *   �� $ border��61   
������ $��2q�6\   
������  . ._�5z   .   �� $
- con2��6?   $��Center=�6M   # z 6i   
���   �$��Center=�6�   5{   +   . 5|   *   P� 5}   .   ) �@ 
IsSelected* . . �5~   2   �� $
/ con2��69   	 � ��

 �   �6k   �� 5   2   
 6O   Z� 	 � ���� 5�   2   
 6P   Z� 	 � ��5�   /   5�   '   5�      ( 5�      P� 5�   "   ) �@ 
IsSelected* . . �5�   &   �� 	 � ��
 6C   �� *	ColorCode+$ PropertyChanged=�5�   #   5�      �� 5�      '        "  6    .�5�      �� 	 � ��

 ���� 6;   �� 5�      	 �@J�SnapsToDevicePixels
 . 6E   �� 5�      	 � ��
 5�   "   �� 5�   &   "  66   .R�5�   *   �� $ grditem��61   $��1q�6B   ��6V   �� 8  $) #ApplicationDesign.DataGridRowHeight�$ PropertyChanged=�._�5�   -   �� $ 
DGR_Border��64   
������ $��1q�6�    . ��6H   �� 8  $) #ApplicationDesign.DataGridRowHeight�$ PropertyChanged=�._�5�   2     $0 cont1��6\   
�������$��Center=�6k   $
��Left=�6�   $��Stretch=�6�   $��1��6�   # z 6�   ��6  �� *	ColorCode+$ PropertyChanged=���6\  �� 8  $+ %ApplicationDesign.DataGridRowTextSize�$ PropertyChanged=���5�   6   �� 5�   :   .R�5�   >   	  5�   ;   5�   3   5�   /   5�   +   . 5�   *   P� 5�   .   ) �@ 
IsSelected* . . �5�   7   �� $/ 
DGR_Border��6>   
 6l   �� 8 	 $4 .ApplicationDesign.DataGridSelectedRowBackColor�$ PropertyChanged=�	 � ��5�   /   5�   '   5�      5�      5�      5�      5�      5�      5�      5�      