   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5   	       Clinic.MainWindows   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Clinic     5   	     � Title$  myClinic��5   	   $	��470��6   $	��600��6'    � WindowStartupLocation$ CenterScreen=�63   
���   �$��0q�6l   $	��600��6�   $	��600��6�   $	��470��6�   $	��470��6�    � Icon$ image/icon.png��6�   ��5
      �� 5   
    �� ImageSource$ image/MyBackground.jpg��6   .��5      � -   5        $
��grid��5       � ColumnDefinitions 5   
   �� 5      $
��439* �6   �� 5      $
��153* �6   .+�5   
   �� -   5         ��Name$ Tb_Mail��5      $��29��6#   $��172,222,0,0q�6/    �� TextWrapping$
 Wrap=�6D   $�� ��6X   $	��Top=�6`   $��2q�6x   ���	#FFAEAEAE$)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   G� 5   
   -   5         G�Name$ Tb_Password��5      $��29��6+   $��172,259,0,0q�67   $	��Top=�6L   $��2q�6d   ���	#FFAEAEAE$)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 
label_Mail��5      $��
Почта��6$   $
��Left=�64   $��
85,222,0,0q�6O   $	��Top=�6c   $��16(�6{   $��29��6�   $��67��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ label_Password��5      $��Пароль��6(   $
��Left=�69   $��
85,259,0,0q�6T   $	��Top=�6h   $��16(�6�   $��29��6�   $��79��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        	 ��Name$	 	Btn_Enter��5      $��
Войти��6$   $
��Left=�64   $��252,318,0,0q�6O   $	��Top=�6d   $	��100��6|   $��35��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   ���	#FFE0E0E0$��14(�6�   ���	#FF9E9E9E
 �� 	IsDefault
 . $��2q�6+  �� 5   
   -   5        $ Tb_RegistryName��5      $
��Left=�6+   $��23��6F   $��
150,93,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��200��6�   $y�	Collapsed=�6�   �� 5   
   -   5        $ Tb_RegistrySurname��5      $
��Left=�6.   $��23��6I   $��150,124,0,0q�6U   $
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��200��6�   $y�	Collapsed=�6�   �� 5   
   -	   5        $ Tb_RegistryPatronymic��5      $
��Left=�61   $��23��6L   $��150,159,0,0q�6X   $
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��200��6�   $y�	Collapsed=�6�   �� 5   
   -
   5        $ Tb_RegistryPhoneNumber��5      $
��Left=�62   $��23��6M   $��150,196,0,0q�6Y   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��200��6�   $y�	Collapsed=�6�   �� 5   
   -   5        $ Tb_RegistryPassportNumber��5      $
��Left=�65   $��23��6P   $��150,226,0,0q�6\   $
 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��200��6�   $y�	Collapsed=�6�   5!      5"      