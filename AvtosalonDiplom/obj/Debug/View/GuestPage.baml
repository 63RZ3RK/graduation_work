   M S B A M L   `   `   `  ����J  FAvtosalonDiplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AvtosalonDiplom.ViewAvtosalonDiplom.View  5   	   $    AvtosalonDiplom.View.GuestPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:AvtosalonDiplom.View     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Icon$  logo.png��5	   	    � Title$ Автосалон��5
   	   $	��700��6   $
��1300��6(   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF5779E2��6#    � Offset$ 0Q�65   � 5      $ 	#FF4FAF92��6#   $ 1Q�65   5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      $��60 �6    �� 5      �� 5      �� 5      �� 5      �� 5       $	��320 �6    .+�5#      �� -   5        $��1��5#      $��60��6"   $��60��6.   $��5q�69   $
��Left=�6D      MaterialDesignFlatButton#��[  6_    � Cursor$
 Hand��6�   
���   �$	��Top=�6�   .��5$      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 
HomeCircle=�6*   $��25��6<   $��25��6G   $��Center=�6S   5%      �� 5'      $��60��6   $��60��6!   $��5q�6,   $
��Left=�67   #��[  6R   $
 Hand��6�   
���   �$	��Top=�6�   .��5(        $
	 Menu=�6*   $��25��66   $��25��6A   5)      5*      � 5,   
   $��1��6    5-      �� 5.      $��75 �6    �� 5/      $��* �6    .+�52      � $��0��6   $��1��6    ��53      �� 54      .��55      � $ 	#FF5779E2��6'   $ 0Q�69   � 56      $ 	#FF4FAF92��6'   $ 1Q�69   57      .+�59      �� $��Авто102��6   $��30(�6+   $
��Bold"�69   $��15q�6K   �� 5:      -   5        
 ��Name$
 UserName��5:      $��20(�6.   $
��Bold"�6<   $��15 20 80 15q�6N   $	��800��6c   $��Right=�6o    �� TextAlignment$ Right=�6�   �� 5<      -   5        $��60��5<      $��60��6%   $��5q�60   $��Right=�6;   #��[  6W   $
 Hand��6�   
���   �$	��Top=�6�   .��5=        $	 Logout=�6.   $��25��6<   $��25��6G   5>      5?       � 5@      -   5        $��	MainFrame��5@   !   $��1��6     � NavigationUIVisibility$ Hidden=�62   6T   5A      5B      5C      