   M S B A M L   `   `   `  ����J  FAvtosalonDiplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AvtosalonDiplom.ViewAvtosalonDiplom.View  5      $    AvtosalonDiplom.View.SellsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AvtosalonDiplom.View     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	SellsList��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��40 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��400 �6#   �� 5      $
��200* �6#   �� 5      $��20 �6#   �� 5      $
��200* �6#   .+�5      �� -   5         ��Name$ Search��5      $��0��6&   $��	13 0 0 10q�66   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$_ YПоиск по Ф.И.О, VIN-коду или серии и номеру паспорта��6I    %  !MaterialDesignFloatingHintTextBox#��[  6�    � Cursor$ Arrow��6�   6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ CBSortDateAfter��5      $��1��62   $
 От��6B   $��10q�6h   6t     5      -   5        $ CBSortDateBefore��5      $��3��63   $
 До��6C   $��10q�6i   6u   5      �� 5   
   $��1��6   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ SellsDG��5   0   $��1��6   $��10q�6$      AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Марка авто��6G   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
CarBrand+6G     5!      $ Модель авто��6G    6)   �� *
ModelCar+6G     5"      $ Год выпуска��6G    6)   �� *
YearAuto+6G     5#      $ Цена��6C    6)   �� *Cost+6C     5$      $ Цвет��6D    6)   �� *Color+6D     5%      $ 
VIN-код��6B    6)   �� *VIN+6B     5&      $ Дата продажи��6K    6)   �� *DateProdazhi+6K     5'      $ Ф.И.О. клиента��6B    6)   �� *FIO+6B     5(      $ Телефон��6D    6)   �� *Phone+6D     5)      $ Дата рождения��6G    6)   �� *
Birthday+6G     5*      $ 
Адрес��6E    6)   �� *Adress+6E     5+      $/ )Серия и номер паспорта��6L    6)   �� *PasportNumber+6L   5-      5.      �� 5/   
   -   5        $��2��5/      $��Right=�6   $3��-Создать отчет о продажах��6:     MaterialDesignFlatButton#��[ 6]   $
 Hand��6�   6�   50      51      