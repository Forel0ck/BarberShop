   M S B A M L   `   `   `  ����E  ABarberShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BarberShop.WindowsBarberShop.Windows  5   	   $    BarberShop.Windows.StuffWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BarberShop.Windows     5   	     � WindowStyle$
  None=�5   	    � WindowState$ 	Maximized=�5	   	    � Title$ StuffWindow��5
   	   $
��1080��6   $
��1920��6+   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   �� $��/Images\barberImg.png��5      $��3��5      �� 5   
   $��0��5      $��Расходники��5      $��70(�5       �� TextAlignment$ Center=�5      $��Center=�5      $��10q�5      
�������5      �� 5   
   -   5         ��Name$ Close��5       $��0��5      $��50��5!      $��50��5"      $��Center=�5#      $��Right=�5$      $��20q�5%      ��5'      Z� ��5(      Z� ��5*      �� 5+       �� ImageSource$ /Images/cross.png��6   5-      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ AllStuff��51      $��1��52         AutoGenerateColumns .  
������ 	   RowBackground
	 ���� 
   
IsReadOnly
 . 
�������   Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$  Наименнование��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 3* 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *	NameStuff+  5<      $ Колличество��6%   $ * 6:    6D   �� *Qty+  5=      $ Цена��6%   $ * 63    6=   �� *Cost+ � 	Resources 5?      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%]   '        7 �� 5@      8   "  6Q   .�5A      ��  � ��
 ��  �63   5B      5C      5D      �� 5E   
   -   5        $
 Exit��5G      $��2��5F      $��
Назад��5H      $��70��5I      $	��200��5J      $��35(�5K      $��50q�5L      $	��Top=�5M      5N      5P      5Q      