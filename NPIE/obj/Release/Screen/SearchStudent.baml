   M S B A M L   `   `   `  ����   	SESDesign$    SESDesign.Screen.SearchStudent   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� 
�������.+��� $��Stretch=�$��Stretch=�
�������$��3q�._��   � RowDefinitions  �� $��60 ��� $��* �.+�� $��0�����#99B4D1$��0,0,0,20q�.+��� $��Search Student Record��
�������$��Center=�$��Center=�$��Cairo)�$��30(�&   System.Windows.Controls.DataGrid  -   $��StdData��$��123,97,141,78q�$��1��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   CanUserSort .     Header$
 Name��   HeaderStringFormat$
 Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding Z�    ClipboardContentBinding Z�    .  $ Father Name��$ FName��$	 100  .  Z�  Z�    .  $ Roll No��$ Roll No��$	 100  .  Z�  Z�    .  $ 
Department��$ 
Department��$	 100  .  Z�  Z�    .  $
 CNIC��$
 CNIC��$	 100  .  Z�  Z�    .  $ Session��$ Session��$	 100  .  Z�  Z� 5  /System.Windows.Controls.DataGridHyperlinkColumn   .  $ 	Edit Info��$
 Edit��$	 100  .  Z�  Z� 