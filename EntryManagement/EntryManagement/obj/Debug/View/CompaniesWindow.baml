   M S B A M L   `   `   `  ����J  FEntryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EntryManagement.ViewEntryManagement.View  5   	   *    $EntryManagement.View.CompaniesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EntryManagement.View     5   	      BasicWindowStyle#��[  5        � Title$  CompaniesWindow��5	   	   $	��600��6!   $	��800��6.   .��5
      � .+�5   
   �� -   5         ��Name$ CompaniesListView��5        BasicListView#��[ 6/   $
��Left=�6�   $	��549��6�   $��	10,10,0,0q�6  $	��Top=�6  $	��268��6,   �� SelectedItem 6W   �� *SelectedCompany+��6�   �� *	Companies+ �� View 5      �� 5      .P�5      ��  �� Width$ 30��6%   $��Id��60    �� DisplayMemberBinding 5   
   �� *Id+�� 5      $	 200��6%   $
��Name��61    5   
   �� *Name+5      5      � 5   
   $
��Left=�6   $	��200��6*   $��
349,10,0,0q�67   $	��Top=�6K   $	��384��6c   .+�5      �� $
��Left=�6   $	��100��64   $��
143,95,0,0q�6A   $	��Top=�6U   $	��100��6m   �� 5      -   5         ��Name$ SelectedCompanyNameLabel��5        BasicTitleLabelStyle#��[ 67   $
��Left=�6�   $��	72,10,0,0q�6�   $	��Top=�6�   $��42��6�   $	��240��6�   ��6e   ��  �� Path$ SelectedCompany.Name�6�   �� 5      -   5        $  SelectedCompanyNameAddress��5      #��[ 69   $
��Left=�6�   $��	72,77,0,0q�6�   $	��Top=�6�   $��42��6�   $	��240��6�   ��6h   �� $ SelectedCompany.Address�6�   �� 5      -   5        $ SelectedCompanyNamePhone��5      #��[ 68   $
��Left=�6�   $��
72,153,0,0q�6�   $	��Top=�6�   $��42��6�   $	��240��6�   ��6f   �� $ SelectedCompany.Phone�6�   5      �� 5   
   -   5        $ MembersOfCompanyListView��5   j   #��[ 6B   $
��Left=�6�   $	��262��6�   $��367,297,0,0q�6�   $	��Top=�6�   $	��330��6  ��6�   �� *MembersOfSelectedCompany+ 5      �� 5      .P�5      �� $ 30��6%   $��Id��60    5    
   �� *Id+�� 5!      $	 100��6%   $��
First name��61    5"   
   �� *	FirstName+�� 5#      $	 100��6%   $��	Last name��61    5$   
   �� *
LastName+�� 5%      $	 100��6%   $��Title��61    5&   
   �� *Title+5'      5)      �� 5*   
   -   5         ��Name$ AddNewCompanyButton��5*        BasicButtonStyle#��[ 6.   $y�Hidden=�6X   $��Add new company��6l   $
��Left=�6�   $��550,242,0,0q�6�   $	��Top=�6�   $	��117��6�   6�   �� 5+   
   -   5        $ DeleteCompanyButton��5+      #��[ 6.   $y�Hidden=�6X   $��Delete company��6l   $
��Left=�6�   $��388,242,0,0q�6�   $	��Top=�6�   $	��117��6�   6�   5-      5.      