   M S B A M L   `   `   `  ���� @  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:tscui.Pages.Schedulestscui.Pages.Schedules  K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM (    "tscui.Pages.Schedules.ScheduleView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:tscui.Pages.Schedules     :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     -   $	��610��  Apex.MVVM.View    	ViewModel  -   'tscui.Pages.Schedules.ScheduleViewModel  -   scheduleViewModel��.��� $��0,45,0,0q�.+�&   System.Windows.Controls.DataGrid  -     Name$ scheduleDataGrid��$
��Left=� �� AlternationCount$ 2��   CanUserAddRows .     AutoGenerateColumns .  $	��Top=�$	��516��$	��870��$��	10,30,0,0q�   HorizontalGridLinesBrush �	#FF533B3B   RowBackground �	#FF63C379 � ContextMenu �� .@�m� -   $��ScheduleContext��$��删除��   	CellStyle �� 	 �� 
TargetType*  $System.Windows.Controls.DataGridCell"	  .��� 
 �� Property
 �@^�ToolTip �� Value$. (时段序号非0时不能重复,最大48��   Columns 0  *System.Windows.Controls.DataGridTextColumn  -   Id��   tsc_schedule_id,  &System.Windows.Controls.DataGridColumn   Header# �      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90    SortDirection$ 	AscendingX�   CanUserSort .  1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ucEventId+4	  .System.Windows.Controls.DataGridTemplateColumn	    tsc_schedule_time# �  $	 200  	  CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� ����  �� Path$ ucHour��� $	�� : ���� ���� $ ucMin� 	  CellEditingTemplate �� .R��� $ 
Horizontal=�.+��� ���� *ucHour+�� $	�� : ���� ���� *ucMin+4
  .System.Windows.Controls.DataGridComboBoxColumn
  -   	cbxucCtrl��$	 220   tsc_schedule_control_mode# �     
IsReadOnly .   
  SelectedValuePath$ value�� 
  DisplayMemberPath$
 name�� .   
  SelectedValueBinding �� *ucCtrl+
  -   ucTimePatternId��$ *   tsc_schedule_partten_sheme# �  $ ucPatternId��$ ucPatternId�� .   �� *ucTimePatternId+��   tsc_schedule_title#���  $
��Left=�$��
10,-47,0,0q�$	��Top=�$��52��$	��870��$��3��.��� .+��� -    ��Name$ sldScheduleId��$
��Left=�$��4,4,0,0q� � Value$ 1Q� � SmallChange$ 1Q� � Minimum$ 1Q� � Maximum$ 16Q� �� IsSnapToTickEnabled . $	��Top=�$	��749��  �� TickPlacement$  BottomRight=�! �� AutoToolTipPlacement$! BottomRight=��� -	   " ��Name$" tbkScheduleId��$
��Left=�$��	754,6,0,0q�$
��Wrap=�$	��Top=�$��25��  ZuneColor1Brush#���  ���� # �� ElementName$# sldScheduleId��$ Value��� -
     tsc_time_schedule_save#���  $
��Left=�$��	783,4,0,0q�$	��Top=�$��75���� $����1            2             3             4             5             6             7             8              9            10           11           12           13           14            15          16��$
��Left=�$��19,5,0,0q�$	��851��$��25��$	��Top=�