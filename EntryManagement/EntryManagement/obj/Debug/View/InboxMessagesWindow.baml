   M S B A M L   `   `   `  ����J  FEntryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EntryManagement.ViewEntryManagement.View  5   	   .    (EntryManagement.View.InboxMessagesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EntryManagement.View     5   	      BasicWindowStyle#��[  5   
     � Title$  InboxMessagesWindow��5	   	   $	��600��6%   $	��800��62   .��5
      � .+�5   
   �� -   5         ��Name$ MessagesListView��5        BasicListView#��[ 6y   $
��Left=�6�   $	��580��6�   $��	10,10,0,0q�6�   $	��Top=�6�   $	��380��6   �� SelectedItem 6-   �� *SelectedMessage+��6�   �� *
Messages+ �� View 5      �� 5      .P�5      ��  �� Width$ 30��6%   $��Id��60    �� DisplayMemberBinding 5   
   �� *Id+�� 5      $	 200��6%   $��Subject��61    5   
   �� *	Subject+�� 5      $	 150��6%   $��Company name��61    5   
   �� *CompanyName+5      5      � 5   
   $
��Left=�6   $	��345��6*   $��
349,10,0,0q�67   $	��Top=�6K   $	��384��6c   .+�5      �� $
��Left=�6   $	��100��64   $��
143,95,0,0q�6A   $	��Top=�6U   $	��100��6m   �� 5      -   5         ��Name$! SelectedMessageSubjectLabel��5        BasicTitleLabelStyle#��[ 69   $
��Left=�6�   $��	72,10,0,0q�6�   $	��Top=�6�   $��42��6�   $	��240��6�   ��6g   ��  �� Path$ SelectedMessage.Subject�6�   �� 5      -   5        $ SelectedCompanyTextLabel��5      #��[ 66   $
��Left=�6�   $��72,77,-52,0q�6�   $	��Top=�6�   $	��258��6�   $	��364��6�   ��6e   �� $ SelectedMessage.Text�6�   5      5       5!      