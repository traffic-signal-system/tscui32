   M S B A M L   `   `   `  ���� @  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:tscui.Pages.BaseTimetscui.Pages.BaseTime  K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM ;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls ?+clr-namespace:Apex.Behaviours;assembly=ApexApex.Behaviours )    #tscui.Pages.BaseTime.SeasonTimeView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:tscui.Pages.BaseTime     :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     >controls)clr-namespace:Apex.Controls;assembly=Apex     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  <
behaviours+clr-namespace:Apex.Behaviours;assembly=Apex  -   $	��700��  Apex.MVVM.View    	ViewModel  .   (tscui.Pages.BaseTime.SeasonTimeViewModel  -   seasonTimeViewModel��.��  Apex.Controls.ApexGrid  $��
-85,0,0,10q�.+�� .+��� -   $��	groupBox3��   tsc_week_week#���   $	��329��$
��Left=�$��
179,10,0,0q�$	��Top=�$	��501��.��� $��0,0,0,43q�.+��� -    ��Name$ Thursday��  tsc_week_thu#���  $��16��$
��Left=�$��
64,108,0,0q�$	��Top=��� -   $ Saturday��  tsc_week_sat#���  $��16��$
��Left=�$��351,108,0,0q�$	��Top=��� -   $ Sunday��  tsc_week_sun#���  $��16��$
��Left=�$��
64,166,0,0q�$	��Top=��� -   $ 	Wednesday��  tsc_week_wed#���  $��16��$
��Left=�$��
351,55,0,0q�$	��Top=��� -   $ Friday��  tsc_week_fir#���  $��16��$
��Left=�$��199,108,0,0q�$	��Top=��� -	   $ Tuesday��  tsc_week_tus#���  $��16��$
��Left=�$��
199,55,0,0q�$	��Top=��� -
   $ Monday��  tsc_week_mon#���  $��16��$
��Left=�$��	64,55,0,0q�$	��Top=��� -   $ Allday��  tsc_week_all#���  $��16��$
��Left=�$��199,166,0,0q�$	��Top=���  	 tsc_week_id#��� 	 $
��Left=�$��0,10,0,0q�$	��Top=�$	��329��$	��174��.��� .+��� -    ��Name$ 	lbxPlanId��$
��Left=�$	��Top=�$	��158��$	��307��#��� �� � ContextMenu �� .@�m� -   $
��cmi2��$��删除���� -    ��Name$ btnRead�� 
 tsc_time_read#��� 
 $
��Left=�$��412,287,0,0q�$	��Top=�$��75��$y�Hidden=��� -   $ btnSave��  tsc_SchedulePlan_save#���  $
��Left=�$��	6,416,0,0q�$	��Top=�$��25��$��75����   tsc_week_schedule#���  $
��Left=�$��	0,344,0,0q�$	��Top=�$��50��$	��174��.���� -    ��Name$ cbxScheduleId��$
��Left=�$��27��$	��Top=�$	��155���� $
��Left=�$��189,358,0,0q�$
��Wrap=�$	��Top=�$��99��$	��501��#��� ���� $��14(�$�周时基操作说明:���� �� $_�Y1. 时基编号框显示的是按周时基号，时基号范围21-30，优先级为②！���� �� $���2. 添加新时基须在时基列表框空白处单击鼠标生成新时基号，然后选择右边框的周参数。选中某条时基号后单击鼠标右键可删除选中时基。���� �� 
���� ��$r�l3. 如果时基编号框对应的时基编号的周参数没有选择任何周则该时基号能予保存。���� �� $B�<4. 修改完该页所有时基后点击一次保存即可。���� 