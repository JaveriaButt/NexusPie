   M S B A M L   `   `   `  ����?  ;NPIE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NPIE.ScreenNPIE.Screen  5      -clr-namespace:NPIE.ControlsNPIE.Controls  5      I)clr-namespace:NPIE.Screen.ScreenResourcesNPIE.Screen.ScreenResources  5          NPIE.Screen.SaleScreen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:NPIE.Screen     5      /Controlclr-namespace:NPIE.Controls     5      Escreenresourcen)clr-namespace:NPIE.Screen.ScreenResources     5      -   5        .��5      �   � ColumnDefinitions  5   
   �� 5      $
��1.8* �6   �� 5      $��2* �6   .+�5   
   � $��1��6   ��6   ��    AppViewModel �� Source# [   �� Path$, &ApplicationDesign.SaleScreenbackground� �� UpdateSourceTrigger$ PropertyChanged=� � RowDefinitions 5      �� 5      $��70 �6    �� 5      $��* �6    �� 5      $��50 �6    .+�5      � $��0��6     5      �� 5      $��50 �6'   �� 5      $��* �6'   �� 5      $��50 �6'   �� 5      $	��300 �6'   .+�5         NPIE.Controls.NPButtons  -   5          Name$ Btn_Next��5   /   $��50��6$   
������   ImageButton#��[ 6[   $��Center=�6�   
������ $��0��6�   .��5       �� ��6   �� # [  $' !ApplicationDesign.BackButtonImage�$ PropertyChanged=�6�   5!      �� 5$      -   5         ��Name$ 	ItemsList��5$   �   $��1��6   $
��Left=�6+   $��Center=�6F   
���  ��|�.  ��.  
������ $��-1��6�   $��Disabled=�6�   $��Disabled=�6	  ��6>  �� # [  $% ReferncValueS.ProductCategories�$ PropertyChanged=���5%      �� 5&      .R�5'      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6C   5(      ��5*      �� 5+      .R�5,      � .+�5-   "        NPIE.Controls.NPButtons   Click NPButtons_Click6Y     
OvalButton#��[ 64   	   ContentS	 6q   �� *Name+��6�   �� # [  $" ApplicationDesign.FontFamily�$ PropertyChanged=�5.      5/      ��51      �� 52      
 �� 
TargetType"
 ��6    .�53      ��  �� Property � �� �� Value
 ���� 6;   �� 54       � �� 55   "   �� 56   &    �� 
TargetType" ��66   .R�57   *   ��  ��Name$ Bd��61   $��0q�6>    �� Padding$ 04q�6S    J� SnapsToDevicePixels . ._�58   .   �� #��z��6?   # z 6�   #��z��6�   59   +    �� Triggers 5:   *   P� 5;   .    P� Property �@��
IsSelected P� Value . . �5<   2   ��  � ��
 �  ��6O   �� 5=   2    � ��$ 10q�6L   �� 5>   2   Bd�� � ��
 �����6\   5?   /   ]� 5@   .   ./�5E   2   �� # � /�6O    � ���� 5F   2   # � .�6O    � ��5G   /   P� 5H   .    � {� .  . �5I   2   �� # � ��6O    � ��5J   /   P� 5K   .    �@J�IsMouseOver . . �5L   2   ��  � ��
 ���� 6O   5M   1   P� 5N   .    �@��
IsSelected . . �5O   2   ��  � ��
 �  ��6P   5P   /   5R   '   5T      5U      5W        5Y      -   5        $ Btn_Back��5Y   0   $��50��6$   
������ $��Center=�6[   #��[ 6x   
������ $��2��6�   .��5Z      �� ��6   �� # [  $' !ApplicationDesign.NextButtonImage�$ PropertyChanged=�6�   5[        NPIE.Controls.NPLabel  5]      $��3��6#   $	��270��63   $��35��6?   $��0q�6L   $��Center=�6`   $��10(�6  
�������
������ 
������ $��Center=�6Y  ��6�   �� # [  $" ApplicationDesign.FontFamily�$ PropertyChanged=�6x  �� 5^      $��3��6   $��5q�6+   $��Bottom=�6?   $
��0,10q�6Z   
�������$	��270��6|   $��4��6�   6�   �� 5_      $��3��6   $��30��6+   $��Right=�67   $��05,02,15,15q�6S    �� BitmapScalingMode$ HighQuality=�6�   ��6h   �� # [  $# ApplicationDesign.SearchImage�$ PropertyChanged=�6  5`         NPIE.Screen.ListOfItems  5e      -   5          Name$ NpBtn_SaleItemsList��5e   .   $��1��6!   
�������$
��1920��6b   $��Stretch=�6s   � 5g      $��2��6   
������5h      5i      �� 5l   
   $��0��6   
�������$ Vertical=�6?   .+�5m      �   5n      �� 5o      $��* �6'   �� 5p      $��* �6'   .+�5r        $��0��6$   $��Center=�64   
�������$��Current Order��6i   $��70��6�   6�     5s      -   5        $ 	btn_Clear��5s   M   $ btn_Clear_Click��6�   $��1��6$   $��80��65   $��35��6A   $��Center=�6b     RoundedButton#��[ 6   $��	Clear All��6�   6�   5u      -   'NPIE.Screen.ScreenResources.NP_SaleGrid  5v      -   5          Name$ dg_SaleItems��5v   +   
���  ��$��
0,0,0,-0.4q�6U   5w      5z      5{      