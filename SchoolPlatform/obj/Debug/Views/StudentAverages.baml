   M S B A M L   `   `   `  ����I  ESchoolPlatform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SchoolPlatform.ViewModelsSchoolPlatform.ViewModels  5      *    $SchoolPlatform.Views.StudentAverages   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:SchoolPlatform.ViewModels     5        N� Title$  StudentAverages��5	       � DataContext 5      ,  &SchoolPlatform.ViewModels.StudentLogVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   $��Center=�6!   $��Center=�6<   
�������$��20(�5      $��Malgun Gothic)�5      �� 5      $�Media generala: ��6    �� 5      �6   �� *CurrentStudent.FinalAverage+5      �� 5   
   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid��5         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         
IsReadOnly . $��1��65   ��5      �� *)'CurrentStudent.AverageGradeListCombined+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Materie��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *Item1.Subj.Name+  5"      $	 Media semestrul I��6%   
 6@   �� *Item1.Grade+  5#      $	 Media semestrul II��6%   
 6A   �� *Item2.Grade+  5$      $	 Media pe an��6%   
 6:   �� *Item3+5&      5'      5(      