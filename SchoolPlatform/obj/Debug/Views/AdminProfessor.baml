   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      )    #SchoolPlatform.Views.AdminProfessor   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SchoolPlatform.ViewModels     5      BlocalConverter'clr-namespace:SchoolPlatform.Converters     5        N� Title$  AdminProfessor��5
       � DataContext 5      *  $SchoolPlatform.ViewModels.AdminLogVM  5   
    � 	Resources 5      2  ,SchoolPlatform.Converters.ProfessorConverter   profConv  cellText �� 
TargetType �� Property �� Value 
 header=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	      &	 �       5   
   6,   �� 5   
   " ��6!   .�5      ��  � ��$
 Wrap=�6-   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 5q�6'   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 30��6'   �� 5       � ��
 ���� 6+   �� 5       �@��	ClickMode$ Hover=�6*   5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��0.5* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $
��0.3* �6   .+�5'   
   � $��0��6    � ColumnDefinitions 5(      �� 5)      $��* �6#   �� 5*      $��* �6#   �� 5+      $��* �6#   �� 5,      $��* �6#   .+�5/      �� -   5        $��0��5/      $��Profesor nou��50        myButtonStyle#��[ 6,   51      �� 53      $��1��6   $��Adauga profesor��54      #��[ 6.   ��55      �� *AddProfessor+��56      `� 57       `� 	Converter# [  6#   .1�58      �� 	 �� ElementName$	 	firstname��6"   
 �� Path$

 Text�6:   �� 59      $	 lastname��6"   $

 Text�69   �� 5:      $	 username��6"   $

 Text�69   �� 5;      $	 datagrid��6"   $"
 SelectedItem.Person.PersonId�69   �� 5<      $	 password��6"   $

 Text�69   5=      5?      �� 5A      $��2��6   $��Salveaza modificarile��5B      #��[ 65   ��5C      �� *UpdateProfessor+��5D      `� 5E      # [  6#   .1�5F      �� $	 	firstname��6"   $

 Text�6:   �� 5G      $	 lastname��6"   $

 Text�69   �� 5H      $	 username��6"   $

 Text�69   �� 5I      $	 datagrid��6"   $"
 SelectedItem.Person.PersonId�69   �� 5J      $	 password��6"   $

 Text�69   5K      5M      �� 5O      $��3��6   $��Sterge profesor��5P      #��[ 6/   ��5Q      �� *DeleteProfessor+��69   �� $	 datagrid��$
 SelectedItem�5R      � 5T   
   $��1��6    5U      �� 5V      $��* �6#   �� 5W      $��2* �6#   �� 5X      $��* �6#   �� 5Y      $��2* �6#    5\      �� 5]      $��* �6    �� 5^      $��* �6    .+�5a      �� $
��Nume��6   $��Center=�6#   $��0��5b      $��0��6&   $��Center=�5c      
�������$��20(�5e      $��Malgun Gothic)�5f      �� 5g      -   5         ��Name$ lastname��5h   8   $��0��6   $��1��6(   $	��150��5i      $��Center=�6&   ��5g      �� $	 datagrid��$"
 SelectedItem.Person.LastName�5i   &   �� 5k      $��Prenume��6   $��Center=�6&   $��Center=�5l      $��0��5m      $��2��6&   
�������$��20(�5o      $��Malgun Gothic)�5p      �� 5q      -   5        $ 	firstname��5r   9   $��0��6   $��3��6(   $	��150��5s      $��Center=�6&   ��5q      �� $	 datagrid��$#
 SelectedItem.Person.FirstName�5s   &   �� 5u      $��Username��6   $��Center=�6'   $��Center=�5v      $��1��5w      $��0��6&   
�������$��20(�5y      $��Malgun Gothic)�5z      �� 5{      -   5        $ username��5|   5   $��1��6   $��1��6$   $	��150��5}      $��Center=�6"   ��5{      �� $	 datagrid��$"
 SelectedItem.Person.Username�5}   "   �� 5      $��Parola��6   $��Center=�6%   $��Center=�5�      $��1��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $ password��5�   4   $��1��6   $��3��6#   $	��150��5�      $��Center=�6"   ��5�      �� $	 datagrid��$
 SelectedItem.Password�5�   "   5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ datagrid��5�      $��2��6%      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         
IsReadOnly . ��5�      �� *
ProfList+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nume��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Person.LastName+  5�      $ Prenume��6%    66   �� *Person.FirstName+5�      �� 5�   
   $��Center=�5�        text#��[ 5�      
���  ��$��3��5�   %   ��5�      �� *	Message+5�   %   5�      5�      