   M S B A M L   `   `   `  ���� H  DProject_CE216, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Project_CE216Project_CE216       Project_CE216.SummaryDaily   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:Project_CE216       � Title$  SummaryDaily��$	��500��$
��1100��.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ SummaryDailyDataGrid��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ลำดับที่��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *No+   ElementStyle �� 	 �� 
TargetType"	 ��.��� 
 �� Property
 �@��TextAlignment �� Value$ Center=�  $! รายสินค้า��$	 400  �� *ProductName+ �� "	 ��.��� 
 �@��TextAlignment$ Center=�  $- 'วันที่และเวลา��$	 250  �� *Date+ �� "	 ��.��� 
 �@��TextAlignment$ Center=�  $ จำนวน��$	 200  �� *
Quantity+ �� "	 ��.��� 
 �@��TextAlignment$ Center=�  $? 9ยอดสั่งซื้อทั้งสิ้น��$ *  �� *
TotalBuy+ �� "	 ��.��� 
 �@��TextAlignment$ Center=�