   M S B A M L   `   `   `  ����I  EDJ_TPA_Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DJ_TPA_Program.ViewsDJ_TPA_Program.Views  5      /    )DJ_TPA_Program.Views.RegisterCustomerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DJ_TPA_Program.Views     5        N� Title$  RegisterCustomerPage��5	      .��5      � ���	#FFB79898 � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $	��130 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
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
��auto �6   �� 5!      $
��auto �6   �� 5"      $��* �6   �� 5#      $��20 �6   .+�5'   
   �� $��1��6   $��1��6$   $��30(�61   $��Under The Sea��5(      $��3��6)   $��0,0,0,15q�6=   �� 5)   
   $��1��6   $��2��6$   $��20(�61   $��Register Customer��5*      $��3��6-   $��0,0,0,10q�6A   �� 5.   
   $��1��6   $��4��6$   $��15(�61   $��Fullname : ��5/      $��0,0,0,10q�6'   �� 50   
   -   5         ��Name$ fullnameText��50      $��2��6(   $��4��68   $	��150��51      $��0,0,0,10q�6   �� 55   
   $��1��6   $��5��6$   $��15(�61   $��Email : ��56      $��0,0,0,10q�6$   �� 57   
   -   5        $ 	emailText��57      $��2��6%   $��5��65   $	��150��58      $��0,0,0,10q�6   �� 5<   
   $��1��6   $��7��6$   $��15(�61   $��Phone Number : ��5=      $��0,0,0,10q�6+   �� 5>   
   -   5        $ phoneNumberText��5>      $��2��6+   $��7��6;   $	��150��5?      $��0,0,0,10q�6"   �� 5C   
   $��1��6   $��8��6$   $��15(�61   $��
Address : ��5D      $��0,0,0,10q�6&   �� 5E   
   -   5        $ addressText��5E      $��2��6'   $��8��67   $	��150��5F      $��0,0,0,10q�6"   �� 5J   
   $��1��6   $��9��6$   $��15(�61   $��	Gender : ��5K      $��0,0,0,10q�6%   �� 5L   
   -   5         ��Name$ 	genderBox��5L       �� Text$ -- Select --��6&    �� 
IsEditable .  �� 
IsReadOnly . $��2��5N      $��9��6#   $��0,0,0,10q�60   .@�5O      �� $
��Male��6   6,   �� 5P      $��Female��6   6.   5Q      �� 5U   
   $��1��6   $��10��6$   $��15(�62   $��Username : ��5V      $��0,0,0,10q�6'   �� 5W   
   -   5        $ usernameText��5W      $��2��6(   $��10��68   $	��150��5X      $��0,0,0,10q�6"   �� 5\   
   $��1��6   $��11��6$   $��15(�62   $��Password : ��5]      $��0,0,0,10q�6'   �� 5^   
   -   5        $ passwordText��5^      $��2��6(   $��11��68   $	��150��5_      $��0,0,0,10q�6"   �� 5c   
   -   5         ��Name$ registerButton��5c      $��
Register !��6)   $��1��5d      $��12��6!   $��5q�6/   $��0,0,0,10q�5e      6#   5h      5i      