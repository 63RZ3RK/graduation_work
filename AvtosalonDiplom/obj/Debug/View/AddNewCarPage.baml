   M S B A M L   `   `   `  ����J  FAvtosalonDiplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AvtosalonDiplom.ViewAvtosalonDiplom.View  5      (    "AvtosalonDiplom.View.AddNewCarPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AvtosalonDiplom.View     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  AddNewCarPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $#��Добавление авто��6!   $��Center=�68   $��Center=�6U   $��25(�6p   �� 5   
   $��1��6   
���   �$��1q�62   $	��500��6F    �� CornerRadius$ 10��6R   $��Center=�6d   $��10q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ Black��63      ShadowDepth$ 5Q�6A   ._�5      �� $	��Top=�6   .��5      � $
��1000��6    5      �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5      $��40 �6(   �� 5       $��40 �6(   �� 5!      $��40 �6(   �� 5"      $��40 �6(   �� 5#      $��40 �6(   �� 5$      $��40 �6(   �� 5%      $��40 �6(   �� 5&      $��40 �6(   �� 5'      $	��120 �6(   �� 5(      $��* �6(   �� 5)      $��40 �6(    � ColumnDefinitions 5+      �� 5,      $��* �6+   �� 5-      $	��300 �6+   �� 5.      $��* �6+   .+�50      �� -   5         ��Name$ Brand��50   =   $��1��6   	 �� 	MaxLength$	 50��6.   $��0��6L   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Марка авто��6Y    %  !MaterialDesignFloatingHintTextBox#��[  6�    � Cursor$ Arrow��6�   �� 51      -   5        $ Model��51   =   $��1��6   $	 50��6.   $��1��6L   $
 Модель авто��6Y   #��[  6�   �� 52      -   5        $	 Reg��52   =   $��1��6   $	 15��6.   $��2��6J   $-
 'Регистрационный знак��6W   #��[  6�   �� 53      -   5        $
 Cost��53   .   $��1��6   $��3��6<   $
 Цена��6I   #��[  6q   �� 54      -   5        $
 Year��54   I   $��1��6   $	 4��6.   $��4��6<   $
 Год выпуска��6W   #��[  6�   �� 55      -   5        $ Color��55   J   $��1��6   $	 20��6.   $��5��6=   $
 Цвет��6Y   #��[  6�   �� 56      -   5        $ Engine��56   J   $��1��6   $	 50��6.   $��6��6=   $7
 1Объем и мощность двигателя��6Z   #��[  6�   �� 57      -   5        $ Complectation��57   J   $��1��6   $	 50��6.   $��7��6=   $
 Комлектация��6a   #��[  6�   �� 58      -	   5         ��Name$ CBType��58   G   $��1��6   $��8��6/   $��6q�6<   $
 Тип кузова��6W   .@�59      �� $��
Седан��6'   �� 5:      $��Универсал��6'   �� 5;      $��Паркеник��6'   �� 5<      $��Хетчбек��6'   �� 5=      $��Внедорожник��6'   �� 5>      $��Лифтбек��6'   5?      �� 5@      -
   5        $ CBKPP��5@   G   $��1��6   $��9��6/   $��5q�6<   $<
 6Коробка переключения передач��6V   .@�5A      �� $��MT��6'   �� 5B      $��AT��6'   �� 5C      $	��AMT��6'   �� 5D      $	��CVT��6'   5E      �� 5F      -   5        $ Country��5F   K   $��1��6   $	 30��6.   $��10��6=   $+
 %Страна производства��6\   #��[  6�   �� 5G      -   5        $	 Vin��5G   K   $��1��6   $	 50��6.   $��11��6=   $
 
Vin-код��6X   #��[  6�   $ Arrow��6�   �� 5H      -   5        $��1��5H      $��12��6-   $��Выбрать фото��6;   $	��150��6R   $
 Hand��6y   �� 5I      -   5         ��Name$ 	PhotoPath��5I   0   $��1��6    $��13��6C   $��40��6Q   $��Center=�6]   $��Center=�6x   �� 5J      -   5         ��Name$ Photo��5J   :   $��1��6   $��14��6,   $	��110��6I   $	��200��6V   �� 5K      -   5        $ Description��5K   G   $��1��6   $��15��6.   $��5q�6<   $
 Описание��6\   #��[  6�   $ Arrow��6�   6�   �� 5L      -   5        $��1��5L      $��16��6-   $��Сохранить��6;   $	��150��6O   $
 Hand��6n   5M      5N      5O      5P      5Q      