   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    RepositorySystem.WinClient8   2RepositorySystem.WinClient.Views.StockInManageView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  StockInManage��5   	   $	��600��6   $	��800��6,    � 	Resources 5         TextBlockWidth  TextBoxWidth��%I   &	        &	      X�5   
   60Q�63   X�5   
   240Q�62   5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0��6    5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      � $��0��6    5      �� 5      $��* �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   .+�5       �� $��0��6   ��6*   �� *QueryCondition+�� 5!      -   5        $��Query��5!      $��查询��6&   $��1��63   �� 5"      -   5        $��QueryCancel��5"      $��取消��6,   $��2��69   5#      &   System.Windows.Controls.DataGrid  5$      -   5        $��ItemCollection��5$   $   $��1��6      
IsReadOnly .    SelectionMode$ Single=�6L      AutoGenerateColumns .     CanUserAddRows .     RowHeaderWidth$ 0Q�5%   J   	   Columns	 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn
   Header$
 型号��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Model+  5(      $
 名称��6)    65   �� *Name+  5)      $
 库存��6)    65   �� *	Inventory+5+      5,      �� 5.   
   $��1��6   $��0��6%   $��10,0,0,0q�62   .+�5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      �� $��型号��6   #���   6&   �� 51      -   5        $��
Item_Model��51      #���  6,   52      �� 53      $ 
Horizontal=�6   .+�54      �� $��名称��6   #���   6&   �� 55      -   5        $��	Item_Name��55      #���  6+   56      �� 57      $ 
Horizontal=�6   .+�58      �� $��库存��6   #���   6&   �� 59      -   5        $��Item_Inventory��59      #���  60   5:      5;      �� 5=   
   $ 
Horizontal=�6   $��0��6.   $��1��6>   .+�5>      �� -   5        $	��Add��5>      $��添加��6    �� 5?      -   5        $��Delete��5?      $��删除��6#   5@      5A      5B      