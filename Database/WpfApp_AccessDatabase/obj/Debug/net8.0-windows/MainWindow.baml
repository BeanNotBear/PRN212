   M S B A M L   `   `   `  ����P  LWpfApp_AccessDatabase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApp_AccessDatabaseWpfApp_AccessDatabase  5   	   &     WpfApp_AccessDatabase.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfApp_AccessDatabase     5   	   -   5          � Title$  Manage Categories��5   	   $	��450��6#   $	��400��60    � WindowStartupLocation$ CenterScreen=�5	   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6   
����ح� � Orientation$ Vertical=�68   .+�5      �� $��Category Information��6   $
��Bold"�5      
���  ��$��18(�5      �� 5      $��Category ID:��6   �� 5      -   5        $��txtCategoryId��5   4    �� 
IsReadOnly$
 True��6   $��25��6(   ��5      ��  �� Path$ 
CategoryId� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ 
lvCategory��$ SelectedItem��� 5      $��Category Name:��6   �� 5      -   5        $��txtCategoryName��5   "   $��25��6   ��5      �� $ CategoryName�$ OneWay=� 5      �� $ 
lvCategory��$ SelectedItem��� 5      	 �� Orientation$	 
Horizontal=�6   .+�5      �� -   5        
 ��Name$
 Insert��5"      $��Insert��5      $��80��5      $��25��5       $��10q�5!      5#      �� 5$      -   5        $
 	btnUpdate��5(      $��Update��5$      $��80��5%      $��25��5&      $��10q�5'      5)      �� 5*      -   5        $
 	btnDelete��5.      $��Delete��5*      $��80��5+      $��25��5,      $��10q�5-      5/      50      51      �� 52   
   -   5        $��
lvCategory��52       $��1��6    �� View 53      �� 54      .P�55      �� $��Category ID��6%    �� Width$	 100��56   %    �� DisplayMemberBinding 57   %   �� $ 
CategoryId��� 58      $��Category Name��6%   $	 200��59   %    5:   %   �� $ CategoryName�5;      5=      5>      5?      