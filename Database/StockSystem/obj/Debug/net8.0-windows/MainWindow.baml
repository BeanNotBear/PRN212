   M S B A M L   `   `   `  ����F  BStockSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:StockSystemStockSystem  5   	       StockSystem.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:StockSystem     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value��%<  '�       '�� H     '�� �     '�� �    '�� #    '� �    �� 5      " �6   .�5      ��  � ��$ 30q�6+   5      �� 5      " ��6   .�5      ��  � ��$	 300��6*   �� 5       � ��$ 25��6+   �� 5       � ��$ 0 0 0 10q�6+   5      �� 5      " ��6   .�5      ��  � �� �#a0a0a06/   �� 5       � ��$ 2q�64   �� 5       � �� �#52525260   �� 5       � ��$	 400��6*   5      �� 5      " ��6   .�5      ��  �@��Orientation$ 
Horizontal=�60   �� 5       � ��$ Center=�68   5      �� 5      " ��6   .�5       ��  � ��$ 10q�6+   �� 5!       � ��$ 25��6+   �� 5"       � ��$	 100��6*   5#      �� 5$      " �6   .�5%      ��  � ��$ Center=�68   5&      5'       � RowDefinitions 5(   
   �� 5)      $
��auto �6   �� 5*      $
��auto �6   �� 5+      $��* �6   �� 5,      $
��auto �6   .+�5.   
   � $��0��6   .+�5/      �� .��6   Category ID:6"   �� 50      -   5        $��
CategoryId��52      $��	20 0 0 10q�50       �� 
IsReadOnly$
 True��51      ��53      ��  �� Path$ 
CategoryId�	 �� Mode$	 OneWay=�
 � DataContext
 54      ��  �� ElementName$ lvCategories��$ SelectedItem�6\   55      � 56   
   $��1��6   .+�57      �� .��6   Category Name:6$   �� 58      -   5        $��CategoryName��59      ��5:      �� $ CategoryName�$	 OneWay=�
 5;      �� $ lvCategories��$ SelectedItem�6W   5<      �� 5=   
   -   5        $��lvCategories��5=       $��2��6    �� View 5>      �� 5?      .P�5@      ��  �� Width$	 120��6%   $��Category ID��61    �� DisplayMemberBinding 6F   �� *
CategoryId+�� 5A      $	 240��6%   $��Category Name��61    6H   �� *CategoryName+5B      5D      �� 5E   
   $��3��6   .+�5F      �� -   5         ��Name$ btnInsertCategory��5F      .��6P   Insert6X   �� 5G      -   5        $ btnUpdatedCategory��5G      $��	40 0 40 0q�6R   .��6e   Update6m   �� 5H      -   5        $ btnDeleteCategory��5H      .��6P   Delete6X   5I      5J      5K      