   M S B A M L   `   `   `  ����G  CWindowsParty, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WindowsParty.ViewsWindowsParty.Views  5   	   "    WindowsParty.Views.LoginView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WindowsParty.Views     5   	     � Title$  	LoginView��5   	   $	��780��6   $
��1460��6(    � WindowStartupLocation$ CenterScreen=�65    � 	Resources 5	       �� 
TargetType   InputBox �� Property �� Value �� 
TargetType �� Triggers P� Property	 P� Value��%�  &	        '��     �� 5
   
   " ��6   .�5      ��  � �� �#9996+   �� 5       � ��$ Arial)�6+   �� 5       � ��$ 50��6'   �� 5       � ��$ 	0 10 0 10q�6'   �� 5       � ��$ 16(�6)   �� 5       � ��$ 
15 15 15 5q�6(   5      �� 5   
   " ��6   .�5      ��  � �� �#9FD5336+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver	 . . �5      ��  � �� �#86B30063   5       5"      5#      .��5$      � ��5%   
   �� 5&      
 �� ImageSource$"
 /images/login-background.png��6    j� Stretch$ UniformToFill=�6D   .+�5(   
   �� $��Center=�6   $	��395��62   $	��370��6?   $��Center=�6K   .+�5)      �� $"��/images/tesio-logo-white.png��6   $��95��6:   $��0 0 0 30q�6F   � 5*      .+�5+      �� -   5         ��Name$ Username��5+      #��[  6-   �� 5,       J� IsHitTestVisible .  $��Username��65    �� Padding$ 
16 15 15 5q�6E   $
��Left=�6Z   $��0 10 0 0q�6u   $��Arial)�6�   $��16(�6�   ���#999��5-      �� 5.      " ��6    .�5/      ��  � y�$ 	Collapsed=�6;    50      �� 51   "    �� Binding 6.   �� *Text+ �� ElementName$ Username�� �� Value  6]   .a�52   &   ��  � y�$ Visible=�6C   53   #   55      57      58      � 59      .+�5:      G� -   5         G�Name$ Password��5:      #��[  6[   �� 5;      -   5        $��PasswordHint��5;       .  $��Password��6I   $ 
16 15 15 5q�6Y   $
��Left=�6n   $��0 10 0 0q�6�   $��Arial)�6�   $��16(�6�   ���#999$y�Visible=�6�   5=      �� 5>      -   5         ��Name$ LogIn��5>   &   $��Log In��6   $��Arial)�65   $
��Bold"�6H   
�������$��	0 10 0 10q�6m   $��16(�6�   $��50��6�   �� 5?      $
��Wrap=�6   $��Arial)�6K   $
��Bold"�6^   
�������$��0 10 0 0q�6�   $��16(�6�   $��50��6�   ��6,   �� *ErrorMessage+6�   5@      5A      5B      