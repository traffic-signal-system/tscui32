   M S B A M L   `   `   `  ���� b  ^DevComponents.WPF.Controls, Version=7.1.0.14, Culture=neutral, PublicKeyToken=ff0069e61369d6d6kLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.ControlsDevComponents.WPF.Controls  	 tscui=   7tscui.Pages.SimulateWirelessBtn.SimulateWirelessBtnView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     aControlsLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.Controls     -   $	��Top=�$	��500��  � 	Resources   �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� EndPoint �� 
StartPoint � Color	 � Offset
 �� Triggers P� Property P� Value �� 
TargetName3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   Color   	Direction   Opacity   RenderingBias   ShadowDepth��%�  '��       �� " ��.���  � ��$ 15(���  � ��$ 4q���  � ��$ Black"���  � ��
 �������  � ��$ 0q���  � ��
 �������  � ��$	 100����  � ��$ 35����  � �� �� " ��.R��� $��PART_Background��#��z��$��0q�$ 16������ $	 0,1&�$	 0,0&�.��� $ White��$		 0.0Q�� $ DarkGray��$		 0.5Q�� $ White��$		 0.0Q�._��� #��z��$��Center=�$��Center=�
 P�  �@J�IsMouseOver . . ��� $ PART_Background�� � �� �� $	 0,1&�$	 0,0&�.��� $ Silver��$		 0.0Q�� $ Black��$		 0.5Q�� $ Silver��$		 0.0Q�P�  � �� . . ���  �@J�Effect   $ 10Q�$ Black��$ 0Q�$	 0.6Q�$ Performance=�$ 0Q�.��� -    �Name$ RootGrid��$
��Left=�$	��490��$	��Top=�$	��776��$��24,0,0,0q� � ColumnDefinitions �� $��9* ��� $
��791* �.+��� -    ��Name$ 
ButtonsGrp��$�� ��$��13(�$
��Left=�$��
104,45,0,0q�$	��Top=�$	��395��$	��303��$��1��.��� -   $ 
ButtonGrid��$
��Left=�$	��356��$	��Top=�$	��293��$��0,0,-2,0q� � RowDefinitions �� $	��17* ��� $	��30* ��� $	��34* ��� $	��33* ��� $	��31* ��� $	��29* � �� �� �� .+��� -    ��Name$ BtnNorth��$	��北��$
��Left=�$��12.749,10,0,0q�$��1��$	��Top=�$��60.295��$��37.915���� -   $ BtnEast��$	��东��$��1��$
��Left=�$��12.75,9.884,0,0q�$��1��$	��Top=�$��60��$��37�� J� RenderTransformOrigin$ 0.555,0.039&��� -   $ BtnSouth��$	��南��$��2��$
��Left=�$��18.888,11.352,0,0q�$��1��$	��Top=�$��60��$��37���� -   $ BtbWest��$	��西��$
��Left=�$��13.044,12.912,0,0q�$��2��$	��Top=�$��60��$��37���� -	   $ BtnSouthNorthLeft��$��	南北左��$��1��$
��Left=�$��12.75,12.912,0,0q�$��2��$	��Top=�$��60��$��37���� -
   $ BtnSouthNorthStraight��$��	南北直��$��2��$
��Left=�$��18.888,12.912,0,0q�$��2��$	��Top=�$��60��$��37���� -   $ BtnEastWestLeft��$��	东西左��$
��Left=�$��13.044,10,0,0q�$��3��$	��Top=�$��60��$��37���� -   $ BtnEastWestStraight��$��	东西直��$��1��$
��Left=�$��12.75,10,0,0q�$��3��$	��Top=�$��60��$��37���� -   $ BtnYellowFlash��$��黄闪��$��2��$
��Left=�$��18.888,10,0,0q�$��3��$	��Top=�$��60��$��37���� -   $ BtnRed��$��全红��$
��Left=�$��13.044,10,0,0q�$��4��$	��Top=�$��60��$��37��$ -0.098,0.337&��� -   $ BtnNextStep��$��	下一步��$��1��$
��Left=�$��12.75,10,0,0q�$��4��$	��Top=�$��60��$��37���� -   $ BtnNextDirection��$��	下方向��$��2��$
��Left=�$��18.888,10,0,0q�$��4��$	��Top=�$��60��$��37���� -   $ BtnExit��$��退出��$
��Left=�$��13.044,10,0,0q�$��5��$	��Top=�$��60��$��37���� -   $ BtnManul��$��手控��$��1��$
��Left=�$��12.75,10,0,0q�$��5��$	��Top=�$��60��$��37���� -   $ BtnBack��$��备用��$��2��$
��Left=�$��18.888,10,0,0q�$��5��$	��Top=�$��60��$��37��{�.  �� -    ��Name$ label��$��	A型15键��$��1��$
��Left=�$��
104,10,0,0q�$	��Top=�$	��303��$��16(�$
��Bold"��� $
��Left=�$��412,329,0,0q�
������ $
��Wrap=�$	��Top=�$	��111��$	��345��$��1���� $��14(�$+�%无线遥控按键模拟操作说明:���� �� �� $u�o1. 此界面用于模拟操作无线手控按键效果。无线遥控按键和面板按键不能同时操作！���� �� $���2. 进入模拟无线手控需要先点击手控按钮，再进行其他按键操作。按键操作结束后按退出键恢复正常运行!���� �� 
���� ��$/�)3. 默认按键超时时间为30分钟！���� �� $� ���� 