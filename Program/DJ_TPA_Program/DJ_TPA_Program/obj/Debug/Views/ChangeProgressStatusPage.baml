   M S B A M L   `   `   `  ����I  EDJ_TPA_Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DJ_TPA_Program.ViewsDJ_TPA_Program.Views  5      3    -DJ_TPA_Program.Views.ChangeProgressStatusPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DJ_TPA_Program.Views     5        N� Title$  ChangeProgressStatusPage��5	      .��5      � ���	#FFB79898 � ColumnDefinitions 5   
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
   $��1��6   $��2��6$   $��20(�61   $��Change Progress Status��5(      $��3��62   $��0,0,0,10q�6F   &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ 	rideTable��5*      $��1��6&   $��3��66   $��4��6C   $	��200��6W      AutoGenerateColumns . 5,      �� 50   
   $��1��6   $��4��6$   $��15(�61   $��Input Id : ��51      $��	0,15,0,10q�6'   �� 52   
   -   5         ��Name$ idText��52      $��2��6"   $��4��62   $	��150��53      $��	0,15,0,10q�6   �� 57   
   $��1��6   $��5��6$   $��15(�61   $-��'Input Status [On Going to Available] : ��58      $��0,0,0,10q�6C   �� 5:   
   -   5         ��Name$ doSendRequestButton��5:      $��Do Change Status��6.   $��1��5;      $��7��6!   $��5q�6.   $��	0,0,15,15q�5<      6$   5>      5?      