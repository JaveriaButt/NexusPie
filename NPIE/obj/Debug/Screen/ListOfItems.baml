   M S B A M L   `   `   `  ����?  ;NPIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:NPIE.ControlsNPIE.Controls  5          NPIE.Screen.ListOfItems   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /Controlclr-namespace:NPIE.Controls     5      .��5	      � .+�5
   
   �� -   5          ��Name$  	ItemsList��5
   }   $��Stretch=�6   |�.  ��.  
������ $��-1��6o   $��Disabled=�6�   ��6�   ��    AppViewModel �� Source# [   �� Path$ SaleAbleItems� �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      &    NPIE.Controls.AlignableWrapPanel  !   HorizontalContentAlignment$ Center=�62   $	��Top=�6X   5      ��5      �� 5      .R�5      � .+�5         NPIE.Controls.NPButtons    Name$ 	NP_Button��6L      NPIE.Controls.NPButtons   Click NP_Button_Click6   |�.  $��-1��6>     ProductButton#��[ 6`      ContentS 6�   �� *ProductName+   Price 6�   �� *	SalePrice+	   Icon	 6�   �� *	ImagePath+
   ItemCode
 6�   �� *ProductCode+6   5      5      ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ���� 63   �� 5       � �� 5      �� 5       �� 
TargetType" ��6.   .R�5   "   ��  ��Name$ Bd��6)   
��� � �$��0q�6I    �� Padding$ 04q�6^    J� SnapsToDevicePixels . ._�5    &   �� #��z��67   # z 6z   #��z��6�   5!   #    �� Triggers 5"   "   P� 5#   &    P� Property �@��
IsSelected P� Value . . �5$   *   ��  � ��
 � ���6G   �� 5%   *   # � ��6G    � ��5&   '   ]� 5'   &    ]� 
Conditions 5(   *   �� 5)   .    �� Property �@��
IsSelected �� Value . 6N   �� 5*   .    �@��IsSelectionActive .  6^   ./�5,   *   ��  � ��
 �  ��6G   �� 5-   *   # � .�6G    � ��5.   '   P� 5/   &    � {� .  . �50   *   �� # � ��6G    � ��51   '   P� 52   &    �@J�IsMouseOver . . �53   *   ��  � ��
 ���� 6G   54   '   P� 55   &    �@��
IsSelected . . �56   *   ��  � ��
 �  ��6I   57   '   59      5;      5<      5?      5A      5B      