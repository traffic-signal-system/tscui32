   M S B A M L   `   `   `  ���� @  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:tscui.Pages.Configtscui.Pages.Config  K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM ;)clr-namespace:Apex.Commands;assembly=ApexApex.Commands ;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls ?+clr-namespace:Apex.Converters;assembly=ApexApex.Converters #    tscui.Pages.Config.ConfigView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:tscui.Pages.Config     :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     BapexCommands)clr-namespace:Apex.Commands;assembly=Apex     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     FapexConverters+clr-namespace:Apex.Converters;assembly=Apex     X TXceed.Wpf.Toolkit, Version=2.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  -   $	��603��$	��862��  Apex.MVVM.View    	ViewModel  (   "tscui.Pages.Config.ConfigViewModel  -   	viewModel��.��� $��	0,0,62,25q�.+��� -    ��Name$ 	groupBox7��$y�Hidden=�$��防盗版生成序号��$	��111��$
��Left=�$��
34,467,0,0q�$	��Top=�$	��200��.��� .+��� -    ��Name$ label17��$*��$为了防止盗用信号机软件：��$��28��$
��Left=�$��1,1,0,0q�$	��Top=��� -    ��Name$ 
btnBuildSN��$��生成序号��$��30��$
��Left=�$��
103,49,0,0q�$	��Top=�$��75������ *BuildSNCommand+��    tsc_config_special#���   $
��Left=�$��
333,0,-1,0q�$	��Top=�$	��560��$	��468��.��� $
��Left=�$	��538��$	��Top=�$	��456����   tsc_config_timing#���  $
��Left=�$��34,0,0,0q�$	��Top=�$	��143��$	��276��.��� $��0,0,0,4q�.+�&   Xceed.Wpf.Toolkit.DateTimePicker  -     Name$ 	dtpTiming��$
��Left=�$��25��$��	40,29,0,0q�$	��Top=�$	��182���� -   $ 	btnTiming��#���  $
��Left=�$��23��$��	20,84,0,0q�$	��Top=�$��55���� $��34��$��
5,26,224,0q�$	��Top=�$6��0/tscui;component/Resources/Images/time_clock.png�� J� RenderTransformOrigin$ 2.243,0.235&��� -    ��Name$ 	Manualchk��$��手动��$
��Left=�$��224,35,-1,0q�$	��Top=��� -	   $ 
BtnGetTime��  tsc_adv_btn_read#���  $
��Left=�$��23��$��
115,84,0,0q�$	��Top=�$��55����   tsc_restart_desc#���  $
��Left=�$��
34,148,0,0q�$	��Top=�$��98��$	��276��.��� $��0,0,0,6q�.+��� -
   $ 
btnTiming1��  tsc_restart#���  $
��Left=�$��23��$��	22,41,0,0q�$	��Top=�$��55��$ 0.436,-2.261&���   tsc_network_config#���  $
��Left=�$��
34,251,0,0q�$	��Top=�$	��200��$	��276��.��� $��0,0,0,6q�.+��� -   $ 
btnTiming2��  tsc_adv_btn_ok#���  $
��Left=�$��23��$��
21,138,0,0q�$	��Top=�$��55��$ 0.436,-2.261&��� $��IP��$
��Left=�$��2,10,0,0q�$	��Top=�$ 0.35,-0.346&��� $��子网掩码��$
��Left=�$��1,41,0,0q�$	��Top=�$ 0.069,-0.154&��� $��网关��$
��Left=�$��3,72,0,0q�$	��Top=��� -    ��Name$ ip��$
��Left=�$��23��$��	62,10,0,0q� �� TextWrapping$
 Wrap=�$��192.168.1.10��$	��Top=�$	��120���� -   $ netmask��$
��Left=�$��23��$��	62,44,0,0q�$
 Wrap=�$	��Top=�$	��120���� -   $ gateway��$
��Left=�$��23��$��	62,75,0,0q�$
 Wrap=�$	��Top=�$	��120���� $0��*备注:不需要修改的参数,请留空!��$��	3,103,5,0q�$	��Top=�$��26���� $��信号机数据重置��$
��Left=�$��
34,459,0,0q�$	��Top=�$	��101��$	��276��.��� $��0,0,0,6q�.+��� -   $ 
btnTiming3��#���  $
��Left=�$��23��$��	23,46,0,0q�$	��Top=�$��55��$ 0.436,-2.261&��� $/��)注意:重置成功后信号机会重启!��$��	0,15,28,0q�$	��Top=�$��26��