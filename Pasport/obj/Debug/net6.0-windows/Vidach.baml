   M S B A M L   `   `   `  ����B  >Pasport, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PasportPasport  5          Pasport.Vidach   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Pasport     5        N� Title$  Vidach��5	      .��5      � 
���   � � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6    � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   �� 5      �� 5       $
��0.1* �6   �� 5!      �� 5"      $
��0.1* �6   .+�5%   
   �� $��3��6   $��1��6$   $��Серия и номер:��61   $��Center=�6G   $��Center=�6d   $��30(�6   $
��Wrap=�6�      MyTextBlockStyle#���   6�   �� 5&   
   -   5        $��Ser_and_num_bx��5&   l   $��5��6   $��1��6"   $��5��6/   $��30(�6C   $��Center=�6Q     MyTextBoxStyle#���  6�   �� 5(   
   $��3��6   $��3��6$   $��Выдан:��61   $��Center=�6?   $��Center=�6\   $��35(�6w   #���   6�   �� 5)   
   -   5        $��Vidan_bx��5)   l   $��5��6   $��3��6"   $��5��6/   $��30(�6C   $��Center=�6Q   #���  6|   �� 5+   
   $��3��6   $��5��6$   $��Дата выдачи:��61   $��28(�6E   $
��Wrap=�6S   $��Center=�6g   $��Center=�6�   #���   6�   (  "System.Windows.Controls.DatePicker  5,   
   -   5        $��Date_vid_pik��5,   j   $��5��6   $��5��6%   $��Center=�62   $��Center=�6O     MyDatePikerStyle#���  6~   �� 5.   
   $��7��6   $��5��6$   $(��"Код подразделения:��61   $��20(�6K   $
��Wrap=�6Y   $��1��6m   $��Center=�6�   $��Center=�6�   #���   6�   �� 5/   
   -   5        $��Code_bx��5/   X   $��9��6   $��5��6"   $��28(�6/   $��Center=�6=   #���  6g   51      52      