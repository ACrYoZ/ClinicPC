   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5   	       Clinic.DiagnosisUser   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Clinic     5   	   -   5        $	��600��5      $	��800��6'     � Title$/  )Диагностика пациентов��63    � Icon$ image/icon.png��6h    � WindowStartupLocation$ CenterScreen=�6~   $	��600��6�   $	��800��6�   $	��600��6�   $	��800��6�   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $	��65* �6   �� 5      $
��183* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DiagnosisGrid��5   /      AutoGenerateColumns .     
IsReadOnly . ���	#FFE2E2E2$��0,0,0,47q�6p   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��16(�6�   $��2��6�    � 	Resources 5         CustomHeaderTemplate��%c   &	        �� 5      .R�5      �� .+�5      �� ��6$   �� *Name+5      5      5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Пациент ��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Patient+6S     5      $
 Диагноз��6C   $ * 6T    6%   �� *	diagnosis+6T     5      $
 Лечение��6D   $ * 6U    6%   �� *
medication+6U   5      �� 5   
   -   5         ��Name$ Btn_Back��5      $��
Назад��6#   $
��Left=�63   $��112,520,0,0q�6N   $	��Top=�6c   $	��148��6{   $��16(�6�   $)��#/Clinic;component/Fonts/#Gotham Pro)�6�   $��38��6�   $��1��6�   5!      5"      