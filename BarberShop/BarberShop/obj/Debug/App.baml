   M S B A M L   `   `   `  ����E  ABarberShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BarberShop
BarberShop  5          BarberShop.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      *localclr-namespace:BarberShop     5        �� 	Resources  5         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType  WindowColor  ContentAreaColorLight  ContentAreaColorDark  DisabledControlLightColor  DisabledControlDarkColor  DisabledForegroundColor  SelectedBackgroundColor  SelectedUnfocusedColor 	 ControlLightColor 
 ControlMediumColor  ControlDarkColor  ControlMouseOverColor  ControlPressedColor  
GlyphColor  GlyphMouseOver  BorderLightColor  BorderMediumColor  BorderDarkColor  PressedBorderLightColor  PressedBorderDarkColor  DisabledBorderLightColor  DisabledBorderDarkColor  DefaultBorderBrushDarkColor  HeaderTopColor " DatagridCurrentCellBorderColor  SliderTrackDarkColor  NavButtonFrameColor  MenuPopupBrush �� EndPoint �� 
StartPoint � Color � Offset $  ProgressBarIndicatorAnimatedFill  ComboBoxToggleButton	 � ColumnDefinitions'  !System.Windows.VisualStateManager
   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name �� CornerRadius �� Color F�Name  ComboBoxTextBox R� KeyTime  System.Windows.Visibility   Visible R� Value   Hidden d�Name �� 	ClickMode d� 	IsChecked �� Mode �� RelativeSource ��Name J� IsHitTestVisible  �� SelectionBoxItem! �� SelectionBoxItemTemplate" ��Name# �� 
IsReadOnly$ �� 
IsReadOnly% �Name& �� IsDropDownOpen' � AllowsTransparency( �Name) J� SnapsToDevicePixels* � ActualWidth+ �� MaxDropDownHeight, K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation-   DirectionalNavigation. �� Triggers/ P� Property0 P� Value1 �� 
TargetName2 P� 
SourceName3 �� Triggers4 �� Padding��%�  &	        &	 �     &	 �     &	     &	 1    &	 R    &	 s    &	 �    &	 �    &		 �    &	
 �    &	     &	 7    &	 X    &	 y    &	 �    &	 �    &	 �    &	     &	 <    &	 ]    &	 ~    &	 �    &	 �    &	 �    &	 �    &	     &	 <    &	 [    &	 0    &	 X    7  7  7  &	 �    '�� �    7  7  '�� j    7  7  �� 5   
   " ��6&   .�5      ��  � �� 5	      �� 5
      " ��6&   .R�5      � #��z��6   .+�5      �� $��Center=�6/   $��Center=�5      5      5      5      5      ��5   
   	#FFE8EDF9��6/   ��5   
   	#FFC5CBF9��69   ��5   
   #324AB2��66   ��5   
   	#FFE8EDF9��6=   ��5   
   	#FFC5CBF9��6<   ��5   
   	#FF888888��6;   ��5   
   	#FFC5CBF9��6;   ��5   
   	#FFDDDDDD��6:   ��5   
   	#7F054353��65   ��5    
   	#FF7381F9��66   ��5!   
   #324AB2��62   ��5#   
   	#7F054353��69   ��5$   
   	#7F054353��67   ��5'   
   	White��6*   ��5(   
   /+sc#1, 0.004391443, 0.002428215, 0.242281124��6T   ��5+   
   	#FFCCCCCC��64   ��5,   
   	#FF888888��65   ��5-   
   	#FF444444��63   ��5/   
   	#FF888888��6;   ��50   
   	#FF444444��6:   ��52   
   	#FFAAAAAA��6<   ��53   
   	#FF888888��6;   ��55   
   	Black��6;   ��58   
   	#FFC5CBF9��62   ��59   
   	Black��6>   ��5:   
   	#FFC5CBF9��68   ��5<   
   #324AB2��65   �� 5>   
   $ 0.5,1&�5?      $ 0.5,0&�5@      .��5A      � # � 	 6   $ 0Q�5B      � 5C      $ #324AB2��6   $	 0.5Q�5D      � 5E      $ #324AB2��6   $ 1Q�5F      5G      �� 5I   
   $	 0,0&�5J      $	 1,0&�5K      ��5M      � � 5N      $ 	#000000FF��6#   $ 0Q�5O      � 5P      $ #324AB2��6#   $	 0.4Q�5Q      � 5R      $ #324AB2��6#   $	 0.6Q�5S      � 5T      $ 	#000000FF��6#   $ 1Q�5U      5V      5X      �� 5Z   
   " d�5[      .R�5\      � 	 5]      �� 5^      �� 5_      $��20 �6'   
 5a        5b      CommonStates��. 5c        
Normal��6&     5d      	MouseOver��. 5e      �� .��5f   "   �� $_ Y(Panel.Background).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5h   +   .g�5i   &     $ 0��6:   $ #324AB2��5j   $   5k   #   5l      5m        5n      Pressed��6&     5o      Disabled��. 5p      �� .��5q   "   �� $_ Y(Panel.Background).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5s   +   .g�5t   &     $ 0��6:   8   5u   $   5v   #   �� 5w   "   $; 5(Shape.Fill).                 (SolidColorBrush.Color)�6?   $ Arrow��5y   +   .g�5z   &     $ 0��6:   8  5{   $   5|   #   �� 5}   "   $a [(Border.BorderBrush).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5   +   .g�5�   &     $ 0��6:   8  5�   $   5�   #   5�      5�      5�        5�      CheckStates��. 5�        Checked��. 5�      �� .��5�   "   �� $_ Y(Panel.Background).                 (GradientBrush.GradientStops)[1].(GradientStop.Color)�6?   $ Border��5�   +   .g�5�   &     $ 0��6:   $ #324AB2��5�   $   5�   #   5�      5�        5�      	Unchecked��6&     5�      Indeterminate��6&   5�      .+�5�      �� $ Border��6   $��2��5�      $ 2��5�      $��1q�5�      ��5�      �� 5�      $ White��6*   6:   ��5�      �� 5�      $	 0,0&�6.   $	 0,1&�5�      ��5�   "   � � 5�   &   $ #324AB2��63   � 5�   &   $ #324AB2��63   $	 1.0Q�5�      5�   #   5�      5�      �� 5�      $��0��6   $ 2,0,0,2��5�      $��1q�5�      ��5�      �� 5�      $ #324AB2��6*   5�      F� 5�      $ Arrow��6   $��1��5�      $��Center=�5�      $��Center=�5�      "����        � 	=  	= � z     	��5�      �� 5�      # �  6*   5�      5�      5�      �� 5�   
   " ��5�      .R�5�      �� $ PART_ContentHost��6   |�.  
������ $��5q�5�      5�      �� 5�   
   " ��5�      .�5�      ��  �@J�SnapsToDevicePixels . 5�      �� 5�       �@�OverridesDefaultStyle . 5�      �� 5�       � ��$
 Auto=�5�      �� 5�       � ��$
 Auto=�5�      �� 5�       � �� . 5�      �� 5�       � ��$	 120��5�      �� 5�       � ��$ 20��5�      �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � 
 5�        5�   "   CommonStates��. 5�   &     
Normal��62     5�   &   	MouseOver��62     5�   &   Disabled��. 5�   *   �� .��5�   .   �� $ PART_EditableTextBox��6K   $7 1(TextElement.Foreground). (SolidColorBrush.Color)�5�   1   .g�5�   2     $ 0��6F   $ #324AB2��5�   1   5�   /   5�   +   5�   '   5�   #     5�   "   
EditStates��. 5�   &     Editable��. 5�   *   �� .��5�   .   T� $ (UIElement.Visibility)�6L   $ PART_EditableTextBox��5�   2   ..�5�   2   i� $ 0��6I   # Z 5�   -   5�   /   T� 5�   .   $ (UIElement.Visibility)�5�   -   $ ContentSite��5�   2   ..�5�   2   i� $ 0��6I   # Z 5�   -   5�   /   5�   +   5�   '     5�   &   
Uneditable��62   5   #   .+�5     d� $ ToggleButton��6+   8��  $��2��5     |�.  $ Press=�5      5     �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+�� 5     $ ContentSite��6/    .  #��z  5
     #��z! 5     #��z��5     $��3,3,23,3q�5     $��Stretch=�5     $
��Left=�5     5     �� 5     $" PART_EditableTextBox��6&   8�� $
��Left=�5     $��Bottom=�5     $��3,3,23,3q�5     |�. 
������ $y�Hidden=�5     #$ z# 5     ��5     Z� 5     � 5     $% Popup��6$   $��Bottom=�5     #��z& 5     ' . |�.  $��Slide=�5      .��5!  "   � $( DropDown��6'   ) . #��z* 5#     #��z+ 5$     .+�5%  &   �� $ DropDownBorder��6-   $��1q�5&     ��5'  *   �� 5(  .   # �  6>   ��5*  *   �� 5+  .   $ #324AB2��6>   5-  '   �� 5.  &   $��4,6,4,6q�63   ) . .��50  *   �� , . $- 	Contained=�51     52  '   53  #   54     55     . 56     P� 57     / �@��HasItems0 .  . �59  "   �� $1 DropDownBorder��6)    � ��$ 95��5;     5<     P� 5=     / �@��
IsGrouping0 . . �5?  "   ��  � �� .  5@     5A     P� 5B     $2 Popup��6&   / �@�AllowsTransparency0 . . �5E  "   �� $1 DropDownBorder��6)    �@��CornerRadius$ 4��5G     �� 5H  "   $1 DropDownBorder��6)    � ��$ 0,2,0,0q�5J     5K     5M     5O     5P     �� 5R  
   " ��5S     3 5T     P� 5U     / �@��
IsSelected0 . . �5V     ��  � ��
 �����63   5W     .�5Y     ��  �@J�SnapsToDevicePixels . 5Z     �� 5[      �@�OverridesDefaultStyle . 5\     �� 5]      � �� 5^     �� 5_     " ��6&   .R�5`     �� $ Border��6!   $4 2q�5a     ) . 
������ 
�������$��1q�5c  >   
 5d       5e  "   SelectionStates��. 5f  &     
Unselected��62     5g  &   Selected��. 5h  *   �� .��5i  .   �� $ Border��6K   $E ?(Panel.Background).                     (SolidColorBrush.Color)�5j  1   .g�5l  2     $ 0��6F   8   5m  *   5n  /   5o  +   5p  '     5q  &   SelectedUnfocused��. 5r  *   �� .��5s  .   �� $ Border��6K   $0 *(Panel.Background).(SolidColorBrush.Color)�5t  1   .g�5u  2     $ 0��6F   8  5v  *   5w  /   5x  +   5y  '   5z  #   ._�5|     �� 5}     5~     5�     5�     5�     5�     