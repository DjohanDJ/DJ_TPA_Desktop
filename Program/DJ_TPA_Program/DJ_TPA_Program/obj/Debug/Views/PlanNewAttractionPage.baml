   M S B A M L   `   `   `  ����I  EDJ_TPA_Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DJ_TPA_Program.ViewsDJ_TPA_Program.Views  5      0    *DJ_TPA_Program.Views.PlanNewAttractionPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DJ_TPA_Program.Views     5        N� Title$  PlanNewAttractionPage��5	      .��5      � ���	#FFB79898 � ColumnDefinitions 5   
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
   $��1��6   $��2��6$   $��20(�61   $��Plan New Attraction Form��5(      $��3��64   $��0,0,0,10q�6H   �� 5,   
   $��1��6   $��3��6$   $��15(�61   $��Attraction Name : ��5-      $��0,0,0,10q�6.   �� 5.   
   -   5         ��Name$ attNameText��5.      $��2��6'   $��3��67   $	��150��5/      $��0,0,0,10q�6   �� 53   
   $��1��6   $��4��6$   $��15(�61   $#��Duration Attraction in Days: ��54      $��0,0,0,10q�69   �� 55   
   -   5         ��Name$ durabilityBox��55       �� Text$ -- Select --��6*    �� 
IsEditable .  �� 
IsReadOnly . $��2��57      $��4��6#   $��0,0,0,10q�60   .@�58      �� $��1��6   6)   �� 59      $��2��6   6)   �� 5:      $��3��6   6)   �� 5;      $��4��6   6)   �� 5<      $��5��6   6)   �� 5=      $��6��6   6)   �� 5>      $��7��6   6)   5?      �� 5C   
   $��1��6   $��5��6$   $��15(�61   $��Area Quantity : ��5D      $��0,0,0,10q�6,   �� 5E   
   -   5        $ quantityBox��5E      $ -- Select --��6(    .  . $��2��5G      $��5��6#   $��0,0,0,10q�60   .@�5H      �� $��1��6   6)   �� 5I      $��2��6   6)   �� 5J      $��3��6   6)   �� 5K      $��4��6   6)   �� 5L      $��5��6   6)   5M      �� 5P   
   $��1��6   $��6��6$   $��15(�61   $��Start Date : ��5Q      $��0,0,0,10q�6)   (  "System.Windows.Controls.DatePicker  5R   
   -   5          Name$ 	startDate��5R      $��2��6(   $��6��68   $��0,0,0,10q�5S      $��15(�6'   67   �� 5W   
   -   5        	 ��Name$	 
nextButton��5W      $
��Save��6%   $��1��5X      $��11��6!   $��5q�6/   $��0,0,0,10q�5Y      6#   5[      5\      