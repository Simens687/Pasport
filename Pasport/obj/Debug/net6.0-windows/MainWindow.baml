   M S B A M L   `   `   `  ����B  >Pasport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PasportPasport  5   	       Pasport.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Pasport     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
���   � � RowDefinitions 5
   
   �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6    � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5       $
��0.1* �6   �� 5!      �� 5"      $
��0.1* �6   �� 5#      �� 5$      $
��0.1* �6   .+�5'   
   �� -   5        $��1��5'      $��3��6   $��3��6.   $��Паспорт��6B   $��30(�6T      MyButtonStyle#���   6t   �� 5(   
   -   5        $��1��5(      $��7��6   $��3��6.   $��Личные данные��6B   $��30(�6Z   #���   6z   �� 5*   
   -   5        $��1��5*      $��11��6   $��Сохранить��6/   $��20(�6C     MyMiniButtonStyle#���  6^   �� 5+   
   -   5        $��1��5+      $��1��6   $��Выгрузить��6.   $��20(�6B   #���  6_    � 5-   
   -   5        $��Page___��5-   S   $��2��6   $��0��6   $��9��6-   $��13��6>     � NavigationUIVisibility$ Hidden=�6b   5.      5/      