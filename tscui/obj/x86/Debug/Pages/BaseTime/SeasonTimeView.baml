   M S B A M L   `   `   `  ����@  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:tscui.Pages.BaseTimetscui.Pages.BaseTime  5      K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM 5      ;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls 5      ?+clr-namespace:Apex.Behaviours;assembly=ApexApex.Behaviours 5
      )    #tscui.Pages.BaseTime.SeasonTimeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:tscui.Pages.BaseTime     5      :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     5      >controls)clr-namespace:Apex.Controls;assembly=Apex     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      <
behaviours+clr-namespace:Apex.Behaviours;assembly=Apex  5
      -   5        $	��700��5   $     Apex.MVVM.View    	ViewModel  5      .   (tscui.Pages.BaseTime.SeasonTimeViewModel  5   
   -   5        seasonTimeViewModel��5   $   .��5        Apex.Controls.ApexGrid  $��
-85,0,0,10q�6   .+�5   
   � .+�5      �� -   5        $��	groupBox3��5   |      tsc_week_week#���   6   $	��329��6@   $
��Left=�6M   $��
179,10,0,0q�6h   $	��Top=�6�   $	��501��6�   .��5      � $��0,0,0,43q�6   .+�5      �� -   5         ��Name$ Thursday��5   �     tsc_week_thu#���  6    $��16��6I   $
��Left=�6U   $��
64,108,0,0q�6p   $	��Top=�6�   6�   �� 5      -   5        $ Saturday��5   �     tsc_week_sat#���  6    $��16��6I   $
��Left=�6U   $��351,108,0,0q�6p   $	��Top=�6�   6�   �� 5      -   5        $ Sunday��5   �     tsc_week_sun#���  6    $��16��6I   $
��Left=�6U   $��
64,166,0,0q�6p   $	��Top=�6�   6�   �� 5      -   5        $ 	Wednesday��5   �     tsc_week_wed#���  6   $��16��6H   $
��Left=�6T   $��
351,55,0,0q�6o   $	��Top=�6�   6�   �� 5      -   5        $ Friday��5   �     tsc_week_fir#���  6    $��16��6I   $
��Left=�6U   $��199,108,0,0q�6p   $	��Top=�6�   6�   �� 5       -	   5        $ Tuesday��5    �     tsc_week_tus#���  6    $��16��6I   $
��Left=�6U   $��
199,55,0,0q�6p   $	��Top=�6�   6�   �� 5!      -
   5        $ Monday��5!   �     tsc_week_mon#���  6   $��16��6H   $
��Left=�6T   $��	64,55,0,0q�6o   $	��Top=�6�   6�   �� 5"      -   5        $ Allday��5"   �     tsc_week_all#���  6   $��16��6H   $
��Left=�6T   $��199,166,0,0q�6o   $	��Top=�6�   6�   5#      5$      �� 5%       	 tsc_week_id#��� 	 6   $
��Left=�6>   $��0,10,0,0q�6Y   $	��Top=�6k   $	��329��6�   $	��174��6�   .��5&      � .+�5'      �� -   5         ��Name$ 	lbxPlanId��5'      $
��Left=�62   $	��Top=�6M   $	��158��6e   $	��307��6q   #��� ��6�    � ContextMenu 5)      �� 5*      .@�5+   "   m� -   5        $
��cmi2��5+   +   $��删除��67   6C   5,      5.      51      52      �� 53      -   5         ��Name$ btnRead��53       
 tsc_time_read#��� 
 6&   $
��Left=�6P   $��412,287,0,0q�6k   $	��Top=�6�   $��75��6�   $y�Hidden=�6�   �� 54      -   5        $ btnSave��54        tsc_SchedulePlan_save#���  6&   $
��Left=�6X   $��	6,416,0,0q�6s   $	��Top=�6�   $��25��6�   $��75��6�   6�   �� 55        tsc_week_schedule#���  6   $
��Left=�6D   $��	0,344,0,0q�6_   $	��Top=�6r   $��50��6�   $	��174��6�   .��56      �� -   5         ��Name$ cbxScheduleId��56      $
��Left=�62   $��27��6M   $	��Top=�6Y   $	��155��6q   6}   57      �� 58      $
��Left=�6   $��189,358,0,0q�63   $
��Wrap=�6H   $	��Top=�6\   $��99��6t   $	��501��6�   #��� ��6�   �� 6�   $��14(�6�   $�周时基操作说明:��6�   �� 6�   �� 6
  $_�Y1. 时基编号框显示的是按周时基号，时基号范围21-30，优先级为②！��6  �� 6;  �� 6G  $���2. 添加新时基须在时基列表框空白处单击鼠标生成新时基号，然后选择右边框的周参数。选中某条时基号后单击鼠标右键可删除选中时基。��6K  �� 6�  �� 59      
���� ��$r�l3. 如果时基编号框对应的时基编号的周参数没有选择任何周则该时基号能予保存。��66   �� 6f   �� 5:      $B�<4. 修改完该页所有时基后点击一次保存即可。��6#   �� 6C   5<      5=      5>      5?      