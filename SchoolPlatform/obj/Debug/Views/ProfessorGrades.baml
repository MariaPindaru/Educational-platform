   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      *    $SchoolPlatform.Views.ProfessorGrades   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SchoolPlatform.ViewModels     5      BlocalConverter'clr-namespace:SchoolPlatform.Converters     5        N� Title$  ProfessorGrades��5
       � DataContext 5      .  (SchoolPlatform.ViewModels.ProfessorLogVM  5   
    � 	Resources 5      .  (SchoolPlatform.Converters.GradeConverter   gradeConverter  cellText �� 
TargetType �� Property �� Value 
 header=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	      &	 �       5   
   6(   �� 5   
   " ��6!   .�5      ��  � ��$
 Wrap=�6-   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 5q�6'   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 30��6'   �� 5       � ��
 ���� 6+   �� 5       �@��	ClickMode$ Hover=�6*   5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      $
��0.5* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $
��0.3* �6   .+�5(   
   � $��0��6    � ColumnDefinitions 5)      �� 5*      $��* �6#   �� 5+      $��* �6#   .+�5.      �� $��0��6   $��Adauga Nota��5/        myButtonStyle#��[ 6*   ��50      �� *
AddGrade+��51      `� 52       `� 	Converter# [  6#   .1�53      �� 	 �� Path$)	 #DataContext.CurrentProfessor.ProfID�54   1   
 �� RelativeSource
 53   "   ��  �� Mode$ FindAncestor=� �� AncestorType$
 PageL�54   1   �� 55      $*	 $DataContext.CurrentStudent.StudentId�56   1   
 55   "   �� $ FindAncestor=�$
 PageL�56   1   �� 57       �� ElementName$ grade��6"   $	 SelectedItem�66   �� 58      $
 date��6"   $	 SelectedDate�65   �� 59      $ subject��6"   $	 SelectedItem�68   �� 5:      $ semester��6"   $	 SelectedItem�69   �� 5;      $ final��6"   $	 	IsChecked�66   5<      5>      �� 5@      $��1��6   $��Sterge nota��5A      #��[ 6+   ��5B      �� *DeleteGrade+��5C      �� *CurrentGrade+5D      � 5F   
   $��1��6    5G      �� 5H      $��* �6#   �� 5I      $��2* �6#   �� 5J      $��* �6#   �� 5K      $��2* �6#    5N      �� 5O      $��* �6    �� 5P      $��* �6    �� 5Q      $��* �6    .+�5T      �� $��Materie��6   $��Center=�6&   $��0��5U      $��0��6&   $��Center=�5V      
�������$��20(�5X      $��Malgun Gothic)�5Y      �� 5Z      -   5         ��Name$ subject��5\   M   $��0��5Z      $��1��6$   $��Center=�64   $	��150��6P    �� SelectedItem 5[      �� *	Subject+��5\      �� *CurrentProfessor.SubjectsList+��5]      �� 5^      .R�5_      �� ��5`      `� 5a   "    �� StringFormat$	 {0}��6/   .1�5b   &   �� $
	 Name�6.   5c   #   5e      5f      5h      �� 5j      $
��Elev��6   $��Center=�6#   $��Center=�5k      $��1��5l      $��0��6&   
�������$��20(�5n      $��Malgun Gothic)�5o      �� 5p      -   5        $ student��5q   ;   $��1��5p      $��1��6$   $��Center=�64   $	��150��6P   ��5q      �� *StudentList+ 5r      �� *CurrentStudent+��5s      �� 5t      .R�5u      �� ��5v      `� 5w   "   $ {0} {1}��6/   .1�5x   &   �� $	 Person.LastName�6.   �� 5y   &   $	 Person.FirstName�6.   5z   #   5|      5}      5      �� 5�      $��Semestru��6   $��Center=�6'   $��Center=�5�      $��2��5�      $��0��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $ semester��5�   9   $��2��5�      $��1��6$   $��Center=�64   $	��150��6P   ��5�      �� *	Semesters+ 5�      �� *CurrentSemester+��5�      �� 5�      .R�5�      �� ��5�      `� 5�   "   $	 {0}��6/   .1�5�   &   �� $	 Number�6.   5�   #   5�      5�      5�      �� 5�      $
��Nota��6   $��Center=�6#   $��Center=�5�      $��0��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $ grade��5�   4    �� 
IsReadOnly . $��0��6   $��3��6$   $	��150��5�      $��Center=�6"   ��5�   )   �� *Grades+5�   "   �� 5�      $
��Data��6   $��Center=�6#   $��Center=�5�      $��1��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      (  "System.Windows.Controls.DatePicker  5�      -   5          Name$
 date��5�   4   $��1��6   $��3��6$   $	��150��5�      $��Center=�6"   �� 5�      $
��Teza��6   $��Center=�6#   $��Center=�5�      $��2��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5         ��Name$ final��5�   4   $��2��6   $��3��6$   $��Center=�5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ datagrid��5�      $��2��6%      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         
IsReadOnly . ��5�      �� *CurrentStudent.GradeList+ �� UpdateSourceTrigger$ PropertyChanged=� 5�      �� *CurrentGrade+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nota��6%   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 63   �� *Grade+  5�      $
 Data��6%    63   �� *Date+  5�      $ 	Semestrul��6%    68   �� *Semester.Number+4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5�      $
 Teza��6)    67   �� *Final+5�      �� 5�   
   $��Center=�5�        text#��[ 5�      
���  ��$��3��5�   %   ��5�      �� *	Message+5�   %   5�      5�      