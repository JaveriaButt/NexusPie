   M S B A M L   `   `   `  ����?  ;NPIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NPIENPIE  5   	   -clr-namespace:NPIE.ControlsNPIE.Controls  6*   )clr-namespace:NPIE.ScreenNPIE.Screen  6V       NPIE.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   localclr-namespace:NPIE  5   	   )Controlclr-namespace:NPIE.Controls  6*   &screenclr-namespace:NPIE.Screen  6V     � WindowStyle$
  None=�5      
������ 
������ $��0q�6`    � AllowsTransparency .  � Title$
 NPIE��5	   	   $	��750��6   $
��1080��6#   .��5      �� $��10q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      	Direction$ 0Q�6/      RenderingBias$ Performance=�6=      ShadowDepth$ 1Q�6Y   ._�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��* �6    .+�5      � -   5        	 �Name$	 Header��5   &   $��0��6   .+�5      �� 
 �� BitmapScalingMode$
 HighQuality=�6�   $
��Fill=�6�   ��6   ��    AppViewModel �� Source# [   �� Path$# ApplicationDesign.HeaderImage� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��	NEXUS PIE��6�   $
��Bold"�6�   $��Center=�6M  $
��Left=�6h  $��15(�6�  $��20,0,0,0q�6�  ��6    �� # [  $" ApplicationDesign.FontFamily�$ PropertyChanged=���6�   �� # [  $' !ApplicationDesign.HeaderTextColor�$ PropertyChanged=�6�  �� 5      $��200,0q�6    $��15(�6/   
���� ��$��Center=�6Y   $��Center=�6t   ��6�   �� # [  $" ApplicationDesign.FontFamily�$ PropertyChanged=�	LoginUesr6  5      �� 5      $	��300��6   $��30��6,   $��35��6;   $��Center=�6J   $��Center=�6e   $��Center=�6�   $��20(�6�   6�   �� 5       $ 
Horizontal=�6   $��Right=�66   $��Center=�6S   .+�5!      �� -   5         ��Name$ 
btnMinmize��5!   f  $��30��6   $��30��6�    � ToolTip$ Minimize��6�    � Cursor$
 Hand��6  
������ 
������ $��0q�6F  $��05q�6Z    ImageButton#��[ 6�  y�6(   �� # [  $* $ApplicationDesign.ShowMinimizeButton�$ PropertyChanged=�  ConvertBoolToVisibility �� 	Converter# [ ��6z  �� # [  $  MinimizeApplicationCommand�.��5"      �� $
 HighQuality=�6�   ��6    �� # [  $) #ApplicationDesign.BtnMinimizeAppImg�$ PropertyChanged=�6�   5#      �� 5$      -   5        $ btnMaximize��5$   f  $��30��6   $��30��6�   $ Maximize��6�   $
 Hand��6  
������ 
������ $��0q�6F  $��05q�6Z  #��[ 6�  y�6(   �� # [  $* $ApplicationDesign.ShowMaximizeButton�$ PropertyChanged=�# [ ��6{  �� # [  $  MaximizeApplicationCommand�.��5%      �� $
 HighQuality=�6�   ��6    �� # [  $) #ApplicationDesign.BtnMaximizeAppImg�$ PropertyChanged=�6�   5&      �� 5'      -   5        $ btnClose��5'   �   $��30��6   $��30��6(   $ Close��64   $
 Hand��6E   
������ 
������ $��0q�6�   $��Center=�6�   $��0,0,10,0q�6�   #��[ 6�   ��5(      (� 5)       (� Stretch$ Uniform=�6&   .��5*   "   �� $
 HighQuality=�6�   ��6(   �� # [  $&  ApplicationDesign.BtnCloseAppImg�$ PropertyChanged=�6�   5,      5.      5/      50      � 51      ���#E2F3F6$��1��6(    � ColumnDefinitions 53      �� 54      $
��Auto �6'   �� 55      $��* �6'   .+�58      � $��0��6   $��0,0,-0.4,-0.2q�6'   ��6>   �� # [  $) #ApplicationDesign.MenuBarBackground�.+�59      �� $ Vertical=�6!   .+�5:         NPIE.Controls.NPImage     NPIE.Controls.NPImage   MouseLeftButtonDown$! NPImage_MouseLeftButtonDown��6*   $��Right=�6\   $��10,05q�6x   $
 Linear=�6  $��30��6:  $��20��6F  ��6�   �� # [  $. (ApplicationDesign.MenuBarNavigationImage�$ PropertyChanged=�6S  �� 5;      $��Stretch=�6#   $��Disabled=�6A   $
��Auto=�6j   $��1��6�   .��5<      �� -   5         ��Name$
 Menu��5<   %   $��05q�63   5=      5>      5?      � 5A      $��1��6   $��0,0,-0.4,-0.2q�6'   .+�5C      �� $��Stretch=�6�   $��Stretch=�6�   ��6%   �� # [  $! CurrentScreen.ScreenControl�$ PropertyChanged=�  ConvertScreenTypeToControl# [ 6�   5D      5E      5F      5G   	   5I      