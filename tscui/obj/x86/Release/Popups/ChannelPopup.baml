   M S B A M L   `   `   `  ���� K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  	 tscui   tscui.Views.ChannelPopup   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     $	��500��$	��700��.��� $��20q�.+���    ZuneColor1Brush#��[  $��1q�
�������._�   Apex.Controls.ApexGrid  $��20,16,20,20q�    Rows$  Auto,Auto,*,Auto��.+��� $��0��$��7��$	��100��$
��Left=�$	��Top=����� .���  � Offset$ 0Q�  
ZuneColor2 � Color# [ � $ 1Q�  
ZuneColor1# [ �� $��Segoe UI)�$��28(�$��37��$��0,6,0,0q�$	��Top=�通道选择�� $��3��$��Right=� �� Orientation$ 
Horizontal=�  ZuneDarkGrayBrush#��[ $
��Bold"�.+��� -    ��Name$ 	button_OK��$��80��$��28��$��0,0,12,0q�$��OK���� -   $ button_Cancel��$��80��$��28��$��CANCEL���� -   $��	groupBox1��$��通道选择��$	��378��$
��Left=�$��2,44,0,0q�$	��Top=�$	��167���� -   $��	groupBox2��$��通道属性��$	��344��$
��Left=�$��340,38,-164,0q�$	��Top=�$	��442��.��� .+��� -   $��stackPanel3��$	��224��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��200��.+��� -   $��stackPanel4��$��29��$ 
Horizontal=�$	��200��.+��� -   $��label11��$��通道号    ：��$��28���� -   $��cbxId��$��23��$	��120���� -	   $��stackPanel5��$��28��$ 
Horizontal=�$	��200��.+��� -
   $��label12��$��相        位：��$��28���� -   $��tbxSourcePhase��$��23��$	��120���� -   $��stackPanel6��$��31��$ 
Horizontal=�$	��200��.+��� -   $��label13��$��相位类型：��$��28���� -   $��cbxType��$��23��$	��120���� -   $��stackPanel7��$��34��$ 
Horizontal=�$	��200��.+��� -   $��label14��$��闪光交替：��$��28��	� -   $��rbnFirstHalf��$��前半秒亮��$��16�� 	� 	GroupName$ grbFlashAuto�� d� 	IsChecked$
 TrueY�	� -   $��rbnSecondHalf��$��后半秒亮��$��16��$ grbFlashAuto���� -   $��stackPanel12��$��34��$ 
Horizontal=�$	��200��.+��� -   $��label15��$��闪烁模式：��$��28��	� -   $��radioButton1��$��黄闪��$��16��$
 TrueY�	� -   $��radioButton3��$��红闪��$��16��	� -   $��radioButton2��$��关灯��$��16���� -   $��stackPanel1��$	��321��$
��Left=�$��	10,61,0,0q�$	��Top=�$��70��.+�	� -   $��rbnChannel1��$ channel��$��C1��$��18(�	� -   $��rbnChannel2��$ channel��$��C2��$��18(�	� -   $��rbnChannel3��$ channel��$��C3��$��18(�	� -   $��rbnChannel4��$ channel��$��C4��$��18(�	� -   $��rbnChannel5��$ channel��$��C5��$��18(�	� -   $��rbnChannel6��$ channel��$��C6��$��18(�	� -   $��rbnChannel7��$ channel��$��C7��$��18(�	� -    $��rbnChannel8��$ channel��$��C8��$��18(�	� -!   $��rbnChannel9��$ channel��$��C9��$��18(�	� -"   $��rbnChannel10��$ channel��$	��C10��$��18(�	� -#    	�Name$ rbnChannel12��$ channel��$	��C12��$��18(� J� RenderTransformOrigin$ 1.596,-1.464&�	� -$   $��rbnChannel11��$ channel��$	��C11��$��18(�	� -%   $ rbnChannel13��$ channel��$	��C13��$��18(�$��174,393,322,-23q�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,379q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,304q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,304q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,304q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,346q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,266q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,233q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,195q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,162q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��240,0,0,124q����	#FF2E570D$ 1.007,1.267&�A� $
��Left=�$��33��$��Bottom=�$��31��$��
240,0,0,86q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��
240,0,0,48q����	#FF7AEE1A$ 1.007,1.267&�A� $
��Left=�$��33��
���   �$��Bottom=�$��31��$��
240,0,0,10q����	#FF7AEE1A$ 1.007,1.267&�