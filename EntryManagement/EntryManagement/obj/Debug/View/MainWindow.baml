   M S B A M L   `   `   `  ����J  FEntryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EntryManagementEntryManagement  5   	        EntryManagement.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:EntryManagement     5   	      BasicWindowStyle#��[  5   
     � Title$  
MainWindow��5	   	   $	��600��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��291* �6   �� 5      $
��226* �6   .+�5   
   �� -   5         ��Name$ InboxMessagesButton��5        BasicButtonStyle#��[ 6/   $��Inbox messages��6Y   $
��Left=�6r   $��103,121,0,0q�6�   $	��Top=�6�   $	��113��6�   $��1��6�   $��20��6�   �� 5   
   -   5        $ CompaniesButton��5      #��[ 6+   $��	Companies��6U   $
��Left=�6i   $��
103,82,0,0q�6�   $	��Top=�6�   $	��113��6�   $��1��6�   $��20��6�   �� 5   
   -   5        $ OutboxMessagesButton��5      #��[ 60   $��Outbox messages��6Z   $
��Left=�6t   $��103,159,0,0q�6�   $	��Top=�6�   $	��113��6�   $��1��6�   $��20��6�   6�   �� 5   
   -   5         ��Name$ UserNameLabel��5        BasicTitleLabelStyle#��[ 6'   $
��Left=�6{   $��40��6�   $��	91,10,0,0q�6�   $	��Top=�6�   $	��125��6�   $��1��6�   ��6U   ��  �� Path$ UserFullName�6�   �� 5   
   -   5         ��Name$ EntriesListView��5        BasicListView#��[ 6-   $
��Left=�6u   $	��580��6�   $��	10,10,0,0q�6�   $	��Top=�6�   $	��380��6�   ��6U   �� *	Entries+ �� View 5      �� 5      .P�5      ��  �� Width$ 30��6%   $��Id��60    �� DisplayMemberBinding 5   
   �� *	FirstName+�� 5      $	 200��6%   $
��Name��61    5   
   �� *
MemberName+�� 5      $	 150��6%   $��Company��61    5   
   �� *CompanyName+5      5      �� 5    
   -   5        $ UsersButton��5       $y�Hidden=�6&   #��[ 6:   $��Users��6d   $��1��6t   $
��Left=�6�   $��123,205,0,0q�6�   $	��Top=�6�   $��75��6�   6�   �� 5!   
   -   5        $ OpenDoorButton��5!      #��[ 6*   $��	Open door��6U   $��1��6i   $
��Left=�6y   $��123,252,0,0q�6�   $	��Top=�6�   $��75��6�   6�   5#      5$      