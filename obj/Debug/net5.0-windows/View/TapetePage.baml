   M S B A M L   `   `   `  ����U  QGestaoPanosDePratoETapetes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestaoPanosDePratoETapetes.ViewGestaoPanosDePratoETapetes.View  5   	   0    *GestaoPanosDePratoETapetes.View.TapetePage   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:GestaoPanosDePratoETapetes.View     5   	     N� Title$  
TapetePage��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��60 �6!   �� 5      .+�5      � .+�5      �� -   5        .��5   /   	Cadastrar6:   5      � 5      -   5         �Name$ filtrosToalhas��5   !   $��1��6   .+�5      �� $��Center=�6   $��0,18,0,0q�69   $��Pagina de Tapetes��6K   $
��Bold"�6d   $��18(�6v   $
��Wrap=�6�   $	��Top=�6�   $��32��6�   $	��156��6�   5      &   System.Windows.Controls.DataGrid  5      -   5        $��
dtgTapetes��5   $   $��2��6      AutoGenerateColumns$ False��66      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6)      
IsReadOnly$
 True��67      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6W   �� *Id+  5      $ Quantidade Entrada��6)   $
 True��6E   $
 Auto 6X    6e   �� *Id+  5      $ Total��6)   $
 True��68   $
 Auto 6K    6X   �� *Id+  5      $ Quantidade Saida��6)   $
 True��6C   $
 Auto 6V    6c   �� *Id+  5       $ Preço��6)   $
 True��68   $
 Auto 6K    6X   �� *Id+  5!      $ Total��6)   $
 True��68   $
 Auto 6K    6X   �� *Id+  5"      $ Saldo��6)   $
 True��68   $
 Auto 6K    6X   �� *Id+5%      5&      5(      5)      