   M S B A M L   `   `   `  ����J  FEntryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EntryManagement.ViewEntryManagement.View  5   	   &     EntryManagement.View.UsersWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EntryManagement.View     5   	      BasicWindowStyle#��[  5   
     � Title$  UsersWindow��5	   	   $	��300��6   $	��300��6*   .��5
      � .+�5   
   �� -   5         ��Name$ UsersListView��5   W     BasicListView#��[ 6�   $
��Left=�6�   $	��184��6�   $��	34,10,0,0q�6�   $	��Top=�6�   $	��240��6   �� SelectedItem 61   �� *SelectedUser+��6n   �� *Users+ �� View 5      �� 5      .P�5      ��  �� Width$ 50��6%   $��Id��60    �� DisplayMemberBinding 5   
   �� *Id+�� 5      $	 100��6%   $
��Name��61    5   
   �� *Name+�� 5      $	 100��6%   $��Title��61    5   
   �� *Role+5      5      �� 5   
   -   5         ��Name$ AddNewUserButton��5        BasicButtonStyle#��[ 6+   $��Add new user��6U   $
��Left=�6l   $��
58,222,0,0q�6�   $	��Top=�6�   $��83��6�   6�   �� 5   
   -   5        $ DeleteUserButton��5      #��[ 6+   $��Delete user��6U   $
��Left=�6k   $��163,222,0,0q�6�   $	��Top=�6�   $��83��6�   6�   5      5      