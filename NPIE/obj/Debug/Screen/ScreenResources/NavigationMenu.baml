   M S B A M L   `   `   `  ����?  ;NPIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:NPIE.Screen.ScreenResourcesNPIE.Screen.ScreenResources  5      -clr-namespace:NPIE.ControlsNPIE.Controls  5      0    *NPIE.Screen.ScreenResources.NavigationMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:NPIE.Screen.ScreenResources     5      M	Controls19http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      .Controlsclr-namespace:NPIE.Controls    5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � 	Resources  5       �� 
TargetType   	MenuStyle �� Property �� Value �� 
TargetType �� Orientation  AppViewModel �� Source �� Path �� UpdateSourceTrigger	 �Name'  !MaterialDesignThemes.Wpf.PackIcon�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]
   Kind  ConvertBoolToVisibility �� 	Converter ��Name $  NullToVisibilityReverseConverter 9�Name 9� 
IsExpanded  ConvertNullToVisbility ��Name ��Name �� Padding �� Triggers P� Property P� Value �� 
TargetName��%h  &	        7  7  7  7  7  7  7  �� 5   
   " ��6   .�5      ��  �@��TextAlignment$ Center=�68   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 
Horizontal=�6%   ��6>   �� 8   $* $ApplicationDesign.MenuItemBackground�$ PropertyChanged=�.+�5      � $		 img��6#   .+�5   "     $��25��6V   $��25��6a   $��05 10q�6m   
�������
 6;   �� $
 Icon�6|   5      � 5      y�6#   �� 8  $ HomeScreen.IsMenuShown�$ PropertyChanged=�8  .+�5   "   �� $ ListViewItemMenu��6.   -   5        $��32 14q�5   �   $��15(�6�   
���������6H   �� $ Header�y�6i   �� $ SubItems�8  6�   9� 5   "   $ ExpanderMenu��6+   $
��Left=�6C    .  $	��180��6�   $��07(�6�   $
��Left=�6
  
������ 
���������6f   �� $ Header�y�6�   �� $ SubItems�8  .��5   &   �� $ ListViewMenu��6/   
�������$��Disabled=�6~   ��6E   �� $ SubItems���5   *   �� 5   .   .R�5   2   �� -   5        
������ 
������ $��25��5   l   ��5    6   �� 5!   :   $ tb��6_   $��14(�6l   $
 10 0q�6z   ��6D   �� $
 NAME�6z   5#   3   5$   /   5&   '   5'   #   5(      5)       5*      P� 5+       �@J�IsMouseOver . . �5,   "   �� $	 img��6�    6?   �� 8  $) #ApplicationDesign.MenuItemMouseOver�$ PropertyChanged=� � ��6�   5-      P� 5/       � �� . . �50   "   �� $	 img��6�    6?   �� 8  $1 +ApplicationDesign.MenuItemOnPressBackground�$ PropertyChanged=� � ��6�   51      54      56      57      58      .��5:      � .+�5;   
   �� -   5        #��[  5;      6L   5<      5=      