   M S B A M L   `   `   `  ����S  OBornander.UI.TabCarousel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulleHclr-namespace:Bornander.UI.TabCarousel;assembly=Bornander.UI.TabCarouselBornander.UI.TabCarousel  5      ! Bornander.UI.TabCarousel.Test.   (Bornander.UI.TabCarousel.Test.MainWindow   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      \	bornanderHclr-namespace:Bornander.UI.TabCarousel;assembly=Bornander.UI.TabCarousel    5        � Title$#  Bornander.UI.TabCarousel Test��5      $	��600��6+   $	��800��68   .��5      �  � ColumnDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $��* �6   .+�5   
   '   !Bornander.UI.TabCarousel.Carousel  -   5          Name$ 
TabControl��5   -   $��1��6   
���   �   Depth$	 0.1Q�6T   �� 5   
   $��0��6    �� Orientation$ Vertical=�6%   .+�5      �� -   5        $��Previous��5      6(   �� 5      -   5        $
��Next��5      6$   � 5       5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� -   5        $��0��5      $
��Goto��6)   68   �� 5      -   5         ��Name$ TargetIndex��5      $��1��6.   $��5,0,0,0q�6>    � Minimum$ 0Q�6O    � Maximum$ 5Q�6[    � SmallChange$ 1Q�6g   	 � LargeChange$	 1Q�6w   
 � Value$
 0Q�6�   5      � 5       5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��6   $��64��6(   $��#Tabs:��63   �� 5      $��1��6   $��5,0,0,0q�6)   $ 1Q�6:   $ 10Q�6F   $ 1Q�6S   $	 1Q�6c   
 6s   ��  �� Path$ NumberOfTabs�5       � 5"       5#      �� 5$      $��* �6'   �� 5%      $��* �6'   .+�5'      �� $��0��6   $��64��6(   $��
Spin time:��63   �� 5(      $��1��6   $��5,0,0,0q�6)   $ 0Q�6:   $
 5000Q�6F   $	 100Q�6U   $		 500Q�6g   
 6y   �� $ AnimationDuration�5)      � 5+       5,      �� 5-      $��* �6'   �� 5.      $��* �6'   .+�50      �� $��0��6   $��64��6(   $��
Tab depth:��63   �� 51      $��1��6   $��5,0,0,0q�6)   $ 0Q�6:   $ 1Q�6F   $
 0.01Q�6R   $		 0.1Q�6e   
 6w   �� $ Depth�52      �� 54      $��Always only one step��6   $��Center=�66   $��5,5,5,0q�6Q    d� 	IsChecked 6b   �� $ AlwaysOnlyOneStep��� 55      $��Wrap at end��6   $��Center=�6-   $��5,5,5,0q�6H    6Y   �� $ 	WrapAtEnd��� 56      $��Flip it��6   $��Center=�6)   $��5,5,5,0q�6D    6U   �� $ 
EnableFlip�57      58      59      