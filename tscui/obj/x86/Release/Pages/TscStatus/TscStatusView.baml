   M S B A M L   `   `   `  ���� K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:tscui.Pages.Logtscui.Pages.Log b ^DevComponents.WPF.Controls, Version=7.1.0.14, Culture=neutral, PublicKeyToken=ff0069e61369d6d6kLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.ControlsDevComponents.WPF.Controls O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem    tscui.Pages.Log.LogsView2   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     /localclr-namespace:tscui.Pages.Log     aControlsLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.Controls     9System&clr-namespace:System;assembly=mscorlib     -   .��   Apex.Controls.ApexGrid  $��0,0,0,0q�.+��� $��信号机电压��$
��Left=�$��	88,29,0,0q�$	��Top=�$��69��$	��633��$��14(�.���� $��0,0,-2,4q�  �� Orientation$  
Horizontal=�.+��� $��强电电压:��$��12(�$��60��$��0,0,0,10q��� -    ��Name$ LHighVoltage��$��?V��$��12(�$��95��$��0,0,0,10q��� $��弱电电压:��$��12(�$��66��$��0,0,0,10q��� -   $ LWeakVoltage��$��?V��$��12(�$��95��$��0,0,0,10q��� $��总线电压:��$��12(�$��68��$��0,0,0,10q��� -   $ LBusVoltage��$��?V��$��12(�$	��100��$��0,0,0,10q��� $��物理状态��$
��Left=�$��	88,98,0,0q�$	��Top=�$	��330��$	��633��$��14(�.��� $
��Left=�$	��308��$	��Top=�$	��594�� � ColumnDefinitions �� $��* ��� $��* �.+��� $��温度��$��0��$��12(�$
��Left=�$��0,10,0,0q�$	��Top=�$	��241���� -   $ LTemprature��$
��?℃��$��0��$��12(�$
��Left=�$��	85,10,0,0q�$	��Top=�$	��156���� $��散热器状态��$��1��$��12(�$
��Left=�$��
29,136,0,0q�$	��Top=�$	��105���� $��本地报警��$��1��$��12(�$
��Left=�$��	29,94,0,0q�$	��Top=�$	��105���� $��机柜后门��$��1��$��12(�$
��Left=�$��	29,52,0,0q�$	��Top=�$	��114���� $��湿度��$��1��$��12(�$
��Left=�$��	29,10,0,0q�$	��Top=�$��66���� $��机柜前门��$��0��$��12(�$
��Left=�$��0,52,0,0q�$	��Top=�$	��120���� $��本地照明��$��0��$��12(�$
��Left=�$��0,94,0,0q�$	��Top=�$	��241���� $��加热器状态��$��0��$��12(�$
��Left=�$��	0,136,0,0q�$	��Top=�$��74���� $��机柜状态��$��0��$��12(�$
��Left=�$��	0,178,0,0q�$	��Top=�$��74���� $��远程输入口1��$��0��$��12(�$
��Left=�$��	0,220,0,0q�$y�Hidden=�$	��Top=�$��83���� $��远程输出口1��$��0��$��12(�$
��Left=�$��	0,224,0,0q�$	��Top=�$��83���� $��行人按钮��$��1��$��12(�$
��Left=�$��
29,178,0,0q�$	��Top=�$��66���� $��远程输入口2��$��1��$��12(�$
��Left=�$��
29,220,0,0q�$y�Hidden=�$	��Top=�$��81���� $��远程输出口2��$��1��$��12(�$
��Left=�$��
29,224,0,0q�$	��Top=�$��81���� -   $ LWedness��$��?��$��1��$��12(�$
��Left=�$��
148,10,0,0q�$	��Top=�$	��139���� -   $ 
LFrontDoor��$��震动��$��0��$��12(�$
��Left=�$��	85,52,0,0q�$	��Top=�$	��156���� -   $ 	LBackDoor��$��开门��$��1��$��12(�$
��Left=�$��
148,52,0,0q�$	��Top=�$	��139���� -	   $ LLight��$��关闭��$��0��$��12(�$
��Left=�$��	85,94,0,0q�$	��Top=�$	��156���� -
   $ LAlarm��$��关闭��$��1��$��12(�$
��Left=�$��
148,94,0,0q�$	��Top=�$	��139���� -   $ LRaditor��$��关闭��$��1��$��12(�$
��Left=�$��148,136,0,0q�$	��Top=�$	��139���� -   $ LpedestrianBtn��$��无人��$��1��$��12(�$
��Left=�$��148,178,0,0q�$	��Top=�$	��139���� -   $ LRemoteInput2��$��关闭��$��1��$��12(�$
��Left=�$��148,220,0,0q�$y�Hidden=�$	��Top=�$	��139���� -   $ LRemoteImport2��$��关闭��$��1��$��12(�$
��Left=�$��148,224,0,0q�$	��Top=�$	��139���� -   $ LHeter��$��关闭��$��0��$��12(�$
��Left=�$��
85,136,0,0q�$	��Top=�$	��156���� -   $ LShockStatus��$��关闭��$��0��$��12(�$
��Left=�$��
85,178,0,0q�$	��Top=�$	��156���� -   $ LRemoteInput1��$��关闭��$��0��$��12(�$
��Left=�$��
83,220,0,0q�$y�Hidden=�$	��Top=�$	��156���� -   $ LRemoteImport1��$��关闭��$��0��$��12(�$
��Left=�$��
83,224,0,0q�$	��Top=�$	��156���� -    ��Name$ LMonitorBtn��$��开始��$
��Left=�$��326,463,0,0q�$	��Top=�$��28��$��64�� J� RenderTransformOrigin$ 0.434,-0.045&�