   M S B A M L   `   `   `  ���� b  ^DevComponents.WPF.Controls, Version=7.1.0.14, Culture=neutral, PublicKeyToken=ff0069e61369d6d6kLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.ControlsDevComponents.WPF.Controls  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 	 tscui-   'tscui.Pages.BusPriority.BusPriorityView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     aControlsLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.Controls     9System&clr-namespace:System;assembly=mscorlib     -   $	��Top=�$��398.508��.��� $
��Left=�$	��391��$	��Top=�$	��800��$��1,0,-1,0q�  � ColumnDefinitions  �� $��9* ��� $
��791* �.+��� $*��$优先相位车辆检测设备类型��$��13(�$
��Left=�$��	31,41,0,0q�$	��Top=�$	��100��$	��453��$��1��.���� $
��Left=�$��64��$	��Top=�$	��413��$��10,0,0,0q�.+�	� -    	�Name$ Device_Rfid��$��12(�$��射频RFID（默认）�� �� Left$ 41��
 �� Top$ 24��$��28��$	��119��	� -   $ Device_Coil��$��12(�$��感应线圈��$	 191��$ 24��$��72�� d� 	IsChecked$
 TrueY�	� -   $ 	Device_Dc��$��12(�$��地磁��$	 331��$ 24��$��72���� $��优先相位参数��$��13(�$
��Left=�$��
31,158,0,0q�$	��Top=�$	��169��$	��453��$��1��{��� *	IsChecked+ �� ElementName$ ChkBusPriority��.���� $
��Left=�$	��153��$	��Top=�$	��434��$��0,0,0,-8q�.+��� $#��优先相位绿灯延长(秒)��$��12(�$ 17��$��25��$	��128��$ -2��/   )DevComponents.WPF.Controls.NumericSpinner  -     Name$ DelayGreenTime��$	 140��$ 17��$��25��$��43��#��� ��   Value$ 10��   	Increment$ 1Q�	 � ForceCursor	 . 
   Interval$
 1Q�   Maximum$ 30Q�   Minimum$ 1Q�   NullValueDisplayString$ xx���� $&�� 检测位置至路口时间(秒)��$��12(�$ 58��$��25��$	��129��$ -2��  -   $ BusArriveTime��$	 140��$ 58��$��25��$��43��#��� ��$ 10��$ 1Q�	 . $
 1Q�$ 30Q�$ 1Q�$ xx���� $��红灯提早方式��$	 188��$ 10��$	��113��$	��251��$��0q�.��� $
��Left=�$��77��$	��Top=�$	��241��$��
-1,0,-1,-3q�.+�  -   $ EarlyRedTime��$��25��#��� ��$ 10��$ 1Q�	 . $
 1Q�$ 30Q�$ 1Q�$ xx��$��191,10,0,45q�	� -   $ RadReduceTimeType1��$&�� 非优先相位缩短时间(秒)��$
 TrueY�$
��Left=�$��7,15,0,0q�$	��Top=�	� -	   $ RadReduceTimeType2��$$��非优先相位最小绿时间��$
��Left=�$��7,52,0,0q�$	��Top=��� -
    ��Name$ Simulatebtn��$��读取��$��10(�$��1��$��167,355,560,8q� J� RenderTransformOrigin$ -0.266,0.464&��� -   $��设置��$��10(�$��1��$��31,355,696,8q��� -    ��Name$ ChkBusPriority��$��启用相位优先放行��$��1��$
��Left=�$��	31,16,0,0q�$	��Top=��� $��优先相位类型��$��13(�$
��Left=�$��
489,41,0,0q�$	��Top=�$	��100��$	��292��$��1��{��� *	IsChecked+$ ChkBusPriority��.���� $
��Left=�$��77��$	��Top=�$	��282��$��	0,0,-2,-1q�.+��� -    ��Name$ ComboxBusPhaseId�� �� DisplayMemberPath$
 name�� �� SelectedValue$ id��$
��Left=�$	��Top=�$��25��$	��120��$	 152��$ 10���� $��优先放行相位号��$��12(�$ 40��$ 10��$��27��$	��107��	� -   $ RadPhase��$ 20��$ 17��$
 TrueY��� $��优先放行方向��$��12(�$ 40��$ 42��$��35��$	��107��$y�Hidden=��� -   $ ComboxDirec��$
��Left=�$	��Top=�$��25��$	��120��$	 152��$ 43��$y�Hidden=�.@���北����东����南����西��	� -   $ RadDirec��$ 20��$ 48��$y�Hidden=��� $��当前优先相位状态��$��13(�$
��Left=�$��489,158,0,0q�$	��Top=�$	��169��$	��292��$��1��{��� *	IsChecked+$ ChkBusPriority��.���� $
��Left=�$	��134��$	��Top=�$	��282��$��	0,10,-2,0q�.+��� $!��当前优先相位灯色：��$��12(�$ 36��$��25��$	��113��$ 3���� -    ��Name$ BusPhaseColor��$��未知��$��12(�$ 36��$��25��$	��161��$	 121���� $��周期时长(秒)：��$��12(�$ 66��$��25��$��95��$ 3���� -   $ PresentCycle��$��未知��$��12(�$ 66��$��25��$	��131��$	 121���� -   $ BusPhaseColorHandle��$��未知��$��12(�$ 96��$��38��$	��161��$	 121�� J� 	AllowDrop . �� $!��方案相位时长变化：��$��12(�$ 96��$��25��$	��113��$ 3���� -   $ ChkOpenBusPriority��$��开启监控��$ 9��$ 13��