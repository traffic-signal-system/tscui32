   M S B A M L   `   `   `  ����K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d?+clr-namespace:Apex.Behaviours;assembly=ApexApex.Behaviours  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:tscui.Pages.BaseTimetscui.Pages.BaseTime 5      3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM  5	      ;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  5
      '   !tscui.Pages.BaseTime.BaseTimeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      FapexBehaviours+clr-namespace:Apex.Behaviours;assembly=Apex     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:tscui.Pages.BaseTime     5      :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     5	      BapexControls)clr-namespace:Apex.Controls;assembly=Apex     5
      -   5           Apex.MVVM.View    	ViewModel  5      ,  &tscui.Pages.BaseTime.BaseTimeViewModel  5   
   -   5        baseTimeViewModel��5   "   .��5         Apex.Controls.ApexGrid  $��0,0,0,10q�6   .+�5   
   �� -   5        $��	groupBox1��5   u   $��0��6      tsc_time_month#���   6#   $	��344��6M   $
��Left=�6Z   $	��Top=�6�   $	��501��6�   $��
189,10,0,0q�6�   .  (System.Windows.Interactivity.Interaction   	Behaviors 5      *   $Apex.Behaviours.SlideFadeInBehaviour  5         	BeginTime$ 0:0:0h�66   .��5      � $��0,0,0,22q�6   .+�5      �� -   5         ��Name$ 
cbxJanuary��5        tsc_time_jan#���  6/   $
��Left=�6X   $��	33,41,0,0q�6s   $	��Top=�6�   6�   �� 5      -   5        $ cbxFebruary��5        tsc_time_feb#���  60   $
��Left=�6Y   $��
139,41,0,0q�6t   $	��Top=�6�   6�   �� 5      -   5        $ cbxMarch��5        tsc_time_mar#���  6-   $
��Left=�6V   $��
255,41,0,0q�6q   $	��Top=�6�   6�   �� 5      -   5        $ cbxApril��5        tsc_time_apr#���  6-   $
��Left=�6V   $��
374,41,0,0q�6q   $	��Top=�6�   6�   �� 5       -   5        $ cbxMay��5         tsc_time_may#���  6+   $
��Left=�6T   $��
33,109,0,0q�6o   $	��Top=�6�   6�   �� 5!      -	   5        $ cbxJune��5!        tsc_time_jun#���  6,   $
��Left=�6U   $��139,109,0,0q�6p   $	��Top=�6�   6�   �� 5"      -
   5        $ cbxJuly��5"        tsc_time_jul#���  6,   $
��Left=�6U   $��255,109,0,0q�6p   $	��Top=�6�   6�   �� 5#      -   5        $ 	cbxAugust��5#        tsc_time_aug#���  6.   $
��Left=�6W   $��374,109,0,0q�6r   $	��Top=�6�   6�   �� 5$      -   5        $ cbxAllMonth��5$       	 tsc_time_all#��� 	 60   $
��Left=�6Y   $��
33,236,0,0q�6t   $	��Top=�6�   6�   �� 5%      -   5        $ cbxSeptember��5%       
 tsc_time_sep#��� 
 61   $
��Left=�6Z   $��
33,172,0,0q�6u   $	��Top=�6�   6�   �� 5&      -   5        $ 
cbxOctober��5&        tsc_time_oct#���  6/   $
��Left=�6X   $��139,172,0,0q�6s   $	��Top=�6�   6�   �� 5'      -   5        $ cbxNovember��5'        tsc_time_nov#���  60   $
��Left=�6Y   $��255,172,0,0q�6t   $	��Top=�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5(      V� 5)      .~�5*      �� �� 5+      �� 5,       �� Angle$ -0.992Q�6.   T� 5-      5.      50      �� 51      -   5        $ cbxDecember��51        tsc_time_Dec#���  60   $
��Left=�6Y   $��374,172,0,0q�6t   $	��Top=�6�   $ 0.5,0.5&�6�   z�52      V� 53      .~�54      �� �� 55      �� 56      $ -0.992Q�6.   T� 57      58      5:      �� 5;      -   5         ��Name$ btnRead��5;        tsc_time_read#���  6*   $
��Left=�6T   $��145,264,0,0q�6o   $	��Top=�6�   $��75��6�   $y�Hidden=�6�   5=      5>      �� 5?   
     tsc_time_id#���  6   $
��Left=�6:   $	��Top=�6U   $	��344��6m   $	��174��6z   $��	10,10,0,0q�6�   .��5@      � $��	0,0,-2,14q�6   .+�5A      �� -   5         ��Name$ 	lbxPlanId��5A      $
��Left=�6-   $	��323��6H   $	��Top=�6U   $	��158��6m   $��	0,0,0,-15q�6�   #��� ��6�    � ContextMenu 5C      �� 5D      .@�5E      m� -   5        $
��cmi2��5E   '   $��删除��63   6?   5F      5H      5I      5J      �� 5K   
     tsc_time_schedule#���  6   $
��Left=�6@   $��
10,354,0,0q�6[   $	��Top=�6o   $��50��6�   $	��174��6�   .��5L      �� -   5        	 ��Name$	 cbxScheduleId��5L      $
��Left=�6.   $��0,2,0,-1q�6I   $	��Top=�6[   $	��155��6s   $��27��6   6�   5M      �� 5N   
   -   5        $ btnSave��5N        tsc_SchedulePlan_save#���  6"   $
��Left=�6T   $��
10,425,0,0q�6o   $	��Top=�6�   $��25��6�   $��75��6�   6�   �� 5O   
   $
��Left=�6   $��189,367,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $	��101��6p   $	��501��6}   #��� ��6�   �� 5P      $��14(�6   $�按月时基操作说明:��6    �� 63   �� 5Q      $k�e1. 时基编号列表框显示的是按月时基号，时基号范围31-40，优先级为③最低！��6   �� 6C   �� 5R      $���2. 添加新时基须在时基列表框空白处单击鼠标生成新时基号，然后选择右边的月参数。选中某条时基号后单击鼠标右键可删除选中时基。��6   �� 6Z   �� 5S      
���� ��$u�o3. 如果时基编号框对应的时基编号的月份参数未选择任何月份则该时基号不能保存。��6&   �� 6W   �� 5T      $B�<4. 修改完该页所有时基后点击一次保存即可。��6   �� 62   �� 5V      6   5X      5Y      