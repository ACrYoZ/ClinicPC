   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5   	       Clinic.AppendRecord   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Clinic     5   	   -   5          � Title$  Запись ��5   	   $	��500��6   $	��680��6&    � WindowStartupLocation$ CenterScreen=�62   $��1q�6W   $	��500��6�   $	��680��6�   $	��680��6�   $	��500��6�    � Icon$ image/icon.png��6�   .��5	      � 
�������.+�5
   
   �� -   5         ��Name$ 
Lb_Patient��5
      $��Пациент��6$   $
��Left=�66   $��	49,23,0,0q�6Q   $	��Top=�6d   $��22(�6|   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5         ��Name$ 
Tb_Patient��5      $
��Left=�6&   $��30��6A   $��
301,27,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��325��6�   $��18(�6�   $��1q�6�   
���   �$)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5         ��Name$ Record��5      $��Запись��6!   $
��Left=�62   $��32��6M   $��210,394,0,0q�6Y   $	��Top=�6n   $	��110��6�   $��18(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $
 Exit��5      $��
Назад��6   $
��Left=�6/   $��32��6J   $��349,394,0,0q�6V   $	��Top=�6k   $	��110��6�   $��18(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ 
Lb_Diagnos��5      $��Диагноз��6$   $
��Left=�66   $��
49,130,0,0q�6Q   $	��Top=�6e   $��22(�6}   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ 
Tb_Diagnos��5      $
��Left=�6&   $��62��6A   $��301,130,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��325��6�   $��18(�6�   $��1q�6�   
���   �$)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ Lb_Medication��5      $)��#Назначение лечения��6'   $
��Left=�6D   $��
49,213,0,0q�6_   $	��Top=�6s   $��22(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -	   5        $ Tb_Medication��5      $
��Left=�6)   $��62��6D   $��301,213,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��325��6�   $��18(�6�   $��1q�6�   
���   �$)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -
   5        $ Lb_Medication_Copy��5      $"��Явился на прием��6,   $
��Left=�6F   $��
49,294,0,0q�6a   $	��Top=�6u   $��22(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ label��5      $��Дата и время��6   $
��Left=�66   $��	49,76,0,0q�6Q   $	��Top=�6d   $��22(�6|   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ Tb_Date��5      $
��Left=�6#   $��30��6>   $��
301,80,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��325��6�   $��18(�6�   $��1q�6�   
���   �$)��#/Clinic;component/Fonts/#Gotham Pro)�6�   	� 5   
   -   5         	�Name$ Rb_Yes��5       	� 	GroupName$ YesNo��6&   $
��Да��68   $
��Left=�6E   $��302,300,0,0q�6`   $	��Top=�6u   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   	 � LayoutTransform	 5      �� 5      
 �� ScaleX$
 2Q�6!    �� ScaleY$ 2Q�6,   5      	� 5   
   -   5        $ Rb_No��5      $ YesNo��6%   $��Нет��67   $
��Left=�6E   $��404,300,0,0q�6`   $	��Top=�6u   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   	 5      �� 5      $
 2Q�6!   $ 2Q�6,   5       5"      5#      