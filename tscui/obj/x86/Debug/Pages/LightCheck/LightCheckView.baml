   M S B A M L   `   `   `  ����@  <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:tscui.Pages.LightChecktscui.Pages.LightCheck  5      K GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d3%clr-namespace:Apex.MVVM;assembly=Apex	Apex.MVVM 5      +    %tscui.Pages.LightCheck.LightCheckView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:tscui.Pages.LightCheck     5      :apexMVVM%clr-namespace:Apex.MVVM;assembly=Apex     5      -   5        $��0,-6,0,0q�5   3   $��641.523��6�     Apex.MVVM.View    	ViewModel  5      0   *tscui.Pages.LightCheck.LightCheckViewModel  5   
   -   5        	viewModel��5   $   .��5      � -   5         �Name$ GridLampCheck��5      $��0,0,0,34q�6"   .+�5   
   �� -   5        $��reset��5   x      tsc_time_read#���   6   $��23��6;   $
��Left=�6H   $��670,584,0,0q�6c   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $
��save��5   �     tsc_time_save#���  6   $��23��6;   $
��Left=�6Z   $��780,584,0,0q�6u   $	��Top=�6�   $��75��6�   &    tscui.Pages.LightCheck.CheckItem  5   
   -   5          Name$ 
LampBroad8��5      {�.  $
��Left=�6A   $��	-7,18,0,0q�6\   $	��Top=�6o     5   
   -   5        $ 
LampBroad7��5      {�.  $
��Left=�6A   $��
103,18,0,0q�6\   $	��Top=�6p     5   
   -   5        $ 
LampBroad6��5      {�.  $
��Left=�6A   $��
213,18,0,0q�6\   $	��Top=�6p     5   
   -	   5        $ 
LampBroad5��5      {�.  $
��Left=�6A   $��
324,18,0,0q�6\   $	��Top=�6p     5   
   -
   5        $ 
LampBroad4��5      {�.  $
��Left=�6A   $��
435,18,0,0q�6\   $	��Top=�6p     5   
   -   5        $ 
LampBroad3��5      {�.  $
��Left=�6A   $��
547,18,0,0q�6\   $	��Top=�6p     5   
   -   5        $ 
LampBroad2��5      {�.  $
��Left=�6A   $��
659,18,0,0q�6\   $	��Top=�6p     5   
   -   5        $ 
LampBroad1��5      {�.  $
��Left=�6A   $��
770,18,0,0q�6\   $	��Top=�6p   �� 5   
   -   5         ��Name$ cbxOpenSpecFun��5        tsc_lightcheck_software#���  6+   $y�Hidden=�6_   $
��Left=�6s   $��669,600,0,0q�6�   $	��Top=�6�   6�   �� 5   
   -   5          tsc_lightcheck_hardware#���  5      $y�Hidden=�6G   $
��Left=�6[   $��669,577,0,0q�6v   $	��Top=�6�   6�   �� 5   
   $
��Left=�6   $��	806,0,0,0q�6/   $
��Wrap=�6B   $��
灯驱板1��6V   $	��Top=�6b   $��12(�6z   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��	699,0,0,0q�6/   $
��Wrap=�6B   $��
灯驱板2��6V   $	��Top=�6b   $��12(�6z   $
��Bold"�6�   �� 5    
   $
��Left=�6   $��	585,0,0,0q�6/   $
��Wrap=�6B   $��
灯驱板3��6V   $	��Top=�6b   $��12(�6z   $
��Bold"�6�   �� 5!   
   $
��Left=�6   $��	475,0,0,0q�6/   $
��Wrap=�6B   $��
灯驱板4��6V   $	��Top=�6b   $��12(�6z   $
��Bold"�6�   �� 5"   
   $
��Left=�6   $��	364,0,0,0q�6/   $
��Wrap=�6B   $��
灯驱板5��6V   $	��Top=�6b   $��12(�6z   $
��Bold"�6�   �� 5#   
   $
��Left=�6   $��	254,0,0,0q�6/   $
��Wrap=�6B   $��
灯驱板6��6V   $	��Top=�6b   $��12(�6z   $
��Bold"�6�   �� 5$   
   $
��Left=�6   $��	144,0,0,0q�6/   $
��Wrap=�6B   $��
灯驱板7��6V   $	��Top=�6b   $��12(�6z   $
��Bold"�6�   �� 5%   
   $
��Left=�6   $��36,0,0,0q�6/   $
��Wrap=�6A   $��
灯驱板8��6U   $	��Top=�6a   $��12(�6y   $
��Bold"�6�   	� 5&   
   -   5         	�Name$ Radio_OpenLightCheck��5&      #���  64   $
��Left=�6h   $��
29,583,0,0q�6�   $	��Top=�6�   	� 5'   
   -   5        $ Radio_CloseLightCheck��5'       ! tsc_lightcheck_software_close#���  65   $
��Left=�6o   $��249,583,0,0q�6�   $	��Top=�6�   $	��213��6�   �� 5(   
   -   5        $ Chk_LampTest��5(      $��通道亮灭测试��6)   $
��Left=�6:   $��24��6U   $��456,583,0,0q�6a   $	��Top=�6v   $��96��6�   6�   �� 5)   
   -   5         ��Name$ BtnLampTest��5)   t   $��测试��6   $��22��6   $
��Left=�6D   $��559,581,0,0q�6_   $	��Top=�6�   $��29��6�   $y�Hidden=�6�   5*      5+      