   M S B A M L   `   `   `  ����I  EDJ_TPA_Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DJ_TPA_Program.ViewsDJ_TPA_Program.Views  5      1    +DJ_TPA_Program.Views.CreateResignLetterPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DJ_TPA_Program.Views     5        N� Title$  CreateResignLetterPage��5	      .��5      � ���	#FFB79898 � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $��* �6   �� 5"      $��20 �6   .+�5%   
   �� $��1��6   $��1��6$   $��30(�61   $��Under The Sea��5&      $��3��6)   $��0,0,0,15q�6=   �� 5'   
   $��1��6   $��2��6$   $��20(�61   $��Resign Form��5(      $��3��6'   $��0,0,0,10q�6;   &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ leavingTable��5*      $��1��6)   $��3��69   $��4��6F   $	��200��6Z      AutoGenerateColumns . 5+      �� 5/   
   $��1��6   $��4��6$   $��10(�61   $<��6You are not banned if the request declined by manager.��50      $��4��51      $��0,15,0,0q�6(   �� 52   
   $��1��6   $��5��6$   $��10(�61   $<��6If approved, please contact Human Resource Department.��53      $��4��54      $��0,0,0,10q�6(   �� 55   
   $��1��6   $��6��6$   $��15(�61   $��Resign Date : ��56      $��0,0,0,10q�6*   �� 57   
   $��1��6   $��7��6$   $��10(�61   $5��/Resign date must be at least 2 months from now.��58      $��4��59      $��0,0,0,10q�6(   (  "System.Windows.Controls.DatePicker  5:   
   -   5          Name$ 
resignDate��5:      $��2��6)   $��6��69   $��0,0,0,10q�5;      $��15(�6'   67   �� 5?   
   $��1��6   $��8��6$   $��15(�61   $��Resign Letter : ��5@      $��0,0,0,10q�6,   �� 5A   
   -   5         ��Name$ 
resignText��5A      $��2��6&   $��8��66   $	��150��5B      $��0,0,0,10q�6   �� 5D   
   -   5         ��Name$ doSendRequestButton��5D      $��Send Resign Letter��6.   $��1��5E      $��9��6!   $��5q�6.   $��	0,0,15,15q�5F      6$   5I      5J      