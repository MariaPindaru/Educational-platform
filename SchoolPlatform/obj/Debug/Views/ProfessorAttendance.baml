   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      .    (SchoolPlatform.Views.ProfessorAttendance   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SchoolPlatform.ViewModels     5      BlocalConverter'clr-namespace:SchoolPlatform.Converters     5        N� Title$  ProfessorAttendance��5
       � DataContext 5      .  (SchoolPlatform.ViewModels.ProfessorLogVM  5   
    � 	Resources 5      3  -SchoolPlatform.Converters.AttendanceConverter   	Converter  cellText �� 
TargetType �� Property �� Value 
 header=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	      &	 �       5   
   6-   �� 5   
   " ��6!   .�5      ��  � ��$
 Wrap=�6-   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 5q�6'   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 30��6'   �� 5       � ��
 ���� 6+   �� 5       �@��	ClickMode$ Hover=�6*   5      5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��0.5* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $
��0.3* �6   .+�5'   
   � $��0��6    � ColumnDefinitions 5(      �� 5)      $��* �6#   �� 5*      $��* �6#   .+�5-      �� $��0��6   $��Adauga Absenta��5.        myButtonStyle#��[ 6-   ��5/      �� *AddAttedance+��50      `� 51       `� 	Converter# [  6#   .1�52      �� 	 �� Path$)	 #DataContext.CurrentProfessor.ProfID�53   1   
 �� RelativeSource
 52   "   ��  �� Mode$ FindAncestor=� �� AncestorType$
 PageL�53   1   �� 54      $*	 $DataContext.CurrentStudent.StudentId�55   1   
 54   "   �� $ FindAncestor=�$
 PageL�55   1   �� 56       �� ElementName$
 date��6"   $	 SelectedDate�65   �� 57      $ subject��6"   $	 SelectedItem�68   �� 58      $ semester��6"   $	 SelectedItem�69   �� 59      $
 type��6"   $	 SelectedItem.Name�65   5:      5<      �� 5>      $��1��6   $��Motiveaza absenta��5?      #��[ 61   ��5@      �� *
Motivate+��5A      �� *CurrentAttendance+5B      � 5D   
   $��1��6    5E      �� 5F      $��* �6#   �� 5G      $��2* �6#   �� 5H      $��* �6#   �� 5I      $��2* �6#    5L      �� 5M      $��* �6    �� 5N      $��* �6    �� 5O      $��* �6    .+�5R      �� $��Materie��6   $��Center=�6&   $��0��5S      $��0��6&   $��Center=�5T      
�������$��20(�5V      $��Malgun Gothic)�5W      �� 5X      -   5         ��Name$ subject��5Z   M   $��0��5X      $��1��6$   $��Center=�64   $	��150��6P    �� SelectedItem 5Y      �� *	Subject+��5Z      �� *CurrentProfessor.SubjectsList+��5[      �� 5\      .R�5]      �� ��5^      `� 5_   "    �� StringFormat$	 {0}��6/   .1�5`   &   �� $
	 Name�6.   5a   #   5c      5d      5f      �� 5h      $
��Elev��6   $��Center=�6#   $��Center=�5i      $��1��5j      $��0��6&   
�������$��20(�5l      $��Malgun Gothic)�5m      �� 5n      -   5        $ student��5o   ;   $��1��5n      $��1��6$   $��Center=�64   $	��150��6P   ��5o      �� *StudentList+ 5p      �� *CurrentStudent+��5q      �� 5r      .R�5s      �� ��5t      `� 5u   "   $ {0} {1}��6/   .1�5v   &   �� $	 Person.LastName�6.   �� 5w   &   $	 Person.FirstName�6.   5x   #   5z      5{      5}      �� 5      $��Semestru��6   $��Center=�6'   $��Center=�5�      $��2��5�      $��0��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $ semester��5�   9   $��2��5�      $��1��6$   $��Center=�64   $	��150��6P   ��5�      �� *	Semesters+ 5�      �� *CurrentSemester+��5�      �� 5�      .R�5�      �� ��5�      `� 5�   "   $	 {0}��6/   .1�5�   &   �� $	 Number�6.   5�   #   5�      5�      5�      �� 5�      $
��Data��6   $��Center=�6#   $��Center=�5�      $��0��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      (  "System.Windows.Controls.DatePicker  5�      -   5          Name$
 date��5�   4   $��0��6   $��3��6$   $	��150��5�      $��Center=�6"   �� 5�      $	��Tip��6   $��Center=�6"   $��Center=�5�      $��1��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $
 type��5�   ?   $��1��5�      $��3��6$   $��Center=�64   $	��150��6P   ��5�      �� *AttendanceTypes+��5�      �� 5�      .R�5�      �� ��5�      `� 5�   "   $	 {0}��6/   .1�5�   &   �� $
	 Name�6.   5�   #   5�      5�      5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ datagrid��5�      $��2��6%      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         
IsReadOnly . ��5�      �� *CurrentStudent.AttendanceList+ �� UpdateSourceTrigger$ PropertyChanged=� 5�      �� *CurrentAttendance+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Data��6%   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 63   �� *Date+  5�      $ Tip absenta��6%    6:   �� *Type+4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5�      $ Motivata��6)    6;   �� *	Motivated+5�      �� 5�   
   $��Center=�5�        text#��[ 5�      
���  ��$��3��5�   %   ��5�      �� *	Message+5�   %   5�      5�      