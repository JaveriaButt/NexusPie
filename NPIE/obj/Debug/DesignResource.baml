   M S B A M L   `   `   `  ����?  ;NPIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NPIE.ConvertorsNPIE.Convertors  5      -clr-namespace:NPIE.ControlsNPIE.Controls  5      E AController, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE1clr-namespace:NPIE.Controller;assembly=ControllerNPIE.Controller 5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=null  �� MergedDictionaries �� Source$   NPIE.Controller.HomeController   AppViewModel)   #NPIE.Convertors.VisibilityConverter  ConvertBoolToVisibility1   +NPIE.Convertors.StringToVisibilityConverter  ConvertStringToVisbility/   )NPIE.Convertors.NullToVisibilityConverter  ConvertNullToVisbility6   0NPIE.Convertors.NullToVisibilityReverseConverter $  NullToVisibilityReverseConverter%   NPIE.Convertors.ScreenConvertor  ConvertScreenTypeToControl   NPIE.Controls.NPButtons �� 
TargetType  ProductButton �� Property �� Value �� Source �� Path �� UpdateSourceTrigger �� 
TargetType	 ��Name
 �� CornerRadius � RowDefinitions �� RelativeSource � ColumnDefinitions �� StringFormat �� Triggers P� Property P� Value �� 
TargetName K� ZIndex �� ElementName �� Padding  ImageButton J� Opacity �� Padding  ImageButton1 �� BasedOn 	 RoundedButton ��Name 
 
OvalButton �� LineStackingStrategy �� 
LineHeight�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,
Convertersclr-namespace:NPIE.Convertors  5      'Controlclr-namespace:NPIE.Controls  5      6mah,http://metro.mahapps.com/winfx/xaml/controls  5      AControllers1clr-namespace:NPIE.Controller;assembly=Controller  5        5	      �� 5
      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6!   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6!   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Blue.xaml?�6!   �� 5      $x rpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.LightBlue.xaml?�6!   %p  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     7   7   7   7   7   7   7   7   7   7   7   7   7   7   '�� S    &	 &    &	 �    7 �&		 �    &	
 I    7   7   7   7   7   7   7      5      6!     5      6%     5      6-     5      6+     5      62     5      6!   �� 5      "  6   .�5   
   ��  � �� 6'   �� 8   $" ApplicationDesign.FontFamily�$ PropertyChanged=��� 5   
    � �� 6%   �� 8  $* $ApplicationDesign.ProductButtonWidth�$ PropertyChanged=��� 5   
    � �� 6&   �� 8  $+ %ApplicationDesign.ProductButtonHeight�$ PropertyChanged=��� 5   
    � �� 6'   �� 8  $) #ApplicationDesign.Productbackground�$ PropertyChanged=��� 5   
    �@�Cursor$
 Hand��6#   �� 5    
    � ��$ 12(�6%   �� 5!   
    � �� 5"      �� 5#      "  6"   .R�5$      �� $	 bd��6   $
 15��6G  #��z��6Z  #��z��6}  #��z��6�  ��6)   �� 8  $. (ApplicationDesign.ProductBorderThickness�$ PropertyChanged=���6�   �� 8  $* $ApplicationDesign.ProductBorderColor�$ PropertyChanged=�._�5%      � $��08,02q�6    5&      �� 5'   "   $
��Auto �60   �� 5(   "   $��* �60   .+�5*      �� $	��Top=�6~   $
��Wrap=�6�   $
��Left=�6�  $��SemiBold"�6�  $��0��6�  #��z��6  ��6*   �� $ ContentS� �� *TemplatedParent+��6�   �� 8  $+ %ApplicationDesign.ProductNameFontSize�$ PropertyChanged=���68  �� 8  $- 'ApplicationDesign.ProductNameForeground�$ PropertyChanged=�6  � 5+      $��1��6#    5,   "   �� 5-   &   $��* �67   �� 5.   &   $��2* �67   .+�50   "   �� $	��Top=�6   $
��Left=�6�   $��0��6�  #��z��6�  ��6.   �� $ ItemCode� �� *TemplatedParent+��6�   �� 8  $+ %ApplicationDesign.ProductCodeFontSize�$ PropertyChanged=���6<  �� 8 	 $- 'ApplicationDesign.ProductCodeForeground�$ PropertyChanged=�6�  �� 51   "   $��SemiBold"�6�   $��Bottom=�6�   $
��Left=�6�   $��0��6   #��z��6  ��6.   �� $ Price�$ {0}  SAR�� �� *TemplatedParent+��6�   �� 8 
 $, &ApplicationDesign.ProductPriceFontSize�$ PropertyChanged=���6q  �� 8  $. (ApplicationDesign.ProductPriceForeground�$ PropertyChanged=�6  �� 52   "   $��btnBackImg1��6�   $��2q�6|   $��1��6�   $��Bottom=�6�   $��Right=�6�   ��6-   �� $
 Icon� �� *TemplatedParent+6�   53      54      55       56      P� 57       �@J�IsMouseOver . . �58      ��  � ��
 �����6<   �� 59       � ��$ 2q�6@   �� 5:       6<   �� 8  $2 ,ApplicationDesign.ProductMouseOverbackground�$ PropertyChanged=� � ��5;      P� 5<       � �� . . �5=      �� $ bd��6&    6M   �� 8  $0 *ApplicationDesign.ProductOnPressbackground�$ PropertyChanged=� � ��5>      P� 5?       � {� .  . �5@      ��  �@J�Opacity$
 0.25Q�68   �� 5A       � ��
 ���� 6<   5B      5D      5F      5H      �� 5J      " ��6   .�5K      ��  � ��
 ���� 6%   �� 5L       � �� 5M   
   �� 5N      " ��6   .R�5P      �� $ 2��6   
���  ��$��2q�5R   !   $
 3��5S   !   $��Stretch=�5T   !   $	��300��5U   !   $��-2,20,-3,-1q�5V   !   $��45��5W   !   ��5X   !   �� $ HubGroupBox��$ 
Background�._�5Y      �� ���#016fc4$ 20q�65   $��SemiBold"�5Z   (   $��Center=�5[   (   5\      5_      5a      5b      �� 5d      " ��6   .�5e   
   ��  �@�Cursor$
 Hand��6#   �� 5f   
    � �� 5g      �� 5h      " ��6"   .R�5i      � .+�5j      �� 
�������$
 0.01Q�64   �� 5k      $	 border��6!   #��z��61   # z��6e   #��z��6�   $
 5��6�   #��z��6�   ._�5l   $   �� $��Center=�65   $��Center=�6R   5m      5n       5o      P� 5p       �@J�IsMouseOver . . �5q      ��  � ��
 ��� �6<   �� 5r       � ��$ 2q�6@   5s      P� 5t       � {� .  . �5u      ��  �@J�Opacity$
 0.25Q�68   �� 5v       � ��
 ���� 6<   5w      5y      5{      5|      �� 5~      " ��6   8   .�5   
   ��  �@�Cursor$
 Hand��6#   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $	 border��6   $ 0q�6.   
���  ��._�5�      �� $��Stretch=�6+   $��Stretch=�6I   5�       5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � ��
 ���� 6<   5�      P� 5�       � {� .  . �5�      ��  �@J�Opacity$
 0.25Q�68   �� 5�       � ��
 ���� 6<   5�      5�      5�      5�      �� 5�      "  6   .�5�   
   ��  �@�Cursor$
 Hand��6#   �� 5�   
    � �� �#F6CCCE6'   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $
 3,3,3,3��6   $��1,1,1,1q�65   ���	#FF0E94AC#��z��6g   ._�5�      �� $ contentPresenter��6,   #��z��6F   #��z��6z   #��z��6�   #��z��6�   #��z��6  5�       5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � ��
 ���� 6<   �� 5�       � ��
 �  ��6;   5�      P� 5�       � {� .  . �5�      ��  �@J�Opacity$
 0.25Q�68   �� 5�       � ��
 ���� 6<   5�      5�      5�      5�      �� 5�      "  6   .�5�   	   ��  �@�Cursor$
 Hand��6"   �� 5�   
    � �� 6'   �� 8   $, &ApplicationDesign.OvalButtonForeground�$ PropertyChanged=��� 5�       � �� 6'   �� 8  $* $ApplicationDesign.OvalButtonFontSize�$ PropertyChanged=��� 5�       � �� 5�      �� 5�      "  6"   .R�5�      �� $
	 brdr��6   $
 12��6,   ��6?   �� 8  $( "ApplicationDesign.OvalButtonHeight�$ PropertyChanged=���6�   �� 8  $' !ApplicationDesign.OvalButtonWidth�$ PropertyChanged=���6G  �� 8  $, &ApplicationDesign.OvalButtonBackground�$ PropertyChanged=�._�5�      �� $��SemiBold"�6&   $ BlockLineHeight=�6�   $ 15��6�   $��Center=�6�   $
��Wrap=�6�   $��Center=�6�   ��6<   �� $ ContentS� �� *TemplatedParent+6�   5�       5�      P� 5�       �@J�IsMouseOver . . �5�      ��  � ��
 ��� �6<   �� 5�       � ��$ 2q�6@   �� 5�      $
 brdr��6%    6M   �� 8  $5 /ApplicationDesign.OvalButtonMouseOverbackground�$ PropertyChanged=� � ��5�      P� 5�       � �� . . �5�      ��  6;   �� 8  $) #ApplicationDesign.OvalButtonOnPress�$ PropertyChanged=� � ��5�      P� 5�       � {� . . �5�      ��  � ��
 ���� 6<   5�      5�      5�      5�      5�      