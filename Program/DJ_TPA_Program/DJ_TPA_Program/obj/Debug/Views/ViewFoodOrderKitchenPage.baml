   M S B A M L   `   `   `  ����I  EDJ_TPA_Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DJ_TPA_Program.ViewsDJ_TPA_Program.Views  5      3    -DJ_TPA_Program.Views.ViewFoodOrderKitchenPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:DJ_TPA_Program.Views     5        N� Title$  ViewFoodOrderKitchenPage��5	      .��5      � ���	#FFB79898 � ColumnDefinitions 5   
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
   $��1��6   $��2��6$   $��20(�61   $ ��View Visitor Order Request��5(      $��3��66   $��0,0,0,10q�6J   &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ orderRequestTable��5*      $��1��6.   $��3��6>   $��4��6K   $	��200��6_      AutoGenerateColumns . 5+      �� 5/   
   $��1��6   $��4��6$   $��15(�61   $��Input Id : ��50      $��	0,15,0,10q�6'   �� 51   
   -   5         ��Name$ idText��51      $��2��6"   $��4��62   $	��150��52      $��	0,15,0,10q�6   �� 56   
   -   5         ��Name$ doSendRequestButton��56      $
��Cook��6.   $��1��57      $��7��6!   $��5q�6.   $��	0,0,15,15q�58      6$   5;      5<      