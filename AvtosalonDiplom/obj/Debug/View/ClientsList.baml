   M S B A M L   `   `   `  ����J  FAvtosalonDiplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:AvtosalonDiplom.ViewAvtosalonDiplom.View  5      &     AvtosalonDiplom.View.ClientsList   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:AvtosalonDiplom.View     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  ClientsList��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ Search��5      $��0��6&   $��5q�66   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$Q KПоиск по Ф.И.О или серии и номеру паспорта��6A    %  !MaterialDesignFloatingHintTextBox#��[  6�    � Cursor$ Arrow��6�   6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	ClientsDG��5       $��1��6      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Ф.И.О��6>   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *FIO+6>     5      $	 Телефон��6@   
 6%   �� *Phone+6@     5      $	 Дата рождения��6C   
 6%   �� *
Birthday+6C     5      $	 
Адрес��6A   
 6%   �� *Adress+6A     5      $	 Email��6@   
 6%   �� *Email+6@     5      $1	 +Сериия и номер паспорта��6H   
 6%   �� *PasportNumber+6H   5      5      5       