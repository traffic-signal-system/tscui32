   M S B A M L   `   `   `  ���� @  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:tscui.Pages.CountDowntscui.Pages.CountDown  K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM )    #tscui.Pages.CountDown.CountDownView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:tscui.Pages.CountDown     :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     -   $	��789��  Apex.MVVM.View    	ViewModel  .   (tscui.Pages.CountDown.CountDownViewModel  -   	viewModel��.��� $��0,0,10,0q�.+�� $
��Left=�$	��569��$��	20,10,0,0q�$	��Top=�$	��753��.+�� -    �Name$ GridFlashBreakCount��$y�Hidden=�.+�� $
��Left=�$��30��$��	10,41,0,0q�$	��Top=�$	��467��.+��� $��闪断时间(ms):��$
��Left=�$��-3,4,0,0q�$	��Top=�$��83���� -    ��Name$ CbxFlashBreakTime��$
��Left=�$��88,4,0,0q�$	��Top=�$	��231�� �� SelectedIndex$ 11��.@��� $	��0ms���� $
��50ms���� $��100ms���� $��150ms���� $��200ms���� $��250ms���� $��300ms���� $��350ms���� $��400ms���� $��450ms���� $��500ms���� $��保持不变��&   System.Windows.Controls.DataGrid  -     Name$ dgdCountDown�� �� AlternationCount$ 2��
������    CanUserAddRows .     AutoGenerateColumns .  $
��Left=�$	��Top=�$	��493��$	��745��$��6,76,0,0q�   AlternatingRowBackground �	#FF63C379	   Columns	 0  *System.Windows.Controls.DataGridTextColumn     tsc_countdown_id,  &System.Windows.Controls.DataGridColumn
   Header#
 �      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ucDevId+ �� Mode$ TwoWay=�    tsc_countdown_phase#
 �  $ 80  �� *	ucPhase+$ TwoWay=�    tsc_countdown_overlapphase#
 �  $ 80  �� *ucOverlapPhase+$ TwoWay=�    tsc_countdown_mode#
 �  $ 80    
Visibility$ Hidden=�4  .System.Windows.Controls.DataGridCheckBoxColumn    tsc_countdown_green#
 �  $ 80  �� *ucGreenFlashBreak+    tsc_countdown_red#
 �  $ 80  �� *ucRedFlashBreak+    tsc_countdown_sec#
 �  $ 80  �� *	ucSeconds+    tsc_countdown_fs#
 �  $ 80  �� *ucSendFlashBreak+�� -    ��Name$ ChkSetFlashBreakPhase��$��设置闪断相位配置��$
��Left=�$��
575,81,0,0q�$	��Top=�  -   $ NewGbCountDown��$ 2��   
IsReadOnly . 
������  .   .  $��Center=�$	��Top=�$	��493��$	��470��$��10,76,273,0q�$y�Hidden=� �	#FF63C379	   $
 倒计时方向��$	 40*  .  �� *	DirecName+  $(
 "倒计时跳线地址(GAT508-2014)��$	 70*  �� *	CountAddr+  $&
  倒计时跳线地址(四方向)��$	 50*  �� *CountAddr4Direc+�� -    ��Name$ communicatecountown��  tsc_config_countdown#���  $
��Left=�$��	10,68,0,0q�$	��Top=�$	��257��$	��467��$y�Visible=�.��� $��12,0,2,2q�$	��223��$��Bottom=�.+��� -	   $ CbxBaudrate��$
��Left=�$��	82,29,0,0q�$	��Top=�$	��162��$ 5��.@��� $��9600bit���� $��2400bit���� $��4800bit���� $��19200bit���� $��38400bit���� $��保持不变���� $��
波特率:��$
��Left=�$��	28,29,0,0q�$	��Top=�$��50���� $2��,注意:设置新波特率需重启信号机!��
���� ��$
��Left=�$��	28,55,0,0q�$	��Top=�$	��187���� $
��Left=�
���� ��$��	34,86,0,0q�$
��Wrap=�$����通讯式倒计时设备跳线地址设置说明：

  1. GAT508-2004四方向倒计时方向与跳线地址对应: 北-0 东-1 南-2 西-3

  2. GAT508-2004相位配置倒计时设备与跳线地址对应如下(设备号在前)：
     1-0       2-1        3-2       4-3       5-4       6-5         7-6        8-7
    如果倒计时设备同时设置相位号和跟随相位号则以相位号为准。相位号
   设置范围1-32 ，跟随相位号设置范围1-16。��$	��Top=�$	��137��$	��397��  -
   $ GbPhaseCountDown��$y�Visible=�$ 2��
������  .   .  $��
10,343,0,0q�$
��Left=�$	��Top=�$	��176��$	��467�� �	#FF63C379��.  $   HorizontalScrollBarVisibility$ Disabled=�"   VerticalScrollBarVisibility$ Disabled=�	   #
 �   $	 150  .  �� *	ucDevId+  #
 �  $	 150  �� *	ucPhase+$ TwoWay=�  #
 �  $ *  �� *ucOverlapPhase+$ TwoWay=��� -   $ 
CbxCntDown��$
��Left=�$��	98,18,0,0q�$	��Top=�$	��231��$ 6��.@��� $4��.通讯式(国标GAT508-2004)四方向倒计时���� $7��1通讯式(国标GAT508-2004)相位配置倒计时���� $ ��触发(闪断)式倒计时���� $ ��学习(跟随)式倒计时���� $7��1通讯式(国标GAT508-2014)方向配置倒计时���� $4��.通讯式(国标GAT508-2014)四方向倒计时���� $��未知配置���� $��倒计时类型:��$
��Left=�$��6,16,0,0q�$	��Top=�$��80�� J� RenderTransformOrigin$ 0.762,0.423&��� -    ��Name$ BtnSave��$��设置��$
��Left=�$��27��$��
419,16,0,0q�$	��Top=�$��75���� -   $ BtnRead��$��读取��$
��Left=�$��27��$��
334,16,0,0q�$	��Top=�$��75��