   M S B A M L   `   `   `  ����U  QGestaoPanosDePratoETapetes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:GestaoPanosDePratoETapetes.ViewGestaoPanosDePratoETapetes.View  5      0    *GestaoPanosDePratoETapetes.View.ToalhaPage   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:GestaoPanosDePratoETapetes.View     5        N� Title$  
ToalhaPage��5	      .��5
      � .+�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5      $��60 �6!   �� 5      .+�5      � -   5         �Name$ filtrosToalhas��5   !   $��0��6   .+�5      �� -   5        .��5   1   	Cadastrar6<   5      � 5      -   5        $ filtrosToalhas2��5   !   $��1��6   .+�5      �� $��Center=�6   $��0,18,0,0q�69   $��Pagina de Toalhas��6K   $
��Bold"�6d   $��18(�6v   $
��Wrap=�6�   $	��Top=�6�   $��32��6�   $	��156��6�   5      &   System.Windows.Controls.DataGrid  5      -   5        $��
dtgToalhas��5   $   $��2��6      AutoGenerateColumns$ False��66      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      
IsReadOnly$
 True��65      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6U   �� *Id+  5      $
 Nome��6)   $
 True��67   $
 Auto 6J    6W   �� *Nome+  5      $ Remessa��6)   $
 True��6:   $
 Auto 6M    6Z   �� *	Remessa+  5      $ 
Quantidade��6)   $
 True��6=   $
 Auto 6P    6]   �� *
Quantidade+  5       $ Data de Entrega��6)   $
 True��6B   $
 Auto 6U    6b   �� *DataEntrega+  5!      $ Data de Coleta��6)   $
 True��6A   $
 Auto 6T    6a   �� *
DataColeta+  5"      $ 
Costureira��6)   $
 True��6=   $
 Auto 6P    6]   �� *Costureira.Nome+5%      5&      5(      5)      