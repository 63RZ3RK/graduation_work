   M S B A M L   `   `   `  ����J  FAvtosalonDiplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AvtosalonDiplom.ViewAvtosalonDiplom.View  5      &     AvtosalonDiplom.View.AddNewOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AvtosalonDiplom.View     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  AddNewOrder��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $#��Создание заявки��6!   $��Center=�68   $��Center=�6U   $��25(�6p   �� 5   
   $��1��6   
���   �$��1q�62   $	��500��6F   
������� �� CornerRadius$ 20��6i   $��Center=�6{    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ Black��63      ShadowDepth$ 5Q�6A   ._�5      �� .��5      � $	��350��6    5      �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(    � ColumnDefinitions 5!      �� 5"      $��* �6/   �� 5#      $	��300 �6/   �� 5$      $��* �6+   .+�5&      �� -   5         ��Name$ Brand��5&   .   $��1��6   $��0��6=   	 �� 	MaxLength$	 50��6J   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Марка авто��6Y    %  !MaterialDesignFloatingHintTextBox#��[  6�    � Cursor$ Arrow��6�   �� 5'      -   5        $ Model��5'   .   $��1��6   $��1��6=   $	 50��6J   $
 Модель авто��6Y   #��[  6�   �� 5(      -   5        $
 Cost��5(   .   $��1��6   $��2��6<   $	 10��6I   $
 Цена��6X   #��[  6�   �� 5)      -   5        $
 Year��5)   ;   $��1��6   $��3��6.   $	 4��6I   $
 Год выпуска��6W   �� 5*      -   5        $ Color��5*   ;   $��1��6   $��4��6.   $	 20��6J   $
 Цвет��6Y   #��[  6�   �� 5+      -   5        $ Complectation��5+   ;   $��1��6   $��5��6.   $	 50��6R   $
 Комлектация��6a   #��[  6�   �� 5,      -   5        $��1��5,      $��7��6-   $	��150��6:   $!��Создать заявку��6F   6_   5-      5.      5/      50      51      