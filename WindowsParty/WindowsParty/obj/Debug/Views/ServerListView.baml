   M S B A M L   `   `   `  ����G  CWindowsParty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WindowsParty.ViewsWindowsParty.Views  5   	   '    !WindowsParty.Views.ServerListView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WindowsParty.Views     5   	     � Title$  ServerListView��5   	   $	��800��6    $
��1450��6-    � WindowStartupLocation$ CenterScreen=�6:    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader   HeaderStyle*  $System.Windows.Controls.DataGridCell  ColumnElementStyle  LeftColumnCell
 �� BasedOn  RightColumnCell��%\  '��       &	  _    '  O    &	     &	 ]    7  &	 �    7  �� 5
   
   " ��6   .�5      ��  � �� �#FFF6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver	 . . �5      ��  � �� �#99cc3363   5      5      �� 5   
   "  6   .�5      ��  � �� �#F5F5F56+   �� 5       � �� �#A8A8A86+   �� 5       � ��$ Arial)�6+   �� 5       � ��$ 16(�6)   �� 5        � ��$ 40 20 40 20q�6(   5!      �� 5"   
   "  6   .�5#      ��  � �� �#A3A3A36+   �� 5$       � ��$ Arial)�6+   �� 5%       � ��$ 16(�6)   �� 5&       � ��$ 60��6'   5'      �� 5(   
   " ��6+   .�5)      ��  � ��$ 40 20 40 20q�6'   5*      �� 5+   
   " ��6'   8
   .�5,      ��  �@��TextAlignment$
 Left=�6.   5-      �� 5.   
   " ��6(   8
   .�5/      ��  �@��TextAlignment$ Right=�6.   50      51      .��52      � .+�53   
   �� ���#FFF.+�54      � $��Stretch=�6   $��30q�61   .+�55      �� $!��/images/tesio-logo-blue.png��6   $��42��6=   $��0��6I   $
��Left=�6Y   �� 56      -   5         ��Name$ LogOut��56      $��Log out��6)   $��1��6;   $��Right=�6K   ���#555555$��Arial)�6|   $��16(�6�   $��80��6�   57      � 58      $��Stretch=�6   ��61   ��  �� RelativeSource ��  �� AncestorType" � �� Path$ ActualHeight� � ColumnDefinitions 59      �� 5:      $��* �6'    z� SharedSizeGroup$ A��61   �� 5;      $��* �6'   $ A��61   .+�5=      &   System.Windows.Controls.DataGrid  -   5          Name$ 
ServerList��5=         AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly .    GridLinesVisibility$
 None=�5A      $��0��5B      $��0q�5C         Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6-      Header$ SERVER��67   1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6`      Binding 6G   �� *name+   HeaderStyle 5F      �� 5G   "   "  6(   #
 [  6S   .�5H   &   ��  � ��$
 Left=�6S   5I   #   5K        5L      $ * 6-   $ DISTANCE��67   # [ 6~    6I   �� *
distance+ �� StringFormat$ {0} km�� 5M      �� 5N   "   "  6(   #
 [  6S   .�5O   &   ��  � ��$ Right=�6S   5P   #   5R      5T      �� 5U      $(��"/images/server-list-background.png��6   $
��None=�6D   $
��Left=�6S   $	��Top=�6n   $��1��6�   5V      5W      5X      5Y      