   M S B A M L   `   `   `  ����\  XSportSectionsInformationSystem.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:SportSectionsInformationSystem.UI.Pages'SportSectionsInformationSystem.UI.Pages  5      <    6SportSectionsInformationSystem.UI.Pages.PageAddSection   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:SportSectionsInformationSystem.UI.Pages     5      -   5          N� Title$  PageAddSection��5	       N� 
FontFamily$ Georgia)�63    N� 
Background 5
      �� 5   
    �� ImageSource$B </SportSectionsInformationSystem.UI;component/UI/setwalls.png��6   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $2��,Введите название секции��6   $��30(�62   �� 5   
   $��2��6   $G��AВведите название спортивного клуба��6   $��30(�6J   �� 5   
   $��4��6   $%��Введите описание��6   $��30(�69   �� 5   
   -   5        $��textbox_name��5       $��15(�6   $��1��64   $��20q�6A   �� 5    
   -   5        $��textbox_desc��5    4   $��15(�6    �� TextWrapping$
 Wrap=�6    $��5��6H   $��20q�6U   �� 5!   
   -   5        $��combobox_sportclub��5!      $��3��6-   $��20,20,20,20q�6:   5#      �� 5$   
   $��6��6   $��30(�6   $C��=Введите стоимость одного занятия��6,   �� 5%   
   -   5        $��textbox_price��5%       $��15(�6   $��7��65   $��20q�6B   �� 5&   
   -   5        $��1��5&      $��500,20,20,20q�6"   ��68   Z� .��5'      �� $R��L/SportSectionsInformationSystem.UI;component/UI/New-arrow-303271_960_720.png��6   5(      �� 5)   
   -   5        $��list_week_time��5)       $��15(�6   $��1��66   $��3��6F   $��1��6W   $��20q�6d   �� 5*   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��4��6>   $��20q�6K   $��Center=�6W   .+�5+      �� -   5        $��50��5+      $��+��6    $��10q�6,   68   �� 5,      -	   5        $��combobox_weekday��5,      $	��170��6/   $��10q�6;   �� 5-      -
   5        $��textbox_time��5-      $	��170��6*   $��10q�66   �� 5.      -   5        $��50��5.      $��Х��6    $��10q�6,   68   5/      �� 50   
   -   5        $��buttonAddEdit��50      $��1��6&   $��7��66   $��200,20q�6C   $��Добавить��6S   6f   51      52      