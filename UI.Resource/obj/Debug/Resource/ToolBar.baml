   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   ToolBarButtonBaseStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� EndPoint �� 
StartPoint  BorderLightColor	 � Color
 � Offset  BorderMediumColor  ControlLightColor  ControlMediumColor'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� 
TargetName �� TargetProperty8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime  ControlPressedColor �� Value  ControlMouseOverColor  DisabledControlDarkColor �� BasedOn-  'System.Windows.Input.KeyboardNavigation �� Padding �� Color  DisabledBorderLightColor ��Name 	 ToolBarThumbStyle J� SnapsToDevicePixels j� Viewport j� ViewportUnits j� Viewbox j� ViewboxUnits j� TileMode L� Drawing � Brush � Geometry 
 ToolBarOverflowButtonStyle �� CornerRadius  F�Name  BorderDarkColor! c� HasOverflowItems" �� 	ClickMode# d� 	IsChecked$ �� Mode% �� RelativeSource& �Name' � AllowsTransparency( � 	StaysOpen) b�Name* b� 	WrapWidth+   TabNavigation,   DirectionalNavigation- � FocusVisualStyle. n�Name/ a�Name0 K� IsItemsHost1 �� Triggers2 P� Property3 P� Value4 �� 
TargetName  WindowColor�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      .sys&clr-namespace:System;assembly=mscorlib  5        5      �� 5      $ Shared.xaml?�6   %}  &	        7  7  7  7  (�� �    5b   
   *ToolBar.ButtonStyleKey+)7   (�� �    5e   
   *ToolBar.ToggleButtonStyleKey+)7   (�� �    5h   
   *ToolBar.CheckBoxStyleKey+)7   (��     5k   
   *ToolBar.RadioButtonStyleKey+)7   (�� &    5o   
   *ToolBar.TextBoxStyleKey+)7  7  7  &		 �    &	
     7  7  7  'c� �    7 
 7 	 '`�     �� 5
      " ��5   
   .�5      ��  �@J�SnapsToDevicePixels . 5      �� 5       �@�OverridesDefaultStyle . 5      �� 5       � �� 5      �� 5   
   " ��6   .R�5      �� $ Border��6   $��1q�5      ��5      �� 5      $ 0.5,1&�6$   $ 0.5,0&�5   $   .��5      � #	 �  6   $
 0Q�5      � 5      #	 �  6   $
 1Q�5      5      ��5      �� 5      $ 0.5,1&�6$   $ 0.5,0&�5    $   .��5!      � #	 �  6   $
 0Q�5"      � 5#      #	 �  6   $
 1Q�5$      5%       5'        5(      CommonStates��. 5)        
Normal��6     5*      Pressed��. 5+      �� .��5,      �� $ Border��63   $e _(Panel.Background).                       (GradientBrush.GradientStops)[1].(GradientStop.Color)�5-   3   .g�5/        $ 0��6,   8   50   ,   51      52      53        54      	MouseOver��. 55      �� .��56      �� $ Border��63   $e _(Panel.Background).                       (GradientBrush.GradientStops)[1].(GradientStop.Color)�57   3   .g�59        $ 0��6,   8  5:   ,   5;      5<      5=        5>      Disabled��. 5?      �� .��5@      �� $ Border��63   $f `(Panel.Background).                        (GradientBrush.GradientStops)[1].(GradientStop.Color)�5A   3   .g�5C        $ 0��6,   8  5D   ,   5E      5F      5G      5H        5I      CheckStates��. 5J        Checked��. 5K      �� .��5L      �� $ Border��63   $e _(Panel.Background).                       (GradientBrush.GradientStops)[1].(GradientStop.Color)�5M   3   .g�5O        $ 0��6,   8  5P   ,   5Q      5R      5S        5T      	Unchecked��6     5U      Indeterminate��6   5V      ._�5X      �� $��2q�6   $��Center=�5Y      $��Center=�5Z      ��. 5[      5\      5]      5_      5`      �� 5b      8   " ��5d   
   �� 5e      8   " d�5g   
   �� 5h      8   " ��5j   
   �� 5k      8   " 	�5m   
   �� 5o      " ��5p   
   .�5q      ��  �@J�SnapsToDevicePixels . 5r      �� 5s       �@�OverridesDefaultStyle . 5t      �� 5u       �@ TabNavigation$
 None=�5v      �� 5w       �@�FocusVisualStyle 5x      Z� �� 5y       �@J�	AllowDrop . 5z      �� 5{       � �� 5|      �� 5}   
   " ��6   .R�5~      �� $ Border��6   $ 2q�5      $��1q�5�      ��5�      �� 5�      # �  6    ��5�      �� 5�      8   6     5�        5�      CommonStates��. 5�        
Normal��6     5�      Disabled��. 5�      �� .��5�      �� $ Border��63   $I C(Panel.Background).                         (SolidColorBrush.Color)�5�   3   .g�5�        $ 0��6,   8  5�   ,   5�      �� 5�      $ Border��63   $K E(Border.BorderBrush).                         (SolidColorBrush.Color)�5�   3   .g�5�        $ 0��6,   8  5�   ,   5�      5�      5�        5�      ReadOnly��6     5�      	MouseOver��6   5�      ._�5�      �� $ PART_ContentHost��5�      $��0q�5�      5�      5�      5�      5�      5�      �� 5�      " n�5�   
   .�5�      ��  �@�OverridesDefaultStyle . 5�      �� 5�       �@�Cursor$ SizeAll��5�      �� 5�       � �� 5�      �� 5�   
   " n�6   .R�5�      �� 
������  . ._�5�      �� $	��0,2q�6   ��5�      L� 5�      $ 0,0,4,4�6   $ Absolute=�5�      $ 0,0,8,8�5�      $ Absolute=�5�      $
 Tile=�5�       5�      I� 5�      .��5�      �  �#AAA+ �� 	=  	= � 	=  z � z  z � z  	= 	5�   (   5�      5�      5�      5�      5�      5�      5�      �� 5�      " d�5�   
   .�5�      ��  �@�OverridesDefaultStyle . 5�      �� 5�       � �� 5�      �� 5�   
   " d�6   .R�5�      �� $ Border��6   $ 0,3,3,0��5�       . ��5�      �� 5�      $ 0.5,1&�6$   $ 0.5,0&�5�   $   .��5�      � $	 	#00000000��6   $
 0Q�5�      � 5�      $
 1Q�6   5�       5�        5�      CommonStates��. 5�        
Normal��6     5�      Pressed��. 5�      �� .��5�      �� $ Border��63   $i c(Panel.Background).                           (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�   3   .g�5�        $ 0��6,   8   5�   ,   5�      5�      5�        5�      	MouseOver��. 5�      �� .��5�      �� $ Border��63   $j d(Panel.Background).                            (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�   3   .g�5�        $ 0��6,   8  5�   ,   5�      5�      5�        5�      Disabled��. 5�      �� .��5�      �� $ Border��63   $h b(Panel.Background).                          (GradientBrush.GradientStops)[1].(GradientStop.Color)�5�   3   .g�5�        $ 0��6,   8  5�   ,   5�      5�      5�      5�      ._�5�      � .+�5�      F� $  Arrow��6   
���   �$��Bottom=�5�      $	��2,3q�5      "�����^����- �`�S ��- Ѡ%& ��[ 	5     �� 5     5     5     5     5     5     �� 5
     " c�5  
   .�5     ��  �@J�SnapsToDevicePixels . 5     �� 5      �@�OverridesDefaultStyle . 5     �� 5      � �� 5     �� 5  
   " c�6   .R�5     �� $ Border��6   $ 2��5     $��1q�5     ��5     �� 5     $	 0,0&�6$   $	 0,1&�5  $   ��5     � � 5     #	 �  6#   $	
 0.0Q�5  #   � 5     #	 �  6#   $	
 1.0Q�5  #   5     5!     ��5$     �� 5%     $	 0,0&�6$   $	 0,1&�5&  $   ��5(     � � 5)     $
	 #FFF��6#   $	
 0.0Q�5*  #   � 5+     #	 �  6#   $	
 1.0Q�5,  #   5-     5/     ._�51     ]� .+�52     d� $��Right=�6   #{�z! 53     8��  $" Press=�55     # 56     �� *IsOverflowOpen+$$ TwoWay=�% �� *TemplatedParent+.��58     � $& OverflowPopup��6   ' . $��Bottom=�5:     ( .  |�.  $��Slide=�5=     ��5>     �� *IsOverflowOpen+% �� *TemplatedParent+.��5@     �� $ DropDownBorder��6   $��1q�5A     ��5B     �� 5C     # �  6(   ��5E     �� 5F     $ 0.5,1&�6,   $ 0.5,0&�5G  ,   .��5H     � #	 �  6'   � 5I     #	 �  6'   $
 1Q�5J  '   5K     ._�5M     b� $) PART_ToolBarOverflowPanel��6+   $��2q�5N  +   $	* 200Q�5O  +   |�. $+ Cycle=�5R  +   $, Cycle=�5S  +   - 5Q  +   Z� 5S  +   5T     5U     5V     n� 5X     $. ToolBarThumb��6   8�� $��10��5Z     a� 5[     $/ PART_ToolBarPanel��6   0 . $��0,1,2,2q�5]     5^     5_     1 5`     P� 5a     2 �@c�IsOverflowOpen3 . . �5c     �� $4 ToolBarThumb��6    � {� .  5e     5f     P� 5g     2 �@`�IsLocked3 . . �5i     �� $4 ToolBarThumb��6    � y�$ 	Collapsed=�5k     5l     5n     5p     5q     �� 5s     " `�5t  
   .�5u     ��  �@`�
Background 5v     �� 5w  
   $	 0,0&�6   $	 1,0&�5x     ��5z     � � 5{     $
	 #FFF��6   $	
 0.0Q�5|     � 5}     #	 �  6   $	
 1.0Q�5~     5     5�     5�     5�     5�     