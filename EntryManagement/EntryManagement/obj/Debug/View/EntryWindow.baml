   M S B A M L   `   `   `  ����J  FEntryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EntryManagement.ViewEntryManagement.View  5   	   &     EntryManagement.View.EntryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EntryManagement.View     5   	      BasicWindowStyle#��[  5   	     � Title$  EntryWindow��5	   	   $	��600��6   $	��300��6*   .��5
      � .+�5   
   �� $	��250��6   $	��400��6   $��23,10,21,162q�6H   ��6)   �� *ImageSource+6H   �� 5   
   -   5         ��Name$ UserNameLabel��5        BasicTitleLabelStyle#��[ 6'   $y�Visible=�6�   $
��Left=�6�   $��
72,462,0,0q�6�   $	��Top=�6�   $	��147��6�   ��6U   ��  �� Path$ ActualMember.LastName�6�   �� 5   
   -   5        $ CompanyLabel��5      #��[ 6&   $y�Visible=�6�   $
��Left=�6�   $��
89,493,0,0q�6�   $	��Top=�6�   $	��130��6�   ��6T   �� $ ActualMember.CompanyName�6�   �� 5   
   -   5        $ MessageLabel��5      #��[ 6&   $y�Hidden=�6T   $��WRONG��6h   $��Center=�6x   $��
72,107,0,0q�6�   $	��Top=�6�   $	��147��6�   5      5      