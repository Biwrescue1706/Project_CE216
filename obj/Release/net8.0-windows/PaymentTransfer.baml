   M S B A M L   `   `   `  ���� H  DProject_CE216, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Project_CE216Project_CE216  #    Project_CE216.PaymentTransfer   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:Project_CE216       � Title$  PaymentTransfer��$	��615��$
��1300��.���� 
���  ��$��5q�$��10,10,10,10q�._��� .+��  � ColumnDefinitions �� $��* �.+��� $9��3ชำระเงินโดยการโอน��$��30(�$��Center=�$��TH SarabunPSK)�$
��Bold"�$��0,5,0,20q��� .+�� $	��490�� �� $	��69* ��� $
��114* ��� $	��71* �.+��� -    ��Name$ 
BackButton��$��0��$��<------��$��40(�$��35,30,195,400q��� $,��&ราคาทั้งสิ้น: ��$��20(�$��0,327,0,120q�$��Center=�$	��100���� -    ��Name$ NameP��$��1��$��20(�$��	65,30,0,0q�$	��250��$��60��$
��Left=�$	��Top=� �� TextAlignment$ Center=��� -    ��Name$ Total��$��1��$��20(�$��87,327,89,120q��� $��	บาท��$��2��$��20(�$��58,327,0,120q�$
��Left=�$	��100���� -    ��Name$ ImageQR��$��1��$
��Left=�$��153,118,0,197q�$	��241�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ 0.718Q�T� �� -   $ 
GenerateQR��$��1��$��สร้าง QR Code��$��20(�$��Center=�$��	0,415,0,0q�$	��Top=�$��50��$	��186���� -   $	 Pay��$��2��$0��*ชำระเงินสำเร็จ��$��20(�$
��Left=�$��
78,415,0,0q�$	��Top=�$��50��$	��186��