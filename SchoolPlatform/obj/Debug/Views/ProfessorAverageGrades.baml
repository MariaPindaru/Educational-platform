   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      1    +SchoolPlatform.Views.ProfessorAverageGrades   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SchoolPlatform.ViewModels     5      BlocalConverter'clr-namespace:SchoolPlatform.Converters     5        N� Title$  ProfessorAverageGrades��5
       � DataContext 5      .  (SchoolPlatform.ViewModels.ProfessorLogVM  5   
    � 	Resources 5      5  /SchoolPlatform.Converters.AverageGradeConverter   gradeConverter  cellText �� 
TargetType �� Property �� Value 
 header=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	      &	 �       5   
   6/   �� 5   
   " ��6!   .�5      ��  � ��$
 Wrap=�6-   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 5q�6'   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 30��6'   �� 5       � ��
 ���� 6+   �� 5       �@��	ClickMode$ Hover=�6*   5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $
��0.5* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $
��0.3* �6   .+�5(   
   � $��0��6   .+�5*      �� $��0��6   $��Seteaza media��5+        myButtonStyle#��[ 6,   ��5,      �� *
AddAverage+��5-      `� 5.       `� 	Converter# [  6#   .1�5/      ��  �� Path$) #DataContext.CurrentProfessor.ProfID�50   1   	 �� RelativeSource	 5/   "   �� 
 �� Mode$
 FindAncestor=� �� AncestorType$
 PageL�50   1   �� 51      $* $DataContext.CurrentStudent.StudentId�52   1   	 51   "   �� $
 FindAncestor=�$
 PageL�52   1   �� 53       �� ElementName$ average��6"   $
 Text�68   �� 54      $ subject��6"   $ SelectedItem�68   �� 55      $ semester��6"   $ SelectedItem�69   56      58      59      � 5;   
   $��1��6    � ColumnDefinitions 5<      �� 5=      $��* �6#   �� 5>      $��2* �6#   �� 5?      $��* �6#   �� 5@      $��2* �6#    5C      �� 5D      $��* �6    �� 5E      $��* �6    �� 5F      $��* �6    .+�5I      �� $��Materie��6   $��Center=�6&   $��0��5J      $��0��6&   $��Center=�5K      
�������$��20(�5M      $��Malgun Gothic)�5N      �� 5O      -   5         ��Name$ subject��5Q   M   $��0��5O      $��1��6$   $��Center=�64   $	��150��6P    �� SelectedItem 5P      �� *	Subject+��5Q      �� *CurrentProfessor.SubjectsList+��5R      �� 5S      .R�5T      �� ��5U      `� 5V   "    �� StringFormat$	 {0}��6/   .1�5W   &   �� $
 Name�6.   5X   #   5Z      5[      5]      �� 5_      $
��Elev��6   $��Center=�6#   $��Center=�5`      $��1��5a      $��0��6&   
�������$��20(�5c      $��Malgun Gothic)�5d      �� 5e      -   5        $ student��5f   ;   $��1��5e      $��1��6$   $��Center=�64   $	��150��6P   ��5f      �� *StudentList+ 5g      �� *CurrentStudent+��5h      �� 5i      .R�5j      �� ��5k      `� 5l   "   $ {0} {1}��6/   .1�5m   &   �� $ Person.LastName�6.   �� 5n   &   $ Person.FirstName�6.   5o   #   5q      5r      5t      �� 5v      $��Semestru��6   $��Center=�6'   $��Center=�5w      $��2��5x      $��0��6&   
�������$��20(�5z      $��Malgun Gothic)�5{      �� 5}      -   5        $ semester��5~   9   $��2��5}      $��1��6$   $��Center=�64   $	��150��6P   ��5~      �� *	Semesters+ 5      �� *CurrentSemester+��5�      �� 5�      .R�5�      �� ��5�      `� 5�   "   $	 {0}��6/   .1�5�   &   �� $ Number�6.   5�   #   5�      5�      5�      �� 5�      $��Media��6   $��Center=�6$   $��Center=�5�      $��1��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5         ��Name$ average��5�   4    �� 
IsReadOnly . $��1��6   $��3��6$   $	��150��5�      $��Center=�6"   ��5�   (   �� *	Average+5�   "   5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ datagrid��5�      $��2��6%      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         
IsReadOnly . ��5�      �� *CurrentStudent.GradeList+ �� UpdateSourceTrigger$ PropertyChanged=� 5�      �� *CurrentGrade+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nota��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Grade+  5�      $
 Data��6%    63   �� *Date+  5�      $ 	Semestrul��6%    68   �� *Semester.Number+4	  .System.Windows.Controls.DataGridCheckBoxColumn	  5�      $
 Teza��6)    67   �� *Final+5�      �� 5�   
   $��Center=�5�        text#��[ 5�      
���  ��$��3��5�   %   ��5�      �� *	Message+5�   %   5�      5�      