   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d?+clr-namespace:Apex.Behaviours;assembly=ApexApex.Behaviours 5      ;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls 5      @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tscui.ViewModelstscui.ViewModels 5	         tscui.Views.ModuleView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      FapexBehaviours+clr-namespace:Apex.Behaviours;assembly=Apex     5      BapexControls)clr-namespace:Apex.Controls;assembly=Apex     5      0localclr-namespace:tscui.ViewModels     5	      $	��900��5   #     � DataContext  5      &   tscui.ViewModels.ModuleViewModel  5   
   -   5        	viewModel��5       .��5      �� $��	10,10,0,4q�6   $��Disabled=�6&   $
��Auto=�6O   .��5   
     Apex.Controls.ApexGrid  $��0,0,0,0q�6!      Rows$ Auto,Auto,*,Auto��62   
������ $	��833��6c    � ColumnDefinitions 5      �� 5      $
��637* �6#   �� 5      $
��179* �6#   �� 5      $��0* �6#   �� 5      $	��17* �6#   .+�5      �� $��总线模块��6   $
��Left=�6%   $	��Top=�6@   $	��823��6X   $	��537��6d   $��4��6q   #��� ��6�   .��5      � $��0,0,-12,-12q�6   .+�5      �� -   5         ��Name$ gbxMain��5      $��	主控板��60   $
��Left=�6=   $	��Top=�6X   $	��427��6p   $��47��6|   $��0,10,0,0q�6�   .��5      � $
��Left=�6   $��30��6:   $	��Top=�6F   $	��427��6^   $��0,0,-12,-12q�6j   .+�5      �� $'��!备份主控板      地址: 0x11��6$   $
��Left=�6B   $	��Top=�6]   $	��164��6u   �� 5      -   5         ��Name$ MainBackOnline��5   4   $��在线��6'   $
��Left=�6L   $��	373,5,0,0q�6g   $	��Top=�6z   {�.  6�   �� 5      -   5         ��Name$ MainBackver��5   2   $��版本:��6$   $
��Left=�6G   $��	210,0,0,0q�6b   $	��Top=�6u   $	��143��6�   5       5!      �� 5"      -   5        $ gbxMain_Copy��5"      $��液晶控制器��65   $
��Left=�6D   $	��Top=�6_   $	��427��6w   $��57��6�   $��0,62,0,0q�6�   .��5#      � $
��Left=�6   $��30��6:   $	��Top=�6F   $	��427��6^   $��0,0,-12,-12q�6j   .+�5$      �� $'��!标配控制器      地址: 0x31��6$   $
��Left=�6B   $	��Top=�6]   $	��164��6u   �� 5%      -   5        $ MacctrolOnline��5%   4   $��在线��6'   $
��Left=�6L   $��	373,5,0,0q�6g   $	��Top=�6z   {�.  6�   �� 5&      -   5        $ Macctrolver��5&   2   $��版本:��6$   $
��Left=�6G   $��	210,0,0,0q�6b   $	��Top=�6u   $	��146��6�   5'      5(      �� 5)      -   5        $ gbxMain_Copy1��5)      $��	黄闪器��66   $
��Left=�6C   $	��Top=�6^   $	��427��6v   $��47��6�   $��	0,124,0,0q�6�   .��5*      � $
��Left=�6   $��56��6:   $	��Top=�6F   $	��427��6^   $��0,0,-12,-38q�6j   .+�5+      �� $'��!标配黄闪器      地址: 0x2E��6$   $
��Left=�6B   $	��Top=�6]   $	��156��6u   �� 5,      -	   5        $ FlashOnline��5,   4   $��在线��6'   $
��Left=�6I   $��	374,0,0,0q�6d   $	��Top=�6w   {�.  6�   �� 5-      -
   5        $ FlashVer��5-   2   $��版本:��6$   $
��Left=�6D   $��	210,1,0,0q�6_   $	��Top=�6r   $	��158��6�   5.      5/      �� 50      -   5        $ gbxMain_Copy2��50      $��灯条��66   $
��Left=�6B   $	��Top=�6]   $	��427��6u   $��56��6�   $��	0,176,0,0q�6�   .��51      � $
��Left=�6   $��30��6:   $	��Top=�6F   $	��417��6^   $��
0,0,-2,-12q�6j   .+�52      �� $'��!显示灯条         地址: 0x32��6$   $
��Left=�6D   $	��Top=�6_   $	��164��6w   �� 53      -   5        $ MainBoardLedOnline��53   5   $��在线��6'   $
��Left=�6Q   $��	374,6,0,0q�6l   $	��Top=�6   {�.  6�   �� 54      -   5        $ MainBoardLed��54   2   $��版本:��6$   $
��Left=�6H   $��	210,0,0,0q�6c   $	��Top=�6v   $	��160��6�   55      56      �� 57      -   5        $ gbxMain_Copy3��57      $��	电源板��66   $
��Left=�6C   $	��Top=�6^   $	��427��6v   $��85��6�   $��	0,237,0,0q�6�   .��58      � $
��Left=�6   $��50��6:   $	��Top=�6F   $	��427��6^   $��
0,0,-12,-3q�6j    � RowDefinitions 59      �� 5:   "   $
��Auto �60   �� 5;   "   $
��Auto �60   .+�5=      �� $��0��6$   $'��!标配电源板      地址: 0x20��61   $
��Left=�6O   $	��Top=�6j   $	��164��6�   �� 5>      -   5        $ Power1Check��5>   '   $��0��6<   $��在线��6I   $
��Left=�6V   $��
374,12,0,0q�6q   $	��Top=�6�   {�.  $��2��6�   �� 5?      -   5        $ 	Power1Ver��5?   1   $��0��6$   $��版本:��6D   $
��Left=�6R   $��	210,0,0,0q�6m   $	��Top=�6�   $	��161��6�   �� 5@      $'��!备用电源板      地址: 0x22��6$   $
��Left=�6B   $��1,24,0,0q�6]   $	��Top=�6o   $	��146��6�   $��2��6�   �� 5A      -   5        $ 	Power2Ver��5A   2   $��版本:��6$   $
��Left=�6E   $��
210,24,0,0q�6`   $	��Top=�6t   $	��161��6�   $��2��6�   �� 5B      -   5        $ Power2Check��5B   '   $��1��6<   $��在线��6I   $
��Left=�6V   $��	374,6,0,0q�6q   $	��Top=�6�   {�.  6�   5C      5D      �� 5E      -   5        $ gbxMain_Copy4��5E      $��	车检板��66   $
��Left=�6C   $	��Top=�6^   $	��427��6v   $	��176��6�   $��	0,327,0,0q�6�   .��5F      � $
��Left=�6   $	��113��6:   $	��Top=�6H   $	��427��6`   $��0,0,-12,-22q�6l    5G      �� 5H   "   $
��Auto �60   �� 5I   "   $
��Auto �60   �� 5J   "   $
��Auto �60   �� 5K   "   $
��Auto �60   .+�5M      �� $��0��6$   $'��!检测器1           地址: 0x24��61   $
��Left=�6S   $	��Top=�6n   $	��164��6�   �� 5N      -   5        $ Detector1Online��5N   A   $��0��6'   $��在线��64   $
��Left=�6Z   $��	376,8,0,0q�6u   $	��Top=�6�   {�.  6�   �� 5O      -   5        $ Detector1Ver��5O   ?   $��0��6$   $��版本:��61   $
��Left=�6U   $��	210,0,0,0q�6p   $	��Top=�6�   $	��163��6�   �� 5P      $&�� 检测器2          地址: 0x25��6$   $
��Left=�6E   $��1,25,0,0q�6`   $	��Top=�6r   $	��146��6�   $��2��6�   �� 5Q      -   5        $ Detector2Ver��5Q   2   $��版本:��6$   $
��Left=�6H   $��
210,25,0,0q�6c   $	��Top=�6w   $	��163��6�   $��2��6�   �� 5R      -   5        $ Detector2Online��5R   A   $��1��6'   $��在线��64   $
��Left=�6Z   $��	376,3,0,0q�6u   $	��Top=�6�   {�.  6�   �� 5S      $��2��6$   $'��!接口板1           地址: 0x29��61   $
��Left=�6S   $	��Top=�6n   $	��164��6�   $��	0,0,0,-24q�6�   $��2��6�   �� 5T      -   5        $ Inject1Online��5T   A   $��2��6'   $��在线��64   $
��Left=�6X   $��376,7,0,-22q�6s   $	��Top=�6�   {�.  6�   �� 5U      -   5        $ 
Inject1Ver��5U   ?   $��2��6$   $��版本:��61   $
��Left=�6S   $��	210,0,0,0q�6n   $	��Top=�6�   $	��163��6�   $��2��6�   �� 5V      $��3��6$   $&�� 接口板2          地址: 0x2A��61   $
��Left=�6R   $��
1,24,0,-49q�6m   $	��Top=�6�   $	��146��6�   �� 5W      -   5        $ 
Inject2Ver��5W   ?   $��3��6$   $��版本:��61   $
��Left=�6S   $��
210,24,0,0q�6n   $	��Top=�6�   $	��163��6�   �� 5X      -   5        $ Inject2Online��5X   A   $��3��6'   $��在线��64   $
��Left=�6X   $��376,32,0,-47q�6s   $	��Top=�6�   {�.  6�   5Y      5Z      �� 5[      -   5        $ gbxMain_Copy5��5[      $��	灯驱板��66   $
��Left=�6C   $	��Top=�6^   $	��377��6v   $	��493��6�   $��
432,10,0,0q�6�   .��5\      � $
��Left=�6   $	��363��6:   $	��Top=�6G   $	��367��6_   $��0,0,-2,0q�6k    5]      �� 5^   "   $
��Auto �61   �� 5_   "   $
��Auto �60   �� 5`   "   $
��Auto �60   �� 5a   "   $
��Auto �60   �� 5b   "   $
��Auto �60   �� 5c   "   $��52 �60   �� 5d   "   $��3 �60   �� 5e   "   $
��Auto �60   �� 5f   "   $
��Auto �60   .+�5h      �� $��0��6$   $��灯驱板1   地址: 0x13��61   $
��Left=�6K   $	��Top=�6f   $	��122��6~   �� 5i      -   5        $ Lamp1Online��5i   A   $��0��6'   $��在线��64   $
��Left=�6V   $��	323,7,0,0q�6q   $	��Top=�6�   {�.  6�   �� 5j      -   5        $ Lamp1��5j   ?   $��0��6$   $��版本:��61   $
��Left=�6N   $��	198,0,0,0q�6i   $	��Top=�6|   $	��120��6�   �� 5k      $��1��6$   $��灯驱板2   地址: 0x14��61   $
��Left=�6K   $��1,11,0,0q�6f   $	��Top=�6x   $	��120��6�   �� 5l      -   5        $ Lamp2��5l   ?   $��1��6$   $��版本:��61   $
��Left=�6N   $��
198,11,0,0q�6i   $	��Top=�6}   $	��119��6�   �� 5m      -    5        $ Lamp2Online��5m   A   $��1��6'   $��在线��64   $
��Left=�6V   $��
323,17,0,0q�6q   $	��Top=�6�   {�.  6�   �� 5n      $��2��6$   $��灯驱板3   地址: 0x15��61   $
��Left=�6K   $	��Top=�6f   $	��121��6~   $��0,13,0,0q�6�   �� 5o      -!   5        $ Lamp3Online��5o   A   $��2��6'   $��在线��64   $
��Left=�6V   $��
323,21,0,0q�6q   $	��Top=�6�   {�.  6�   �� 5p      -"   5        $ Lamp3��5p   ?   $��2��6$   $��版本:��61   $
��Left=�6N   $��
198,13,0,0q�6i   $	��Top=�6}   $	��118��6�   �� 5q      $��3��6$   $��灯驱板4   地址: 0x16��61   $
��Left=�6K   $��1,19,0,0q�6f   $	��Top=�6x   $	��120��6�   �� 5r      -#   5        $ Lamp4��5r   ?   $��3��6$   $��版本:��61   $
��Left=�6N   $��
198,19,0,0q�6i   $	��Top=�6}   $	��118��6�   �� 5s      -$   5        $ Lamp4Online��5s   A   $��3��6'   $��在线��64   $
��Left=�6V   $��
324,25,0,0q�6q   $	��Top=�6�   {�.  6�   �� 5t      $��5��6$   $��灯驱板5   地址: 0x17��61   $
��Left=�6K   $	��Top=�6f   $	��121��6~   $��1,22,0,0q�6�   �� 5u      -%   5        $ Lamp5Online��5u   A   $��5��6'   $��在线��64   $
��Left=�6V   $��
324,29,0,0q�6q   $	��Top=�6�   {�.  6�   �� 5v      -&   5        $ Lamp5��5v   ?   $��5��6$   $��版本:��61   $
��Left=�6N   $��
198,22,0,0q�6i   $	��Top=�6}   $	��118��6�   �� 5w      $��灯驱板6   地址: 0x18��6$   $
��Left=�6>   $��1,21,0,0q�6Y   $	��Top=�6k   $	��120��6�   $��7��6�   �� 5x      -'   5        $ Lamp6��5x   2   $��版本:��6$   $
��Left=�6A   $��
198,21,0,0q�6\   $	��Top=�6p   $	��117��6�   $��7��6�   �� 5y      -(   5        $ Lamp6Online��5y   A   $��7��6'   $��在线��64   $
��Left=�6V   $��
325,30,0,0q�6q   $	��Top=�6�   {�.  6�   �� 5z      $��8��6$   $��灯驱板7   地址: 0x1A��61   $
��Left=�6K   $	��Top=�6f   $	��121��6~   $��1,27,0,0q�6�   �� 5{      -)   5        $ Lamp7Online��5{   A   $��8��6'   $��在线��64   $
��Left=�6V   $��
325,34,0,0q�6q   $	��Top=�6�   {�.  6�   �� 5|      -*   5        $ Lamp7��5|   ?   $��8��6$   $��版本:��61   $
��Left=�6N   $��
198,27,0,0q�6i   $	��Top=�6}   $	��117��6�   �� 5}      $��8��6$   $��灯驱板8   地址: 0x1B��61   $
��Left=�6K   $��0,72,0,0q�6f   $	��Top=�6x   $	��120��6�   �� 5~      -+   5        $ Lamp8��5~   ?   $��8��6$   $��版本:��61   $
��Left=�6N   $��
198,72,0,0q�6i   $	��Top=�6}   $	��118��6�   �� 5      -,   5        $ Lamp8Online��5   A   $��8��6'   $��在线��64   $
��Left=�6V   $��
324,78,0,0q�6q   $	��Top=�6�   {�.  6�   5�      5�      5�      5�      �� 5�      --   5         ��Name$ btnRead��5�         tsc_data_refresh#���   6&   $
��Left=�6S   $��403,558,0,0q�6n   $��75��6�   $��22��6�   $	��Top=�6�   5�      5�      5�      