   M S B A M L   `   `   `  ����H  DEF_Code_First, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EF_Code_FirstEF_Code_First  5   	       EF_Code_First.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:EF_Code_First     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��600��6)    � WindowStartupLocation$ CenterScreen=�5	   	   .��5      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value��%w  '�       '�� P     '�� �     '�� .    '�� �    �� 5      " �6   .�5      ��  � ��$ 40 10q�6+   6;   5      �� 5      " ��6   .�5      ��  �@��Orientation$ 
Horizontal=�60   6E   �� 5       � ��$ 0 0 0 10q�6+   6>   5      �� 5      " ��6   .�5      ��  � ��$	 400��6*   68   5      �� 5      " ��6   .�5      ��  � �� �#a0a0a06A   �� 5       � ��$ 2q�64   6@   �� 5       � �� �#5454546B   5      �� 5      " ��6   .�5      ��  � ��$ 20q�6+   68   �� 5       � ��$	 100��6*   68   5      5        � RowDefinitions 5!   
   �� 5"      $
��auto �6   �� 5#      $
��auto �6   �� 5$      $��* �6   �� 5%      $
��auto �6   .+�5'   
   �� $��0��6   .+�5(      �� .��6   
CategoryID6    �� 5)      -   5         ��Name$ Id��5)      $
��23 0q�6"    �� 
IsReadOnly$
 True��60   6D   5*      �� 5+   
   $��1��6   .+�5,      �� .��6   Category Name6#   �� 5-      -   5        $
 Name��5-      6&   5.      �� 5/   
   -   5        $��lvCategories��5/       $��2��6   	 �� View	 50      �� 51      .P�52      �� $��Category ID��6%   
 �� Width$	
 120��6:    �� DisplayMemberBinding 6F   �� *Id+�� 53      $��Category Name��6%   $	
 120��6<    6H   �� *Name+54      56      �� 57   
   $��3��6   .+�58      �� -   5         ��Name$ 	btnInsert��58      .��6@   Insert6H   �� 59      .��6   Update6   �� 5:      .��6   Delete6   5;      5<      5=      