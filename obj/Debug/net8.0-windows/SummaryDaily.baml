   M S B A M L   `   `   `  ����H  DProject_CE216, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Project_CE216Project_CE216  5   	        Project_CE216.SummaryDaily   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Project_CE216     5   	     � Title$  SummaryDaily��5   	   $	��500��6   $
��1100��6+   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SummaryDailyDataGrid��5
         AutoGenerateColumns$ False��61      
IsReadOnly$
 True��6M      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ลำดับที่��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *No+   ElementStyle 5      �� 5      	 �� 
TargetType"	 ��6    .�5      �� 
 �� Property
 �@��TextAlignment �� Value$ Center=�6>   5      5        5      $! รายสินค้า��6%   $	 400 6X    68   �� *ProductName+ 5      �� 5      "	 ��6    .�5      �� 
 �@��TextAlignment$ Center=�6>   5      5        5      $- 'วันที่และเวลา��6%   $	 250 6U    6<   �� *Date+ 5      �� 5      "	 ��6    .�5      �� 
 �@��TextAlignment$ Center=�6>   5      5         5!      $ จำนวน��6%   $	 200 6Q    64   �� *
Quantity+ 5"      �� 5#      "	 ��6    .�5$      �� 
 �@��TextAlignment$ Center=�6>   5%      5'        5(      $? 9ยอดสั่งซื้อทั้งสิ้น��6%   $ * 6_    6B   �� *
TotalBuy+ 5)      �� 5*      "	 ��6    .�5+      �� 
 �@��TextAlignment$ Center=�6>   5,      5.      50      51      52      