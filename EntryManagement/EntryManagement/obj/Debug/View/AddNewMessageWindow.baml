   M S B A M L   `   `   `  ����J  FEntryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EntryManagement.ViewEntryManagement.View  5   	   (    "EntryManagement.View.AddNewMessage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EntryManagement.View     5   	      BasicWindowStyle#��[  5   
     � Title$  AddNewMessage��5	   	   $	��600��6   $	��450��6,   .��5      � .+�5   
   �� -   5         ��Name$ comboBox��5       �� DisplayMemberPath$
 Name��6N   $
��Left=�6�   $��	87,10,0,0q�6�   $	��Top=�6�   $	��241��6�    �� SelectedItem 6%   �� *SelectedCompany+��6�   �� *	Companies+6�   �� 5   
   -   5         ��Name$ label��5        BasicTitleLabelStyle#��[ 6   $��Text:��6M   $
��Left=�6]   $��	5,205,0,0q�6x   $	��Top=�6�   $��44��6�   �� 5   
   -   5        $ label1��5      #��[ 6    $��Subject:��6N   $
��Left=�6a   $��	5,158,0,0q�6|   $	��Top=�6�   $��77��6�   �� 5   
   -   5         ��Name$ SubjectTextBox��5        BasicTextBox#��[ 6*   $
��Left=�6Q   $��23��6l   $��
82,158,0,0q�6x    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��241��6�   �� 5   
   -   5        $ CompanyLabel��5      #��[ 6&   $��	Company: ��6T   $
��Left=�6h   $��0,10,0,0q�6�   $	��Top=�6�   $��82��6�   �� 5   
   -   5         ��Name$ listView��5        BasicListView#��[ 6L   $
��Left=�6s   $��91��6�   $��	82,51,0,0q�6�   $	��Top=�6�   $	��241��6�   ��6%   �� *AddedCompanies+ �� View 5      �� 5      .P�5      �� 	 �� Width$	 30��6)   $��Id��64   
 �� DisplayMemberBinding
 5   
   �� *Id+�� 5      $		 200��6)   $
��Name��65   
 5   
   �� *Name+5      5      �� 5   
   -   5         ��Name$ 	AddButton��5        BasicButtonStyle#��[ 6$   $	��Add��6N   $
��Left=�6\   $��
340,10,0,0q�6w   $	��Top=�6�   $��75��6�   6�   �� 5   
   -   5        $ ValueTextBox��5      #��[ 6(   $
��Left=�6O   $	��318��6j   $��
82,205,0,0q�6w   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��333��6�   �� 5   
   -	   5        $ 
SendButton��5      #��[ 6%   $
��Send��6P   $
��Left=�6_   $��340,542,0,0q�6z   $	��Top=�6�   $��75��6�   6�   5       5!      