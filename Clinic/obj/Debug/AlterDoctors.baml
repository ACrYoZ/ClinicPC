   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5   	       Clinic.AlterDoctors   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Clinic     5   	   X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$#  Изменить данные��5	   	   $	��480��6!   $	��520��6.    � Icon$ image/icon.png��6:    � WindowStartupLocation$ CenterScreen=�6P   .��5
      � .+�5   
   �� -   5         ��Name$ Tb_Email��5      $
��Left=�6$   $��30��6?   $��
164,29,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6u   $	��300��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ label��5      $��Фамилия��6   $
��Left=�61   $��	19,61,0,0q�6L   $	��Top=�6_   $��21(�6w   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ 
label_Copy��5      $��Имя��6$   $
��Left=�62   $��	19,99,0,0q�6M   $	��Top=�6`   $��21(�6x   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ label_Copy1��5      $��
Почта��6%   $
��Left=�65   $��	19,23,0,0q�6P   $	��Top=�6c   $��21(�6{   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ label_Copy2��5      $��Отчество��6%   $
��Left=�68   $��
19,132,0,0q�6S   $	��Top=�6g   $��21(�6   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ label_Copy3��5      $!��Номер телефона��6%   $
��Left=�6>   $��
19,170,0,0q�6Y   $	��Top=�6m   $��21(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ label_Copy4��5      $!��Номер Паспорта��6%   $
��Left=�6>   $��
19,203,0,0q�6Y   $	��Top=�6m   $��21(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -	   5        $ label_Copy5��5      $��Кабинет��6%   $
��Left=�67   $��
19,236,0,0q�6R   $	��Top=�6f   $��21(�6~   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -
   5        $ Tb_Description��5      $
��Left=�6*   $��74��6E   $��216,292,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��248��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ Lb_Des��5      $��Описание��6    $
��Left=�63   $��
19,292,0,0q�6N   $	��Top=�6b   $��21(�6z   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ 
Tb_Surname��5      $
��Left=�6&   $��30��6A   $��
164,64,0,0q�6N   $
 Wrap=�6b   $	��Top=�6w   $	��300��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ Tb_Name��5      $
��Left=�6#   $��30��6>   $��
164,99,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��300��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ Tb_Patronymic��5      $
��Left=�6)   $��30��6D   $��164,134,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6{   $	��300��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ Tb_Phone��5      $
��Left=�6$   $��30��6?   $��216,169,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $	��248��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ Tb_Passport��5      $
��Left=�6'   $��30��6B   $��216,203,0,0q�6O   $
 Wrap=�6d   $	��Top=�6y   $	��248��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ 	Tb_Parlor��5      $
��Left=�6%   $��30��6@   $��216,241,0,0q�6M   $
 Wrap=�6b   $	��Top=�6w   $	��248��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 	Btn_Alter��5      $��Изменить��6$   $
��Left=�67   $��135,394,0,0q�6R   $	��Top=�6g   $	��120��6   $��33��6�   $��2q�6�   6�   �� 5   
   -   5        $ Btn_Back��5      $��Назады��6#   $
��Left=�64   $��287,394,0,0q�6O   $	��Top=�6d   $	��120��6|   $��33��6�   $��2q�6�   6�   5      5      