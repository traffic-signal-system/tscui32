   M S B A M L   `   `   `  ���� b  ^DevComponents.WPF.Controls, Version=7.1.0.14, Culture=neutral, PublicKeyToken=ff0069e61369d6d6kLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.ControlsDevComponents.WPF.Controls  	 tscui   tscui.Pages.Power.Power   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     aControlsLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.Controls     -   $	��Top=�$	��610��.��� $
��Left=�$	��501��$	��Top=�$	��776��  � ColumnDefinitions  �� $
��681* ��� $	��95* � � RowDefinitions �� $
��115* ��� $
��195* ��� $
��191* ��� $��0* �.+��� $��①预警电压参数��$��13(�$
��Left=�$��78,1,0,0q�$	��Top=�$	��116��$	��599��$��2��{�.  .��� $
��Left=�$��92��$	��Top=�$	��587��$��2,18,-2,-18q�.+��� $��高压预警电压:��$
��Left=�$��30��$	��Top=�$��97��$��	10,18,0,0q��� $��低压预警电压:��$
��Left=�$��30��$	��Top=�$��93��$��
300,20,0,0q�/   )DevComponents.WPF.Controls.NumericSpinner  -     Name$ HighVoltage��$
��Left=�$��
112,18,0,0q�$��30��$	��Top=�$��54��   Value$	 260��   Maximum$	 270Q�   Minimum$	 220Q�#��� ��   NullValueDisplayString$ xx��{�.    -   $ 
LowVoltage��$
��Left=�$��
398,18,0,0q�$��30��$	��Top=�$��54��$	 160��$	 210Q�$	 155Q�#��� ��$ xx��{�.  �� $��②强电预案��$��13(�$
��Left=�$��	78,10,0,0q�$	��Top=�$	��188��$	��599��$��1��$��2��{�.  .��� $
��Left=�$	��165��$	��Top=�$	��587��$��	2,0,-2,-1q�.+��� $��强电高压保护预案��$
��Left=�$��	10,24,0,0q�$	��Top=�$	��131��$	��219��.��� $
��Left=�$	��107��$	��Top=�$	��207��.+�	� -    	�Name$ 
HigthVolOn��$��高压保护开启��$
��Left=�$��	10,11,0,0q�$	��Top=�	� -   $ HigthVolOff��$��高压保护关闭��$
��Left=�$��	10,45,0,0q�$	��Top=� d� 	IsChecked$
 TrueY�	� -   $ HigthVolRserve��$��保持当前预案��$
��Left=�$��	10,80,0,0q�$	��Top=�	 J� RenderTransformOrigin$	 0.555,1.126&��� $��强电低压保护预案��$
��Left=�$��
305,24,0,0q�$	��Top=�$	��131��$	��218��	� -   $ LowVolOn��$��低压保护开启��$
��Left=�$��
321,50,0,0q�$	��Top=�	� -   $ 	LowVolOff��$��低压保护关闭��$
��Left=�$��
321,84,0,0q�$	��Top=�$
 TrueY�	� -	   $ LowVolRserve��$��保持当前预案��$
��Left=�$��321,119,0,0q�$	��Top=�$	 0.555,1.126&��� $��③弱电保护预案��$��13(�$
��Left=�$��	78,4,0,-1q�$	��Top=�$	��188��$	��599��$��2��$��2��{�.  .��� $
��Left=�$	��165��$	��Top=�$	��587��$��	2,0,-2,-1q�.+��� $��弱电高压保护预案��$
��Left=�$��	10,24,0,0q�$	��Top=�$	��131��$	��219��.��� $
��Left=�$	��107��$	��Top=�$	��207��.+�	� -
   $ HigthVolOn1��$��高压保护开启��$
��Left=�$��	10,11,0,0q�$	��Top=�	� -   $ HigthVolOff1��$��高压保护关闭��$
��Left=�$��	10,45,0,0q�$	��Top=�$
 TrueY�	� -   $ HigthVolReserve1��$��保持当前预案��$
��Left=�$��	10,80,0,0q�$	��Top=�$	 0.555,1.126&��� $��弱电低压保护预案��$
��Left=�$��
305,24,0,0q�$	��Top=�$	��131��$	��218��	� -   $ 	LowVolOn1��$��低压保护开启��$
��Left=�$��
321,50,0,0q�$	��Top=�	� -   $ 
LowVolOff1��$��低压保护关闭��$
��Left=�$��
321,84,0,0q�$	��Top=�$
 TrueY�	� -   $ LowVolReserve1��$��保持当前预案��$
��Left=�$��321,119,0,0q�$	��Top=�$	 0.555,1.126&��� $��④看门狗参数��$��13(�$
��Left=�$��
78,5,0,-77q�$	��Top=�$��72��$	��599��$��3��.��� $
��Left=�$��48��$	��Top=�$	��587��.+�	� -   $ Opendog��$��开启看门狗��$
��Left=�$��	10,10,0,0q�$	��Top=�$��28��$��90��	� -   $ Closedog��$��关闭看门狗��$
��Left=�$��
197,10,0,0q�$	��Top=�$��28��$��90��  -   $ Watchdogtime��$
��Left=�$��
477,0,0,14q�$��Bottom=�$��30��$��54��#��� ��$ 40��$	 127Q�$ 25Q�
   	Increment$
 1Q�   Interval$ 1Q�$ xx���� $��时间(秒):��$
��Left=�$��	407,4,0,0q�$	��Top=��� -   $��设置��$
��Left=�$��16,49,-3,-77q�$��3��$	��Top=�$��64��$��28��$��1���� -   $��读取��$
��Left=�$��16,13,-3,-41q�$��3��$	��Top=�$��64��$��28��$��1��