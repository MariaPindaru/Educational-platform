   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      (    "SchoolPlatform.Views.AdminStudents   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SchoolPlatform.ViewModels     5      BlocalConverter'clr-namespace:SchoolPlatform.Converters     5        N� Title$  AdminStudents��5
       � DataContext 5      *  $SchoolPlatform.ViewModels.AdminLogVM  5   
    � 	Resources 5      0  *SchoolPlatform.Converters.StudentConverter   studentConverter  cellText �� 
TargetType �� Property �� Value 
 header=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	      &	 �       5   
   6*   �� 5   
   " ��6!   .�5      ��  � ��$
 Wrap=�6-   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 5q�6'   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 30��6'   �� 5       � ��
 ���� 6+   �� 5       �@��	ClickMode$ Hover=�6*   5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $
��0.5* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $
��0.3* �6   .+�5(   
   � $��0��6    � ColumnDefinitions 5)      �� 5*      $��* �6#   �� 5+      $��* �6#   �� 5,      $��* �6#   �� 5-      $��* �6#   .+�50      �� -   5        $��0��50      $��Elev nou��51        myButtonStyle#��[ 6(   52      �� 54      $��1��6   $��Adauga elev��55      #��[ 6*   ��56      �� *
AddStudent+��57      `� 58       `� 	Converter# [  6#   .1�59      �� 	 �� ElementName$	 	firstname��6"   
 �� Path$

 Text�6:   �� 5:      $	 lastname��6"   $

 Text�69   �� 5;      $	 username��6"   $

 Text�69   �� 5<      $
	 spec��6"   $

 Text�65   �� 5=      $	 combo��6"   $
 SelectedItem.YearName�66   �� 5>      $	 combo��6"   $
 SelectedItem.Letter�66   �� 5?      $	 password��6"   $

 Text�69   �� 5@      $	 datagrid��6"   $
 SelectedItem.StudentId�69   �� 5A      $	 datagrid��6"   $
 SelectedItem.ClassId�69   �� 5B      $	 datagrid��6"   $"
 SelectedItem.Person.PersonId�69   5C      5E      �� 5G      $��2��6   $��Salveaza modificarile��5H      #��[ 65   ��5I      �� *UpdateStudent+��5J      `� 5K      # [  6#   .1�5L      �� $	 	firstname��6"   $

 Text�6:   �� 5M      $	 lastname��6"   $

 Text�69   �� 5N      $	 username��6"   $

 Text�69   �� 5O      $
	 spec��6"   $

 Text�65   �� 5P      $	 combo��6"   $
 SelectedItem.YearName�66   �� 5Q      $	 combo��6"   $
 SelectedItem.Letter�66   �� 5R      $	 password��6"   $

 Text�69   �� 5S      $	 datagrid��6"   $
 SelectedItem.StudentId�69   �� 5T      $	 datagrid��6"   $
 SelectedItem.ClassId�69   �� 5U      $	 datagrid��6"   $"
 SelectedItem.Person.PersonId�69   5V      5X      �� 5Z      $��3��6   $��Sterge elev��5[      #��[ 6+   ��5\      �� *DeleteStudent+��5]      �� $	 datagrid��$
 SelectedItem�5^      � 5`   
   $��1��6    5a      �� 5b      $��* �6#   �� 5c      $��2* �6#   �� 5d      $��* �6#   �� 5e      $��2* �6#    5h      �� 5i      $��* �6    �� 5j      $��* �6    �� 5k      $��* �6    .+�5n      �� $
��Nume��6   $��Center=�6#   $��0��5o      $��0��6&   $��Center=�5p      
�������$��20(�5r      $��Malgun Gothic)�5s      �� 5t      -   5         ��Name$ lastname��5u   8   $��0��6   $��1��6(   $	��150��5v      $��Center=�6&   ��5t      �� $	 datagrid��$"
 SelectedItem.Person.LastName�5v   &   �� 5x      $��Prenume��6   $��Center=�6&   $��Center=�5y      $��1��5z      $��0��6&   
�������$��20(�5|      $��Malgun Gothic)�5}      �� 5~      -   5        $ 	firstname��5   8   $��1��6   $��1��6(   $	��150��5�      $��Center=�6&   ��5~      �� $	 datagrid��$#
 SelectedItem.Person.FirstName�5�   &   �� 5�      $��Clasa��6   $��Center=�6$   $��Center=�5�      $��0��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5         ��Name$ combo��5�   9   $��0��5�      $��3��6$   $��Center=�64   $	��150��6P   ��5�      �� *	ClassList+��5�      �� 5�      .R�5�      ��  �� Orientation$ 
Horizontal=�6%   .+�5�      �� ��6(   �� *
YearName+�� 5�      ��6(   �� *Letter+5�      5�      5�      �� 5�      $��Specializare��6   $��Center=�6+   $��Center=�5�      $��1��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $
 spec��5�   4    �� 
IsReadOnly . $��1��6   $��3��6$   $	��150��5�      $��Center=�6"   ��5�   (   �� $	 combo��$!
 SelectedItem.Specialization�5�   "   �� 5�      $��Username��6   $��Center=�6'   $��Center=�5�      $��2��5�      $��0��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $ username��5�   4   $��2��6   $��1��6$   $	��150��5�      $��Center=�6"   ��5�      �� $	 datagrid��$"
 SelectedItem.Person.Username�5�   "   �� 5�      $��Parola��6   $��Center=�6%   $��Center=�5�      $��2��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $ password��5�   4   $��2��6   $��3��6$   $	��150��5�      $��Center=�6"   ��5�      �� $	 datagrid��$
 SelectedItem.Password�5�   "   5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ datagrid��5�      $��2��6%      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         
IsReadOnly . ��5�      �� *StudentList+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nume��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Person.LastName+  5�      $ Prenume��6%    66   �� *Person.FirstName+  5�      $ Numar clasa��6%    6:   �� *ClassNumber+  5�      $ Litera clasa��6%    6;   �� *	ClassName+  5�      $ Specializare��6%    6;   �� *Specialization+5�      �� 5�   
   $��Center=�5�        text#��[ 5�      
���  ��$��3��5�   %   ��5�      �� *	Message+5�   %   5�      5�      