   M S B A M L   `   `   `  ���� K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  ?+clr-namespace:Apex.Behaviours;assembly=ApexApex.Behaviours  	 tscui)   #tscui.Pages.Calendar2.Calendar2View   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  <
Behaviours+clr-namespace:Apex.Behaviours;assembly=Apex  -   $	��880��.��   Apex.Controls.ApexGrid  $	��880��  � ColumnDefinitions  �� �� $��0* � � RowDefinitions �� $��0* ��� .+���    tsc_calendar_schedule#���   $
��Left=�$��
-4,425,0,0q�$	��Top=�$��50��$	��181��$��1��.���� -    ��Name$ cbxScheduleId��$
��Left=�$	��Top=�$	��155��$��27���� -    ��Name$ 
Monthgroup��$��0��  tsc_time_month#���  $	��183��$
��Left=�$	��Top=�$	��661��$��
182,10,0,0q�$��1��.  (System.Windows.Interactivity.Interaction   	Behaviors *   $Apex.Behaviours.SlideFadeInBehaviour     	BeginTime$ 0:0:0h�.��� -    �Name$ 	MonthGrid��$��0,25,-12,11q�.+��� -    ��Name$
 Mon1��  tsc_time_jan#���  $
��Left=�$��28,6,0,0q�$	��Top=�$��51���� -   $
 Mon2��  tsc_time_feb#���  $
��Left=�$��	116,6,0,0q�$	��Top=�$��51���� -   $
 Mon3��  tsc_time_mar#���  $
��Left=�$��	197,6,0,0q�$	��Top=�$��57���� -   $
 Mon4��  tsc_time_apr#���  $
��Left=�$��	275,6,0,0q�$	��Top=� J� RenderTransformOrigin$ 3.206,0.438&�$��47���� -	   $
 Mon5��  tsc_time_may#���  $
��Left=�$��	353,6,0,0q�$	��Top=�$��55���� -
   $
 Mon6��  tsc_time_jun#���  $
��Left=�$��	439,6,0,0q�$	��Top=�$��53���� -   $
 Mon7��  tsc_time_jul#���  $
��Left=�$��	522,6,0,0q�$	��Top=�$��54���� -   $
 Mon8�� 	 tsc_time_aug#��� 	 $
��Left=�$��	603,6,0,0q�$	��Top=�$��48���� -   $ Monall�� 
 tsc_time_all#��� 
 $
��Left=�$��
353,61,0,0q�$	��Top=��� -   $
 Mon9��  tsc_time_sep#���  $
��Left=�$��	28,61,0,0q�$	��Top=�$��51��$ 0.5,0.5&��� -   $ Mon10��  tsc_time_oct#���  $
��Left=�$��
116,61,0,0q�$	��Top=�$��51���� -   $ Mon11��  tsc_time_nov#���  $
��Left=�$��
197,61,0,0q�$	��Top=�$��57���� -   $ Mon12��  tsc_time_Dec#���  $
��Left=�$��
275,61,0,0q�$	��Top=�$��56���� -   $ DayGroup��$��0��$��日期��$	��227��$
��Left=�$	��Top=�$	��661��$��182,198,0,0q�$��1��   $ 0:0:0h�.��� -   $ DayGrid��$��0,3,8,11q�.+��� -   $
 day1��$��1��$
��Left=�$��31,3,0,0q�$	��Top=��� -   $
 day2��$��2��$
��Left=�$��	115,4,0,0q�$	��Top=��� -   $
 day3��$��3��$
��Left=�$��	200,4,0,0q�$	��Top=��� -   $
 day4��$��4��$
��Left=�$��	278,4,0,0q�$	��Top=��� -   $
 day5��$��5��$
��Left=�$��	359,4,0,0q�$	��Top=��� -   $
 day6��$��6��$
��Left=�$��	443,4,0,0q�$	��Top=��� -   $
 day7��$��7��$
��Left=�$��	528,4,0,0q�$	��Top=��� -   $
 day8��$��8��$
��Left=�$��	606,4,0,0q�$	��Top=��� -   $ day11��$��11��$
��Left=�$��
200,44,0,0q�$	��Top=��� -   $
 day9��$��9��$
��Left=�$��	31,44,0,0q�$	��Top=��� -   $ day10��$��10��$
��Left=�$��
115,44,0,0q�$	��Top=��� -   $ day12��$��12��$
��Left=�$��
278,44,0,0q�$	��Top=��� -    $ day13��$��13��$
��Left=�$��
359,44,0,0q�$	��Top=��� -!   $ day14��$��14��$
��Left=�$��
443,44,0,0q�$	��Top=��� -"   $ day15��$��15��$
��Left=�$��
528,44,0,0q�$	��Top=��� -#   $ day16��$��16��$
��Left=�$��
606,44,0,0q�$	��Top=��� -$   $ day17��$��17��$
��Left=�$��
32,85,-0,0q�$	��Top=�$��36���� -%   $ day18��$��18��$
��Left=�$��
116,85,0,0q�$	��Top=��� -&   $ day19��$��19��$
��Left=�$��
201,85,0,0q�$	��Top=��� -'   $ day20��$��20��$
��Left=�$��
279,85,0,0q�$	��Top=��� -(   $ day21��$��21��$
��Left=�$��
360,85,0,0q�$	��Top=��� -)   $ day22��$��22��$
��Left=�$��
444,85,0,0q�$	��Top=��� -*   $ day23��$��23��$
��Left=�$��
529,85,0,0q�$	��Top=��� -+   $ day24��$��24��$
��Left=�$��
606,85,0,0q�$	��Top=��� -,   $ day25��$��25��$
��Left=�$��
32,129,0,0q�$	��Top=��� --   $ day26��$��26��$
��Left=�$��116,129,0,0q�$	��Top=�$	��104���� -.   $ day27��$��27��$
��Left=�$��201,129,0,0q�$	��Top=��� -/   $ day28��$��28��$
��Left=�$��279,129,0,0q�$	��Top=��� -0   $ day29��$��29��$
��Left=�$��360,129,0,0q�$	��Top=��� -1   $ day30��$��30��$
��Left=�$��444,129,0,0q�$	��Top=��� -2   $ day31��$��31��$
��Left=�$��529,129,0,0q�$	��Top=��� -3   $ dayall��#��� 
 $
��Left=�$��196,172,0,0q�$	��Top=��� -4   $ 
dayasingle��$��单号��$
��Left=�$��
32,172,0,0q�$	��Top=��� -5   $ dayalldouble��$��双号��$
��Left=�$��116,172,0,0q�$	��Top=��� -6   	 ��Name$	 btnSave��  tsc_SchedulePlan_save#���  $
��Left=�$��25��$��
-1,492,0,0q�$	��Top=�$��75��$��1����   tsc_time_id#���  $
��Left=�$	��Top=�$	��415��$	��174��$��3,10,0,0q�$��1��.��� $��
0,0,-2,-12q�.+��� -7   
 ��Name$
 	lbxPlanId��$
��Left=�$	��390��$	��Top=�$	��158��$��	0,0,0,-72q� J� 	AllowDrop . #��� �� J� IsManipulationEnabled .  � ContextMenu �� .@�m� -8   $
��cmi2��$��删除���� $
��Left=�$��182,434,0,0q�$
��Wrap=�$	��Top=�$��83��$	��661��#��� ��$��2���� $��14(�$(�"按特殊月日时基操作说明:���� �� $s�m1. 时基编号列表框显示的是按特殊月日时基号，时基号范围1-20，优先级为①最高！���� �� $���2. 添加新时基须在时基列表框空白处单击鼠标生成新时基号，然后选择右边的月日参数。选中某条时基号后单击鼠标右键可删除选中时基。���� �� 
���� ��$���3. 如果时基编号框对应的时基编号的月份参数未选择任何月份或者日参数未选择任何日则该时基号不能保存。���� �� $B�<4. 修改完该页所有时基后点击一次保存即可。���� 