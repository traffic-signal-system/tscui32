   M S B A M L   `   `   `  ����@  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:tscuitscui  5   	   )clr-namespace:tscui.Viewstscui.Views  5   	   K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls 5   	       tscui.tscuiWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   %localclr-namespace:tscui     5   	   +viewsclr-namespace:tscui.Views     5   	   BapexControls)clr-namespace:Apex.Controls;assembly=Apex     5   	   -   5           Apex.Controls.CustomWindow   Name$  	zuneShell��5   	   
�����w� � Title$ tscui��5	   	   $	��750��5
   	   $	��900��6   $	��600��6#   $	��500��62    � 	Resources 5      1   +tscui.WindowStateToBorderThicknessConverter )  %WindowStateToBorderThicknessConverter2   ,tscui.WindowStateToButtonVisibilityConverter * &WindowStateToButtonVisibilityConverter  EmptyThumbStyle �� 
TargetType �� Property �� Value��%�   &	        &	      &	 &       5   
   66     5   
   67   �� 5   
   " n�6(   .�5      ��  � �� 5      �� 5      .R�5      � #��z��6   5      5      5      5      .��5        Apex.Controls.ApexGrid  $��0,0,0,-2q�6   .+�5   
     
������    Rows$ Auto,*,Auto��69      Columns$ Auto,*,Auto��6L   .+�5"      n� -   5         n�Name$ thumbTopLeft��5#      $��0��5$      $��0��6   	 � Cursor$	 SizeNWSE��6.   #��[ 6@   ��5%      �� 
 �� ElementName$
 	zuneShell�� �� Path$ 
Background� �� Mode$ OneWay=���5&      �� $
 	zuneShell��$ WindowState�$ OneWay=� �� 	Converter# [   �� ConverterParameter$ TopLeft����5'      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ TopLeft��5(      n� 5+      -   5        $ thumbTop��5,      $��0��5-      $��1��6   $	 SizeNS��6.   #��[ 6>   ��5.      �� $
 	zuneShell��$ 
Background�$ OneWay=���5/      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $	 Top��50      n� 53      -   5        $ thumbTopRight��54      $��0��55      $��2��6   $	 SizeNESW��6.   #��[ 6@   ��56      �� $
 	zuneShell��$ 
Background�$ OneWay=���57      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ TopRight����58      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ TopRight��59      n� 5<      -   5        $ 	thumbLeft��5=      $��1��5>      $��0��6   $	 SizeWE��6.   #��[ 6>   ��5?      �� $
 	zuneShell��$ 
Background�$ OneWay=���5@      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $
 Left��5A      n� 5D      -   5        $ 
thumbRight��5E      $��1��5F      $��2��6   $	 SizeWE��6.   #��[ 6>   ��5G      �� $
 	zuneShell��$ 
Background�$ OneWay=���5H      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $
 Left��5I      n� 5L      -   5        $ thumbBottomLeft��5M      $��2��5N      $��0��6   $	 SizeNESW��6.   #��[ 6@   ��5O      �� $
 	zuneShell��$ 
Background�$ OneWay=���5P      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ 
BottomLeft����5Q      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ 
BottomLeft��n� 5U      -   5        $ thumbBottom��5V      $��2��5W      $��1��6   $	 SizeNS��6.   #��[ 6>   ��5X      �� $
 	zuneShell��$ 
Background�$ OneWay=���5Y      �� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ Bottom��5Z      �� 5^      -	   5         ��Name$ borderWindowTitle��5_      $��1��5`      $��1��6   $	��Top=�6.   $��Stretch=�6F   $��24��6d   
������ 5b      5d        5g   
   $
��Auto��6!   $
��Auto��6.   $��Right=�6<   $	��Top=�6X   .+�5j      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��4q�6N   .+�5m        Apex.Controls.ImageButton  -
   5          Name$ minimizeButton��5n      $��2q�5o      $��1q�6!   $
	 Hand��6,    � ToolTip$ Minimize��6:      NormalImageSource$4 ./tscui;component/Resources/Images/Minimize.png��5p         MouseOverImageSource$8 2/tscui;component/Resources/Images/MinimizeOver.png��5q      y�5r      �� $
 	zuneShell��$ WindowState�# [ $ Minimize��  5v      -   5        $ restoreButton��5w      $��2q�5x      $��1q�6!   $
	 Hand��6,   $ Restore��6:   $3 -/tscui;component/Resources/Images/Restore.png��5y      $7 1/tscui;component/Resources/Images/RestoreOver.png��5z      y�5{      �� $
 	zuneShell��$ WindowState�# [ $ Restore��  5�      -   5        $ closeButton��5�      $��2q�5�      $��1q�6!   $
	 Hand��6,   $ Close��6:   $1 +/tscui;component/Resources/Images/Close.png��5�      $5 //tscui;component/Resources/Images/CloseOver.png��5�      5�      5�         tscui.Views.MainView  5�   
   -   5          Name$ view1��5�      �� 5�   
   -   5         ��Name$ 	tscstatus��5�      
����ح�
���   �$��1q�6S   $
��Left=�6g   $��23��6�   $��Bottom=�6�   $
��Auto��6�   .@�5�      �� -   5        $��tb��5�        tscinfo#���  6"   
���   �$
��Left=�6�   {�.  ��6V   �� $
 	zuneShell��$ Width�6�   5�      5�      5�      