   M S B A M L   `   `   `  ����=  9qq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:qqqq  5          qq.UserControlWallet   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:qq     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � .+�5      �� $	��250��6   $��10q�6%   ���	#FF022D5F �� RadiusX$ 5��6B    �� RadiusY$ 5��6N   � 5      $��70��6   $	��100��6   ���	#FF00142B$
��Left=�6B   $	��Top=�5      $��50 10q�6+    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF00142B��6'      
BlurRadius$ 20Q�69   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ WalletOutline=�6*   $��40��6?   $��40��6K   $��Center=�5    *   $��Center=�6E   
�������5!   *   5"      �� 5#      $��Main wallet��6   $��Right=�6+   $��42(�6G   
�������$��30q�5$      $	��Top=�6$   �� 5%      	 �� Orientation$	 
Horizontal=�6   .+�5&      �� $��Balance:��6   
�������$��62(�6D   $
��Left=�6R   $��Bottom=�5'      $��40q�63   �� 5(      -   5        $��
txtBalance��5(      $��-20 30q�6,   $��62(�6<   $��12330��6J   $��Bottom=�6W   $
��Left=�5)      
�������
 �� 
IsReadOnly
 . 6O   5+      �� 5,      -   5        $��lvEdit��5-   3   $��Bottom=�5,      $��Right=�62   $��40 40q�6N   
�������.@�5.      �� .��5/        $ 	CheckBold=�6.   $��50��6?   $��50��6K   50      �� 51      .��52        $	 Pen=�6.   $��50��69   $��50��6E   53      ��56      �� 57      .R�58      �� $	 
Horizontal=�6%   59      5;      5=      � 5>   
   $��1��6   .+�5?      �� $	��250��6   $��10q�6%   ���	#FF00142B$ 5��6B   $ 5��6N   � 5@      $��70��6   $	��100��6   ���	#FF022D5F$
��Left=�6B   $	��Top=�5A      $��50 10q�6+    5B        5C      $ 	#FF022D5F��6'   $ 20Q�69   .+�5E        $ WalletTravel=�6*   $��40��6>   $��40��6J   $��Center=�5F   *   $��Center=�6E   
�������5G   *   5H      �� 5I      $��Other wallet��6   $��Right=�6,   $��42(�6H   
�������$��30q�5J      $	��Top=�6$   �� 5K      $	 
Horizontal=�6   .+�5L      �� $��Balance:��6   
�������$��62(�6D   $
��Left=�6R   $��Bottom=�5M      $��40q�63   �� 5N      -   5        $��txtOtherBalance��5N      $��-20 30q�61   $��62(�6A   $��12330��6O   $��Bottom=�6\   $
��Left=�5O      
�������
 . 6O   5P      �� 5Q      -   5        $��	otherEdit��5R   3   $��Bottom=�5Q      $��Right=�62   $��40 40q�6N   
�������.@�5S      �� .��5T        $ 	CheckBold=�6.   $��50��6?   $��50��6K   5U      �� 5V      .��5W        $	 Pen=�6.   $��50��69   $��50��6E   5X      ��5[      �� 5\      .R�5]      �� $	 
Horizontal=�6%   5^      5`      5a      5c      5d      