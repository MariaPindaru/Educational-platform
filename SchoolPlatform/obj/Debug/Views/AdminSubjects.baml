   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      E'clr-namespace:SchoolPlatform.ConvertersSchoolPlatform.Converters  5      (    "SchoolPlatform.Views.AdminSubjects   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SchoolPlatform.ViewModels     5      BlocalConverter'clr-namespace:SchoolPlatform.Converters     5        N� Title$  AdminSubjects��5
       � DataContext 5      *  $SchoolPlatform.ViewModels.AdminLogVM  5   
    � 	Resources 5      0  *SchoolPlatform.Converters.SubjectConverter   subj9  3SchoolPlatform.Converters.SubjectProfessorConverter  sp  cellText �� 
TargetType �� Property �� Value 
 header=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  &	        &	      &	 &     &	 �       5   
   6*     5   
   63   �� 5   
   " ��6!   .�5      ��  � ��$
 Wrap=�6-   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 5q�6'   5      �� 5   
   "  6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ 30��6'   �� 5       � ��
 ���� 6+   �� 5       �@��	ClickMode$ Hover=�6*   5      5       .��5!      �  � RowDefinitions 5"   
   �� 5#      $
��0.5* �6   �� 5$      $
��0.5* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $
��0.3* �6   .+�5*   
   � $��0��6    � ColumnDefinitions 5+      �� 5,      $��* �6#   �� 5-      $��* �6#   �� 5.      $��* �6#   �� 5/      $��* �6#   .+�52      �� -   5        $��0��52      $��Materie noua��53        myButtonStyle#��[ 6,   54      �� 56      $��1��6   $��Adauga materie��57      #��[ 6-   ��58      �� *
AddSubject+��59      `� 5:       `� 	Converter# [  6#   .1�5;      �� 	 �� ElementName$	 	datagrid1��6"   
 �� Path$
 SelectedItem.SubjectID�6:   �� 5<      $	 subject��6"   $

 Text�68   5=      5?      �� 5@      $��2��6   $��Salveaza materia��5A      #��[ 60   ��5B      �� *UpdateSubject+��5C      `� 5D      # [  6#   .1�5E      �� $	 	datagrid1��6"   $
 SelectedItem.SubjectID�6:   �� 5F      $	 subject��6"   $

 Text�68   5G      5I      �� 5K      $��3��6   $��Sterge materie��5L      #��[ 6.   ��5M      �� *DeleteSubject+��5N      �� $	 	datagrid1��$
 SelectedItem�5O      � 5P   
   $��1��6    5Q      �� 5R      $��* �6#   �� 5S      $��* �6#   .+�5V      �� $��0��6   $��Adauga legatura��5W      #��[ 6.   ��5X      �� *	AddLinkSP+��5Y      `� 5Z      # [ 6#   .1�5[      �� $	 	datagrid1��6"   $
 SelectedItem.SubjectID�6:   �� 5\      $	 subject��6"   $

 Text�68   �� 5]      $	 	datagrid2��6"   $"
 SelectedItem.Person.PersonId�6:   �� 5^      $	 	datagrid2��6"   $"
 SelectedItem.Person.LastName�6:   �� 5_      $	 	datagrid2��6"   $#
 SelectedItem.Person.FirstName�6:   5`      5b      �� 5d      $��1��6   $��Sterge legatura��5e      #��[ 6/   ��5f      �� *DeleteLinkSP+��5g      `� 5h      # [ 6#   .1�5i      �� $	 	datagrid1��6"   $
 SelectedItem.SubjectID�6:   �� 5j      $	 subject��6"   $

 Text�68   �� 5k      $	 	datagrid2��6"   $"
 SelectedItem.Person.PersonId�6:   �� 5l      $	 	datagrid2��6"   $"
 SelectedItem.Person.LastName�6:   �� 5m      $	 	datagrid2��6"   $#
 SelectedItem.Person.FirstName�6:   5n      5p      5q      � 5s   
   $��2��6    5t      �� 5u      $
��1.5* �6#   �� 5v      $
��1.5* �6#   �� 5w      $
��1.5* �6#   �� 5x      $
��1.5* �6#    5{      �� 5|      $��* �6    .+�5      �� $��Denumire materie��6   $��Center=�6/   $��	30, 0,0,0q�6M   $��0��5�      $��0��6&   $��Center=�5�      
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5         ��Name$ subject��5�      $��0��6(   $��1��65   $
��Left=�5�      $	��150��5�      $��Center=�6&   ��5�   E   �� $	 	datagrid1��$
 SelectedItem.Name�5�   &   �� 5�      $��Profesor��6   $��Center=�6'   $��Center=�5�      $��0��5�      $��2��6&   
�������$��20(�5�      $��Malgun Gothic)�5�      �� 5�      -   5        $
 prof��5�      $��0��6'   $��3��64   $
��Left=�5�      $��Center=�5�      $	��150��63    �� 
IsReadOnly . .��5�   )   ��5�      `� 5�       �� StringFormat$ {0} {1}��6#   .1�5�      �� $	 	datagrid2��6"   $"
 SelectedItem.Person.LastName�6:   �� 5�      $	 	datagrid2��6"   $#
 SelectedItem.Person.FirstName�6:   5�      .��5�       5�      5�      �� 5�   
   $��Center=�5�        text#��[ 5�      
���  ��$��4��5�   %   ��5�      �� *	Message+5�   %   � 5�   
   $��3��6    5�      �� 5�      $��* �6#   �� 5�      $��* �6#   .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ 	datagrid1��5�      $��0��6*      AutoGenerateColumns .  $��50,10,50,10q�6V      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�         
IsReadOnly . ��5�      �� *SubjectList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5�   5   �� *CurrentSubject+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Denumire materie��6)   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6C   �� *Name+5�        5�      -   5        $ 	datagrid2��5�      $��1��6*    .  $��50,10,50,10q�6V   $ * 5�       . ��5�      �� *
ProfList+$ PropertyChanged=� 5�   5   �� *CurrentProfessor+ 5�        5�      $
 Nume��6)    67   �� *Person.LastName+  5�      $ Prenume��6)    6:   �� *Person.FirstName+5�      5�      5�      5�      