   M S B A M L   `   `   `  ����=  9qq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:qqqq  5   	       qq.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:qq     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ MoneyManager��6;   $	��600��5      $
��1000��6'    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6�   .��5      � .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost    MaterialDesignDivider#���  6$      DialogContent 5      � 5      $	��300��6   $	��150��6#   $��Center=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Logout=�62     PrimaryHueMidBrush#��[ 6@   $��50��5   2   $��50��6=   $��15q�6I   �� 5      
�������$	��200��66   $��15 30q�6B   $
��Wrap=�6Q   Do you really want to logout?5      5      �� 5      $ 
Horizontal=�6!   $��Bottom=�6:   $��Right=�6U   $��15q�5   !   .+�5      �� -   5        	 ��Name$	 	btnLogout��5   !   $��Logout��5   !   
   CloseDialogCommand#��Z
 62     MaterialDesignFlatButton#���  5   !   5   4   �� 5       $��Cancel��6!   #��Z
 62   #���  5!   !   5"      5#      .��5%      � .+�5&      � $��60��6   $	��Top=�6#   ���	#FF125297.+�5'      �� $��Right=�6!   .+�5(      '  !MaterialDesignThemes.Wpf.PopupBox  
�������   PlacementMode$ BottomAndAlignRightEdges=�6J      	StaysOpen .  $��10q�5)   <   $��40��6H   $��40��6S      PopupContent. 5*      �� $	��150��6)   .+�5+   "   �� $ 
Horizontal=�6-   .+�5,   &     $ Account=�6>   $��40��6M   $��40��6Y   $��10q�5-   2   ���#1212126>   �� 5.   &   -   5        $��txtUsername��5.   0   $��Center=�6C   $��Center=�5/   0   50   #   �� 51   "   -   5        $��
btnAccount��51   ;   $��Account��6)   6M   �� 52   "   -   5        $	 btnHelp��52   8   $
��Help��6)   6I   �� 53   "   �� 54   "   $��Logout��6)      OpenDialogCommand#��Z 6:   55      56      57      58      � 59      ���	#FF00142B$	��200��6.   $
��Left=�6:   .+�5:      �� .+�5;      � $	��150��6   .+�5<      �� $��Center=�6)   $��Center=�6D   .+�5=   "   �� $��Money��6,   
�������$��40(�6Q   �� 5>   "   $��Manager��6,   
�������$��40(�6S   5?      5A      �� 5B      -   5         ��Name$ LoadPageList��5B   #   ���	#FF100B60
�������.@�5D      �� $��70��6+   .��5E   "   �� $ 
Horizontal=�6-   .+�5F   &     $
 Home=�6>   $��25��6J   $��25��6V   $��10q�6a   �� 5G   &   $
��Home��60   $��Center=�6<   $��20 10q�6W   5H   #   5I      �� 5K      $��70��6,   .��5L   "   �� $ 
Horizontal=�6-   .+�5M   &     $ ChartArc=�6>   $��25��6N   $��25��6Z   $��10q�6e   �� 5N   &   $��Chart��60   $��Center=�6=   $��20 10q�6X   5O   #   5P      �� 5R      $��70��6,   .��5S   "   �� $ 
Horizontal=�6-   .+�5T   &     $ Wallet=�6>   $��25��6L   $��25��6X   $��10q�6c   �� 5U   &   $��Wallet��60   $��Center=�6>   $��20 10q�6Y   5V   #   5W      5X      5Y      �� 5Z      $��Bottom=�6!   .+�5[      �� -   5        $ buttonClose��5[   #   ���	#FF100B60
�������.@�5\      �� $��60��6+   .��5]   "   �� $ 
Horizontal=�6-   .+�5^   &     $ Close=�6>   $��25��6K   $��25��6W   $��10q�6b   �� 5_   &   $��Close��60   $��Center=�6=   $��20 10q�6X   5`   #   5a      5b      5c      5d      � 5e      -   5         �Name$ gridHome��5e      $��
200 60 0 0q�6)   5f      5g      5h      5i      