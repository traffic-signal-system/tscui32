   M S B A M L   `   `   `  ���� K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d?+clr-namespace:Apex.Behaviours;assembly=ApexApex.Behaviours  c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:tscui.Pages.BaseTimetscui.Pages.BaseTime 3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM  ;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  '   !tscui.Pages.BaseTime.BaseTimeView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     FapexBehaviours+clr-namespace:Apex.Behaviours;assembly=Apex     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     @d2http://schemas.microsoft.com/expression/blend/2008     4local"clr-namespace:tscui.Pages.BaseTime     :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     -      Apex.MVVM.View    	ViewModel  ,  &tscui.Pages.BaseTime.BaseTimeViewModel  -   baseTimeViewModel��.��   Apex.Controls.ApexGrid  $��0,0,0,10q�.+��� -   $��	groupBox1��$��0��   tsc_time_month#���   $	��344��$
��Left=�$	��Top=�$	��501��$��
189,10,0,0q�.  (System.Windows.Interactivity.Interaction   	Behaviors *   $Apex.Behaviours.SlideFadeInBehaviour     	BeginTime$ 0:0:0h�.��� $��0,0,0,22q�.+��� -    ��Name$ 
cbxJanuary��  tsc_time_jan#���  $
��Left=�$��	33,41,0,0q�$	��Top=��� -   $ cbxFebruary��  tsc_time_feb#���  $
��Left=�$��
139,41,0,0q�$	��Top=��� -   $ cbxMarch��  tsc_time_mar#���  $
��Left=�$��
255,41,0,0q�$	��Top=��� -   $ cbxApril��  tsc_time_apr#���  $
��Left=�$��
374,41,0,0q�$	��Top=��� -   $ cbxMay��  tsc_time_may#���  $
��Left=�$��
33,109,0,0q�$	��Top=��� -	   $ cbxJune��  tsc_time_jun#���  $
��Left=�$��139,109,0,0q�$	��Top=��� -
   $ cbxJuly��  tsc_time_jul#���  $
��Left=�$��255,109,0,0q�$	��Top=��� -   $ 	cbxAugust��  tsc_time_aug#���  $
��Left=�$��374,109,0,0q�$	��Top=��� -   $ cbxAllMonth�� 	 tsc_time_all#��� 	 $
��Left=�$��
33,236,0,0q�$	��Top=��� -   $ cbxSeptember�� 
 tsc_time_sep#��� 
 $
��Left=�$��
33,172,0,0q�$	��Top=��� -   $ 
cbxOctober��  tsc_time_oct#���  $
��Left=�$��139,172,0,0q�$	��Top=��� -   $ cbxNovember��  tsc_time_nov#���  $
��Left=�$��255,172,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ -0.992Q�T� �� -   $ cbxDecember��  tsc_time_Dec#���  $
��Left=�$��374,172,0,0q�$	��Top=�$ 0.5,0.5&�z�V� .~��� �� �� $ -0.992Q�T� �� -    ��Name$ btnRead��  tsc_time_read#���  $
��Left=�$��145,264,0,0q�$	��Top=�$��75��$y�Hidden=���   tsc_time_id#���  $
��Left=�$	��Top=�$	��344��$	��174��$��	10,10,0,0q�.��� $��	0,0,-2,14q�.+��� -    ��Name$ 	lbxPlanId��$
��Left=�$	��323��$	��Top=�$	��158��$��	0,0,0,-15q�#��� �� � ContextMenu �� .@�m� -   $
��cmi2��$��删除����   tsc_time_schedule#���  $
��Left=�$��
10,354,0,0q�$	��Top=�$��50��$	��174��.���� -   	 ��Name$	 cbxScheduleId��$
��Left=�$��0,2,0,-1q�$	��Top=�$	��155��$��27���� -   $ btnSave��  tsc_SchedulePlan_save#���  $
��Left=�$��
10,425,0,0q�$	��Top=�$��25��$��75���� $
��Left=�$��189,367,0,0q�$
��Wrap=�$	��Top=�$	��101��$	��501��#��� ���� $��14(�$�按月时基操作说明:���� �� $k�e1. 时基编号列表框显示的是按月时基号，时基号范围31-40，优先级为③最低！���� �� $���2. 添加新时基须在时基列表框空白处单击鼠标生成新时基号，然后选择右边的月参数。选中某条时基号后单击鼠标右键可删除选中时基。���� �� 
���� ��$u�o3. 如果时基编号框对应的时基编号的月份参数未选择任何月份则该时基号不能保存。���� �� $B�<4. 修改完该页所有时基后点击一次保存即可。���� �� 