   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5   	       Clinic.UserAppointment   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Clinic     5   	   X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$"  Запись на прием��5	   	   $	��470��6!   $	��500��6.    � Icon$ image/icon.png��6:    � WindowStartupLocation$ CenterScreen=�6P   .��5
      � .+�5   
   �� -   5         ��Name$ Cb_Position��5      $
��Left=�6(   $��
182,20,0,0q�6C   $	��Top=�6W   $	��246��6o   $��16(�6{   $��30��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
DatePicker��5      $
��Left=�6)   $��182,138,0,0q�6D   $	��Top=�6Y   $	��246��6q   $��30��6}   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ 	Cb_Doctor��5      $
��Left=�6&   $��
182,58,0,0q�6A   $	��Top=�6U   $	��246��6m   $��32��6y   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5         ��Name$ 
categories��5      $��Категория��6$   $
��Left=�68   $��	46,17,0,0q�6S   $	��Top=�6f    J� RenderTransformOrigin$ 0.474,0.596&�6~   $��21(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $ doctor��5      $��Доктор��6    $
��Left=�61   $��	46,57,0,0q�6L   $	��Top=�6_   $��21(�6w   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5        $
 date��5      $��Дата��6   $
��Left=�6-   $��
46,135,0,0q�6H   $	��Top=�6\   $��21(�6t   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   "  Xceed.Wpf.Toolkit.TimePicker  5   
   -   5          Name$ 
TimePicker��5      $
��Left=�6.   $��182,182,0,0q�6I   $	��Top=�6^   $��18(�6v   $	��122��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -	   5        $
 time��5      $��
Время��6   $
��Left=�6.   $��
46,173,0,0q�6I   $	��Top=�6]   $��21(�6u   $ 0.486,0.566&�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -
   5        $ Lb_Cause��5      $��Причина��6"   $
��Left=�64   $��
46,219,0,0q�6O   $	��Top=�6c   $��21(�6{   $ 0.486,0.566&�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   �� 5   
   -   5         ��Name$ Tb_Cause��5      $
��Left=�6$   $	��116��6?   $��182,219,0,0q�6L   	 �� TextWrapping$
	 Wrap=�6a   $	��Top=�6v   $	��246��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        
 ��Name$
 
Btn_Accept��5      $��Подтвердить��6%   $
��Left=�6;   $��34��6V   $��182,349,0,0q�6b   $	��Top=�6w   $	��152��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   6�   �� 5   
   -   5        $
 Btn_Back��5      $��Отмена��6#   $
��Left=�64   $��34��6O   $��182,389,0,0q�6[   $	��Top=�6p   $	��152��6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   6�   �� 5   
   -   5        $ 
Cb_Patient��5      $
��Left=�6'   $��
182,98,0,0q�6B   $	��Top=�6V   $	��246��6n   $��32��6z   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   �� 5   
   -   5        $ doctor_Copy��5      $��Пациент��6%   $
��Left=�67   $��	46,98,0,0q�6R   $	��Top=�6e   $��21(�6}   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   5      5      