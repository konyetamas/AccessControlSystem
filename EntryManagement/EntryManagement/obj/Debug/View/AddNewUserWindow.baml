   M S B A M L   `   `   `  ����J  FEntryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:EntryManagement.ViewEntryManagement.View  5   	   +    %EntryManagement.View.AddNewUserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:EntryManagement.View     5   	      BasicWindowStyle#��[  5   
     � Title$  AddNewUserWindow��5	   	   $	��300��6"   $	��300��6/   .��5      � .+�5   
   �� -   5         ��Name$ UsertextBox��5        BasicTextBox#��[ 6'   $
��Left=�6M   $��23��6h   $��
132,41,0,0q�6t    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ PasswordTextBox��5      #��[ 6+   $
��Left=�6Q   $��23��6l   $��
132,89,0,0q�6x   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ UserNamelabel��5      $��Name: ��6'     BasicTitleLabelStyle#��[ 68   $
��Left=�6f   $��	31,41,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        $ PasswordLabel��5      $��
Password: ��6'   #��[ 6<   $
��Left=�6j   $��	31,80,0,0q�6�   $	��Top=�6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $��132,141,0,0q�6@   $	��Top=�6U   $	��120��6m    �� DisplayMemberPath$ Value��6y   ��6�   �� *Roles+ �� SelectedItem 6�   �� *SelectedRole+�� 5   
   -   5        $ label��5      #��[ 6    $��Title: ��6N   $
��Left=�6`   $��
31,129,0,0q�6{   $	��Top=�6�   $��51��6�    J� RenderTransformOrigin$ 0.289,0.485&�6�   �� 5   
   -   5         ��Name$ AddNewUserbutton��5        BasicButtonStyle#��[ 6+   $	��Add��6V   $
��Left=�6d   $��147,201,0,0q�6   $	��Top=�6�   $��75��6�   6�   5      5      