   M S B A M L   `   `   `  ����K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  5      @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:tscui.Pages.Logtscui.Pages.Log 5         tscui.Pages.Log.LogsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      BapexControls)clr-namespace:Apex.Controls;assembly=Apex     5      /localclr-namespace:tscui.Pages.Log     5      -   5        .��5         Apex.Controls.ApexGrid  $��0,0,0,0q�6       Rows$(  "Auto,Auto,Auto,Auto,Auto,Auto,Auto��5   	   $	��800��63   .+�5   
   �� -   5        $��splLog��5   =   $	��545��6   $
��Left=�6"   $	��Top=�6K   $	��800��6c   $��0,0,0,0q�6p   .+�5      �� -   5         ��Name$ 	btnGetLog��5         tsc_log_reread#���   6(   6S   �� 5      -   5         ��Name$ Loglistview��5       �� AlternationCount$ 2��6,   $	��494��6A   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ��ح�67    �� Triggers 5      P� 5       P� Property �@��AlternationIndex	 P� Value$	 1��6K   . �5   "   ��  � ��
 ����6?   5      5      
 �� View
 5       �� 5!      .P�5"      �� -   5        ListViewLogId�� �� Width$ 55��5"   @   $��日志编号��6K   $  tscui.Pages.Log.ListViewHelper   SortProperty$ 	ucEventId��6Y    �� DisplayMemberBinding 6�   �� *	ucEventId+ �� Mode$ OneWay=��� 5#      -   5        ListViewLogType��$
 Auto��5#   B   $��日志类型��6P   $ 
sEventType��6^    6�   �� *
sEventType+$ OneWay=��� 5$      -   5        ListViewLogTime��$
 Auto��5$   B   $��日志时间��6O   $ ulEventTime��6]    6�   �� *ulEventTime+$ OneWay=��� 5%      -   5        ListViewLogContent��$
 Auto��5%   E   $��日志内容��6R    6`   �� *
sEventDesc+$ OneWay=�5&      5(      5)      �� 5*   
   -	   5          tsc_log_del#���  5*      $
��Left=�69   $��130,550,0,0q�6T   $	��Top=�6i   $	��106��6�   6�   �� 5+   
   -
   5          tsc_log_local#���  5+      $
��Left=�6;   $��363,550,0,0q�6V   $	��Top=�6k   $	��106��6�   6�   �� 5,   
   -   5          tsc_log_export#���  5,      $
��Left=�6<   $��588,550,0,0q�6W   $	��Top=�6l   $	��106��6�   6�   5-      5/      