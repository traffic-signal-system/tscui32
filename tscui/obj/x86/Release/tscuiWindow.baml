   M S B A M L   `   `   `  ���� @  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:tscuitscui  )clr-namespace:tscui.Viewstscui.Views  K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls     tscui.tscuiWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     %localclr-namespace:tscui     +viewsclr-namespace:tscui.Views     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     -      Apex.Controls.CustomWindow   Name$  	zuneShell��
�����w� � Title$ tscui��$	��750��$	��900��$	��600��$	��500�� � 	Resources 1   +tscui.WindowStateToBorderThicknessConverter )  %WindowStateToBorderThicknessConverter2   ,tscui.WindowStateToButtonVisibilityConverter * &WindowStateToButtonVisibilityConverter  EmptyThumbStyle �� 
TargetType �� Property �� Value��%Z   &	        &	      &	 
         �� " n�.���  � �� �� .R�� #��z��.��  Apex.Controls.ApexGrid  $��0,0,0,-2q�.+�  
������    Rows$ Auto,*,Auto��   Columns$ Auto,*,Auto��.+�n� -    n�Name$ thumbTopLeft��$��0��$��0��	 � Cursor$	 SizeNWSE��#��[ ���� 
 �� ElementName$
 	zuneShell�� �� Path$ 
Background� �� Mode$ OneWay=����� $
 	zuneShell��$ WindowState�$ OneWay=� �� 	Converter# [   �� ConverterParameter$ TopLeft������ $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ TopLeft��n� -   $ thumbTop��$��0��$��1��$	 SizeNS��#��[ ���� $
 	zuneShell��$ 
Background�$ OneWay=����� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $	 Top��n� -   $ thumbTopRight��$��0��$��2��$	 SizeNESW��#��[ ���� $
 	zuneShell��$ 
Background�$ OneWay=����� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ TopRight������ $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ TopRight��n� -   $ 	thumbLeft��$��1��$��0��$	 SizeWE��#��[ ���� $
 	zuneShell��$ 
Background�$ OneWay=����� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $
 Left��n� -   $ 
thumbRight��$��1��$��2��$	 SizeWE��#��[ ���� $
 	zuneShell��$ 
Background�$ OneWay=����� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $
 Left��n� -   $ thumbBottomLeft��$��2��$��0��$	 SizeNESW��#��[ ���� $
 	zuneShell��$ 
Background�$ OneWay=����� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ 
BottomLeft������ $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ 
BottomLeft��n� -   $ thumbBottom��$��2��$��1��$	 SizeNS��#��[ ���� $
 	zuneShell��$ 
Background�$ OneWay=����� $
 	zuneShell��$ WindowState�$ OneWay=�# [  $ Bottom���� -	    ��Name$ borderWindowTitle��$��1��$��1��$	��Top=�$��Stretch=�$��24��
������   $
��Auto��$
��Auto��$��Right=�$	��Top=�.+���  �� Orientation$ 
Horizontal=�$��Right=�$��4q�.+�  Apex.Controls.ImageButton  -
     Name$ minimizeButton��$��2q�$��1q�$
	 Hand�� � ToolTip$ Minimize��   NormalImageSource$4 ./tscui;component/Resources/Images/Minimize.png��   MouseOverImageSource$8 2/tscui;component/Resources/Images/MinimizeOver.png��y��� $
 	zuneShell��$ WindowState�# [ $ Minimize��  -   $ restoreButton��$��2q�$��1q�$
	 Hand��$ Restore��$3 -/tscui;component/Resources/Images/Restore.png��$7 1/tscui;component/Resources/Images/RestoreOver.png��y��� $
 	zuneShell��$ WindowState�# [ $ Restore��  -   $ closeButton��$��2q�$��1q�$
	 Hand��$ Close��$1 +/tscui;component/Resources/Images/Close.png��$5 //tscui;component/Resources/Images/CloseOver.png��   tscui.Views.MainView  -     Name$ view1���� -    ��Name$ 	tscstatus��
����ح�
���   �$��1q�$
��Left=�$��23��$��Bottom=�$
��Auto��.@��� -   $��tb��  tscinfo#���  
���   �$
��Left=�{�.  ���� $
 	zuneShell��$ Width�