   M S B A M L   `   `   `  ����I  EDJ_TPA_Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DJ_TPA_Program.ViewsDJ_TPA_Program.Views  5      7    1DJ_TPA_Program.Views.RequestLeavingPermissionPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DJ_TPA_Program.Views     5        N� Title$"  RequestLeavingPermissionPage��5	      .��5      � ���	#FFB79898 � ColumnDefinitions 5   
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
   $��1��6   $��2��6$   $��20(�61   $ ��Request Leaving Permission��5(      $��3��66   $��0,0,0,10q�6J   &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ leavingTable��5*      $��1��6)   $��3��69   $��4��6F   $	��200��6Z      AutoGenerateColumns . 5+      �� 5/   
   $��1��6   $��4��6$   $��15(�61   $��Start Date : ��50      $��	0,15,0,10q�6)   (  "System.Windows.Controls.DatePicker  51   
   -   5          Name$ 	startTime��51      $��2��6(   $��4��68   $��	0,15,0,10q�52      $��15(�6(   68   �� 54   
   $��1��6   $��5��6$   $��15(�61   $��End Date : ��55      $��0,0,0,10q�6'     56   
   -   5        $ endTime��56      $��2��6&   $��5��66   $��0,0,0,10q�57      $��15(�6'   67   �� 5;   
   $��1��6   $��6��6$   $��15(�61   $��Reason Leaving : ��5<      $��0,0,0,10q�6-   �� 5=   
   -   5         ��Name$ 
reasonText��5=      $��2��6&   $��6��66   $	��150��5>      $��0,0,0,10q�6   �� 5@   
   -   5         ��Name$ doSendRequestButton��5@      $��Request Leaving��6.   $��1��5A      $��7��6!   $��5q�6.   $��	0,0,15,15q�5B      6$   5E      5F      