   M S B A M L   `   `   `  ����@  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:tscui.Pages.CountDowntscui.Pages.CountDown  5      K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM 5      )    #tscui.Pages.CountDown.CountDownView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:tscui.Pages.CountDown     5      :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     5      -   5        $	��789��5
   _     Apex.MVVM.View    	ViewModel  5      .   (tscui.Pages.CountDown.CountDownViewModel  5   
   -   5        	viewModel��5   #   .��5      � $��0,0,10,0q�6   .+�5   
   � $
��Left=�6   $	��569��6*   $��	20,10,0,0q�67   $	��Top=�6K   $	��753��6c   .+�5      � -   5         �Name$ GridFlashBreakCount��5      $y�Hidden=�60   .+�5      � $
��Left=�6   $��30��6.   $��	10,41,0,0q�6:   $	��Top=�6M   $	��467��6e   .+�5      �� $��闪断时间(ms):��6   $
��Left=�6,   $��-3,4,0,0q�6G   $	��Top=�6Y   $��83��6q   �� 5      -   5         ��Name$ CbxFlashBreakTime��5      $
��Left=�66   $��88,4,0,0q�6Q   $	��Top=�6c   $	��231��6{    �� SelectedIndex$ 11��6�   .@�5      �� $	��0ms��6"   �� 5      $
��50ms��6"   �� 5      $��100ms��6"   �� 5      $��150ms��6"   �� 5      $��200ms��6"   �� 5      $��250ms��6"   �� 5      $��300ms��6"   �� 5       $��350ms��6"   �� 5!      $��400ms��6"   �� 5"      $��450ms��6"   �� 5#      $��500ms��6"   �� 5$      $��保持不变��6"   5%      5&      &   System.Windows.Controls.DataGrid  5'      -   5          Name$ dgdCountDown��5'       �� AlternationCount$ 2��6-   
������    CanUserAddRows .     AutoGenerateColumns .  $
��Left=�6�   $	��Top=�6�   $	��493��6�   $	��745��6�   $��6,76,0,0q�6�      AlternatingRowBackground �	#FF63C379	   Columns	 5(      0  *System.Windows.Controls.DataGridTextColumn  5)         tsc_countdown_id,  &System.Windows.Controls.DataGridColumn
   Header#
 �   6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6U      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6r   �� *	ucDevId+ �� Mode$ TwoWay=�  5*        tsc_countdown_phase#
 �  6)   $ 80 6X    6c   �� *	ucPhase+$ TwoWay=�  5+        tsc_countdown_overlapphase#
 �  6)   $ 80 6_    6k   �� *ucOverlapPhase+$ TwoWay=�  5,        tsc_countdown_mode#
 �  6)   $ 80 6W      
Visibility$ Hidden=�6b   4  .System.Windows.Controls.DataGridCheckBoxColumn  5-        tsc_countdown_green#
 �  6-   $ 80 6\    6h   �� *ucGreenFlashBreak+  5.        tsc_countdown_red#
 �  6-   $ 80 6[    6g   �� *ucRedFlashBreak+  5/        tsc_countdown_sec#
 �  6)   $ 80 6V    6c   �� *	ucSeconds+  50        tsc_countdown_fs#
 �  6-   $ 80 6Y    6e   �� *ucSendFlashBreak+52      �� 53      -   5         ��Name$ ChkSetFlashBreakPhase��53   .   $��设置闪断相位配置��6   $
��Left=�6M   $��
575,81,0,0q�6h   $	��Top=�6|   54        55      -   5        $ NewGbCountDown��55      $ 2��6/      
IsReadOnly . 
������  .   .  $��Center=�6�   $	��Top=�6�   $	��493��6�   $	��470��6�   $��10,76,273,0q�6�   $y�Hidden=�6   �	#FF63C379	 56        57      $
 倒计时方向��6)   $	 40* 68    .  6V   �� *	DirecName+  58      $(
 "倒计时跳线地址(GAT508-2014)��6)   $	 70* 6G    6S   �� *	CountAddr+  59      $&
  倒计时跳线地址(四方向)��6)   $	 50* 6?    6K   �� *CountAddr4Direc+5;      �� 5=      -   5         ��Name$ communicatecountown��5=        tsc_config_countdown#���  64   $
��Left=�6d   $��	10,68,0,0q�6   $	��Top=�6�   $	��257��6�   $	��467��6�   $y�Visible=�6�   .��5>      � $��12,0,2,2q�6   $	��223��6)   $��Bottom=�66   .+�5?      �� -	   5        $ CbxBaudrate��5?      $
��Left=�64   $��	82,29,0,0q�6O   $	��Top=�6b   $	��162��6z   $ 5��6�   .@�5@      �� $��9600bit��6&   �� 5A      $��2400bit��6&   �� 5B      $��4800bit��6&   �� 5C      $��19200bit��6&   �� 5D      $��38400bit��6&   �� 5E      $��保持不变��6&   5F      �� 5G      $��
波特率:��6   $
��Left=�6+   $��	28,29,0,0q�6F   $	��Top=�6Y   $��50��6q   �� 5H      $2��,注意:设置新波特率需重启信号机!��6   
���� ��$
��Left=�6K   $��	28,55,0,0q�6f   $	��Top=�6y   $	��187��6�   �� 5I      $
��Left=�6    
���� ��$��	34,86,0,0q�6O   $
��Wrap=�6b   $����通讯式倒计时设备跳线地址设置说明：

  1. GAT508-2004四方向倒计时方向与跳线地址对应: 北-0 东-1 南-2 西-3

  2. GAT508-2004相位配置倒计时设备与跳线地址对应如下(设备号在前)：
     1-0       2-1        3-2       4-3       5-4       6-5         7-6        8-7
    如果倒计时设备同时设置相位号和跟随相位号则以相位号为准。相位号
   设置范围1-32 ，跟随相位号设置范围1-16。��6v   $	��Top=�6�  $	��137��6�  $	��397��6�  5J      5K        5L      -
   5        $ GbPhaseCountDown��5L      $y�Visible=�62   $ 2��6G   
������  .   .  $��
10,343,0,0q�6�   $
��Left=�6�   $	��Top=�6�   $	��176��6�   $	��467��6�    �	#FF63C379��.  $   HorizontalScrollBarVisibility$ Disabled=�6T  "   VerticalScrollBarVisibility$ Disabled=�6}  	 5M        5N      #
 �   6)   $	 150 6U    .  6s   �� *	ucDevId+  5O      #
 �  6)   $	 150 6X    6d   �� *	ucPhase+$ TwoWay=�  5P      #
 �  6)   $ * 6_    6j   �� *ucOverlapPhase+$ TwoWay=�5R      �� 5S      -   5        $ 
CbxCntDown��5S      $
��Left=�6,   $��	98,18,0,0q�6G   $	��Top=�6Z   $	��231��6r   $ 6��6�   .@�5T      �� $4��.通讯式(国标GAT508-2004)四方向倒计时��6   �� 5U      $7��1通讯式(国标GAT508-2004)相位配置倒计时��6   �� 5V      $ ��触发(闪断)式倒计时��6   �� 5W      $ ��学习(跟随)式倒计时��6   �� 5X      $7��1通讯式(国标GAT508-2014)方向配置倒计时��6   �� 5Y      $4��.通讯式(国标GAT508-2014)四方向倒计时��6   �� 5Z      $��未知配置��6   5[      �� 5\      $��倒计时类型:��6   $
��Left=�6%   $��6,16,0,0q�6@   $	��Top=�6R   $��80��6j    J� RenderTransformOrigin$ 0.762,0.423&�6u   �� 5]      -   5         ��Name$ BtnSave��5]      $��设置��6&   $
��Left=�63   $��27��6N   $��
419,16,0,0q�6Z   $	��Top=�6n   $��75��6�   6�   �� 5^      -   5        $ BtnRead��5^      $��读取��6&   $
��Left=�63   $��27��6N   $��
334,16,0,0q�6Z   $	��Top=�6n   $��75��6�   6�   5_      5`      5a      