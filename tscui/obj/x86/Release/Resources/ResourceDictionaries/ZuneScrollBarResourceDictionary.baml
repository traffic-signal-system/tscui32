   M S B A M L   `   `   `  ���� K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d?+clr-namespace:Apex.Converters;assembly=ApexApex.Converters  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarDisabledBackground  �� Color  ScrollBarButton �� 
TargetType �� Property �� Value �� 
TargetType  VerticalScrollBarPageButton ! HorizontalScrollBarBackground �� EndPoint �� 
StartPoint � Color � Offset ! HorizontalScrollBarPageButton  ScrollBarLightColor  ScrollBarMediumColor  ScrollBarDarkColor  ScrollBarLightBrush 	 ScrollBarMediumBrush 
 ScrollBarDarkBrush	 �Name
 J� SnapsToDevicePixels � RowDefinitions ]�Name J� IsMouseOver ]� DecreaseRepeatButton �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb  ZuneThumbStyle �� Triggers P� Property P� Value �� 
TargetName �� Triggers � ColumnDefinitions �� LineLeftCommand �� PageLeftCommand �� PageRightCommand �� LineRightCommand ��Name � 	Resources  Key �� 
TargetName  �� TargetProperty	! �� To" g� Duration	# W� To$ W� EasingFunction.   (System.Windows.Media.Animation.CubicEase7  1System.Windows.Media.Animation.EasingFunctionBase%   
EasingMode& N� EnterActions  ActivateStoryboard' N� ExitActions  DeactivateStoryboard�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     >apexConverters+clr-namespace:Apex.Converters;assembly=Apex  %R	  &	        &	      &	 �     &	 D    &	 �    &	 �    &	 �    &	 �    &	 �    7  &		 �    7  &	
 �    7  '�� �    7  7 
 7   7  7  7  7  7  7   &	 ]    7  7  7  7  7  �� $  #F4F4F4���� " ��.���  �@�OverridesDefaultStyle . ��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� �� " ��.���  �@�OverridesDefaultStyle . ��  � ��
 ���� ��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� #��z��#��z��#��z���� $	 0,1&�$	 0,0&�.��� $ #E1E1E1��$ 0Q�� $ #EDEDED��$
 0.20Q�� $ #EDEDED��$
 0.80Q�� $ #E3E3E3��$ 1Q��� " ��.���  �@�OverridesDefaultStyle . ��  � ��
 ���� ��  � |� .  ��  � �� .  ��  � �� �� " ��.R��� #��z��#��z��#��z����#BFBFBF����#A7A5A5����#F10DA2���� 8    �� 8    �� 8    �� " ��.���  � ��8   ��  �@��IsPressAndHoldEnabled .  ��  �@��IsFlicksEnabled .  ��  � ��8  ��  � ��# � r���  � ��# � r���  � �� �� " ��.R�� $	 Bg��
 . 
������  �� $��0.00001* �.+��� $��1��$��Center=�#��z��]� $ 
PART_Track����. #{�z  �� #��Z #���   �� #��Z #���   n� #���   P�  � {� .  . ��� $ Bg��8   � �� P�  �@��Orientation$ 
Horizontal=�. ���  � ��$
 Auto����  � ��$ 0����  � ��# � ����  � ��# � ����  � ��8  ��  � �� �� " ��.R�� $	 Bg��#��z��
 .  �� #��� ���� $��0.00001* ��� #��� ��.+��� #��Z #{�z 8�� ]� $ 
PART_Track��$��1��#{�z  �� #��Z 8��  �� #��Z 8��  n� #���  �� $��2��#��Z #{�z 8��  P�  � {� .  . ��� $ Bg��8   � ���� " n�.���  �@�OverridesDefaultStyle . ��  � �� .  ��  � �� �� " n�.R��� $ thumb��
 . $��3��$��Center=����� 
thumbBrush��8     ���� ActivateStoryboard .���� $ 
thumbBrush��$  Color�8!  $" 0:0:0.2D�W� $ thumb��$  Width�$# 30X�$" 0:0:0.2D�$    $% EaseOut=��� DeactivateStoryboard .���� $ 
thumbBrush��$  Color�8!  $" 0:0:0.2D�W� $ thumb��$  Width�$# 3X�$" 0:0:0.2D�$    $% EaseOut=� P�  � {� . & �� 8�� ' �� 8�� 