   M S B A M L   `   `   `  ����b  ^DevComponents.WPF.Controls, Version=7.1.0.14, Culture=neutral, PublicKeyToken=ff0069e61369d6d6kLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.ControlsDevComponents.WPF.Controls  5      	 tscui   tscui.Pages.Gps.GpsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      aControlsLclr-namespace:DevComponents.WPF.Controls;assembly=DevComponents.WPF.Controls     5      -   5        $	��Top=�5      $��398.508��6g   .��5
      � $
��Left=�6   $	��391��6&   $	��Top=�63   $	��800��6K   $��	0,0,-14,0q�6W     � ColumnDefinitions  5   
   �� 5      $��9* �6   �� 5      $
��791* �6   .+�5   
   �� $��	GPS开关��6   $��13(�6"   $
��Left=�60   $��	50,10,0,0q�6K   $	��Top=�6^   $	��100��6v   $	��542��6�   $��1��6�   .��5      �� $
��Left=�6   $��77��60   $	��Top=�6<   $	��532��6T   $��0,0,-2,0q�6`   .+�5      	� -   5         	�Name$ RdbOpen��5      $��12(�6/   $��	开启GPS��6=    �� Left$ 51��6M   
 �� Top$ 34��6^   $��28��6n   $	��119��6z   	� 5      -   5        $ RdbClose��5      $��12(�60   $��	关闭GPS��6>   $	 209��6N   $ 34��6`   $	��132��6p   	� 5      -   5        $ 	RdbRserve��5      $��12(�61   $��	不设置��6?   $	 367��6M   $ 34��6_   $	��132��6o   �� 5      $��28��6   $ 31��6$   $��32��64   $/��)/tscui;component/Resources/Images/Gps.png��6?   $ 10��6r   5      5      �� 5   
   $��	GPS参数��6   $��13(�6"   $
��Left=�60   $��
50,127,0,0q�6K   $	��Top=�6_   $	��169��6w   $	��542��6�   $��1��6�   .��5      �� $
��Left=�6   $	��153��60   $	��Top=�6=   $	��515��6U   .+�5      �� $��GPS校时间隔(天):��6   $��12(�6.   $ 45��6<   $ 61��6M   $��46��6]   $	��135��6i   /   )DevComponents.WPF.Controls.NumericSpinner  5      -   5          Name$ IntervalTime��5   *   $	 207��6@   $ 61��6R   $��25��6b   $��52��6n   #��� ��6y      Value$ 10��6�      	Increment$ 1Q�6�    � ForceCursor .    Interval$ 1Q�6�   	   Maximum$	 30Q�6  
   Minimum$
 1Q�6     NullValueDisplayString$ xx��6   �� 5      -   5         ��Name$ 
ChkGpsPara��5   (   $��设置��6   $	 264��6<   $ 65��6N   �� 5      $��28��6   $ 63��6$   $��32��64   $/��)/tscui;component/Resources/Images/Gps.png��6?   $ 8��6r   5      5      �� 5   
   -   5         ��Name$ Simulatebtn��5      $��读取��6   $��10(�63   $��1��6W   $��104,324,623,39q�6g   �� 5    
   -   5        $��提交��5       $��10(�6   $��1��6A   $��269,324,458,39q�6Q   �� 5!   
   -	   5        $��强制校时��5!      $��10(�6    $��1��6G   $��438,324,289,39q�6W   {�6o   �� *	IsChecked+ �� ElementName$ RdbOpen��5"      5#      