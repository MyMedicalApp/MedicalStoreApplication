   M S B A M L   `   `   `  ����E  ATextileApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MedicalApp.UserControlsMedicalApp.UserControls  5      =#clr-namespace:MedicalApp.ViewModelsMedicalApp.ViewModels  5      'clr-namespace:MedicalApp
MedicalApp  5           MedicalApp.Views.SalesBill   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4UC%clr-namespace:MedicalApp.UserControls     5      :
ViewModels#clr-namespace:MedicalApp.ViewModels     5      ,Sortingclr-namespace:MedicalApp     5      -   5          N� WindowTitle$  	Sale Bill��5   0      WindowStyle#���   5	      $��15,0,0,0q�6-    N� Title$ 
Sales Bill��5
      $
��1250��61   $	��700��6>    � 	Resources 5        SrNoColumnTemplate �� TextAlignment �� Path  ProductColumnTemplate  PackingColumnTemplate  CompanyColumnTemplate  MRPColumnTemplate  BatchNoColumnTemplate  ExpiryDateColumnTemplate  QtyColumnTemplate 	 LoosQtyColumnTemplate 
 ExpiryColumnTemplate  StockColumnTemplate  StoryboardEntrance g� 	BeginTime �� TargetProperty �� 
TargetName O� KeyTime	 O� Value
 �� 	KeySpline��%�	  &	       &	 �     &	 {    &	 8    &	 �    &	 �    &	 k    &	 +    &		 �    &	
 _    &	 &    &	 �    �� 5   
   .R�5      �� $��Arial)�6   $��20(�6,   $
��Bold"�6:   $ Center=�6M   $��Center=�6d   $��30��6   $��Stretch=�6�   ��6�   �� $
 SrNo�6�   5      �� 5   
   .R�5      �� $��Arial)�6   $��20(�6,   $
��Bold"�6:   $ Center=�6L   $��Center=�6c   $��30��6~   $��Stretch=�6�   ��6�   �� $ ProductName�6�   5      �� 5   
   .R�5      �� $��Arial)�6   $��20(�6,   $
��Bold"�6:   $ Center=�6L   $��Center=�6c   $��30��6~   $��Stretch=�6�   ��6�   �� $ Packing�6�   5      �� 5   
   .R�5      �� $��Arial)�6   $��20(�6,   $
��Bold"�6:   $ Center=�6L   $��Center=�6c   $��30��6~   $��Stretch=�6�   ��6�   �� $ Company�6�   5      �� 5   
   .R�5      �� $��Arial)�6   $��20(�6,   $
��Bold"�6:   $ Center=�6L   $��Center=�6c   $��30��6~   $��Stretch=�6�   ��6�   �� $	 MRP�6�   5      �� 5   
   .R�5      �� $��Arial)�6   $��20(�6,   $
��Bold"�6:   $ Center=�6L   $��Center=�6c   $��30��6~   $��Stretch=�6�   ��6�   �� $ BatchNo�6�   5      �� 5   
   .R�5       �� $��Arial)�6   $��20(�6-   $
��Bold"�6;   $ Center=�6M   $��Center=�6d   $��30��6   $��Stretch=�6�   ��6�   �� $ 
ExpiryDate�6�   5!      �� 5"   
   .R�5#      �� $��Arial)�6   $��20(�6-   $
��Bold"�6;   $ Center=�6M   $��Center=�6d   $��30��6   $��Stretch=�6�   ��6�   �� $	 Qty�6�   5)      �� 5*   
   .R�5+      �� $��Arial)�6   $��12(�6,   $��Stretch=�6X   ��6:   �� $ LoosQty�6X   5,      �� 50   
   .R�51      �� $��Arial)�6   
����  �$��20(�6?   $
��Bold"�6M   $ Center=�6_   $��Center=�6v   $��30��6�   $��Stretch=�6�   ��6�   �� $ Expiry�6�   52      �� 53   
   .R�54      �� $��Arial)�6   $��20(�6,   $
��Bold"�6:   $ Center=�6L   $��Center=�6c   $��30��6~   $��Stretch=�6�   ��6�   �� $ Stock�6�   55      �� 56   
   .��57      U� $ 00:00:00X�6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6b    6A   Z� .\�58      �� $ 00:00:00��6'   $		 230Q�6:   $
 1,0,0,1��6F   �� 59      $ 00:00:00.5000000��6'   $		 -30Q�6B   $
 1,0,0,1��6N   �� 5:      $ 00:00:00.7000000��6'   $	 0Q�6B   $
 0,0,0,1��6L   5;      5<      5=       � DataContext 5?      .   (MedicalApp.ViewModels.SalesBillViewModel  5@   
   .��5C      ]� .+�5D   
   �� $	��Top=�6   .+�5E      ��  �� Orientation$ Vertical=�6   .+�5F      �� $ 
Horizontal=�6   .+�5G      �� $��Right=�6    $��10,10,10,10q�6<   $��Center=�6Q     
LabelStyle#���  6l   $��	Bill No.:��6�   $��79��6�   �� 5H      -   5         ��Name$ 	txtBillNo��5H   *   $	��150��6     TextBoxStyle#���  6=   $��Center=�6d   $
��Left=�6   �� 5J      $��Right=�6    $��10,10,10,10q�6<   #���  6Q   $��Center=�6v   $��
Bill Date:��6�   (  "System.Windows.Controls.DatePicker  5K      -   5          Name$ dtpBillDate��5K   !   $��Center=�66   $��10,10,10,10q�6S   $��Center=�5L   %     calendarStyle   CalendarStyle# �  5M   %     datePickerStyle#���  5N   %      SelectedDate 5L   @   �� *
BillDate+5O      5P      �� 5Q      $ 
Horizontal=�6   .+�5R      �� $��Right=�6    $��
10,0,10,10q�6<   #���  6P   $��Center=�6u   $��	Customer:��6�   $��79��6�   �� 5S      -   5        $ txtCutomerName��5S   *   $	��493��6   #���  6B   $��Center=�6i   $
��Left=�6�   �� 5T      $��Right=�6    $��
10,0,10,10q�6<   #���  6P   $��Center=�6u   $��Address:��6�   �� 5U      -   5        $ txtCutomerAddress��5U   *   $	��539��6   #���  6E   $��Center=�6l   $
��Left=�6�   5V      �� 5W      $ 
Horizontal=�6   .+�5X      �� $��Right=�6    $��
10,0,10,10q�6<   #���  6P   $��Center=�6u   $��Doctor:��6�   $��78��6�   �� 5Y      -   5        $ txtDoctorName��5Y   *   $	��493��6   #���  6A   $��Center=�6h   $
��Left=�6�   �� 5Z      $��Right=�6    $��
10,0,10,10q�6<   #���  6P   $��Center=�6u   $��Address:��6�   �� 5[      -   5        $ txtDoctorAddress��5[   *   $	��542��6   #���  6D   $��Center=�6k   $
��Left=�6�   6�   5\      �� 5]      $	��163��6   .+�5^      �� $��Right=�6    #���  6=   $��Center=�6b   $��Product:��6}    �� Left$ 11��6�   
 �� Top$ 24��6�   $��30��6�   $	��105��6�   1   +MedicalApp.UserControls.AutoCompleteTextBox  5_      -   5          Name$ txtProducts��5_   r   1   +MedicalApp.UserControls.AutoCompleteTextBox   KeyDown$ txtGroup_KeyDown��6W   $��40��6-   $	��491��69    �� 
IsEditable . $
��Left=�6�   $��16(�6�   $ 98��6�   $ 16��6�   5c      �� 5e      .+�5f      �� -	   5         ��Name$ Border��5f   !   
�������$��1,1,1,1q�6E    �� CornerRadius$ 3,3,3,3��6_   $��0,0,0,0q�6v   $ 60��6�   $	 100��6�   ._�5g      !   MedicalApp.SortableListView  -
   5          Name$ BatchNumberGridView��5m   �   !   MedicalApp.SortableListView   KeyDown$! BatchNumberGridView_KeyDown��5g   _   $	��100��67   $
��Left=�6D   
��� � �$��10q�5h   M   $
��Auto=�5i   #   $
��Auto=�6U    $� IsVirtualizing . ��.  �� SelectionMode$ Single=�5k   #   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6;    # RestaurantEditListViewItemStyle#���  5l   #     RestaurantEditListViewStyle#���  5m   #   {�. $	��Top=�6j   $��0q�6�   $	��490��6�    �� SelectedValue 5g   �   �� *SelectedBatchNo+��5h   #   Z�  �� View 5n   "   �� 5o   &    �� AllowsColumnReorder .  .P�5p   *   ��   �� Width$  4��69    # FirstColumnGridViewColumnHeader! �� HeaderContainerStyle#! �  6C     EmptyColumnTemplate" �� CellTemplate#" [ 6�   #   MedicalApp.SortListViewColumn  5q   *   $	��MRP��6E   #" [ 6R   #   SortProperty$	# MRP��6�   $	  100��6�   $   	SortStyle$($ "RestaurantDataGridViewColumnHeader��6�    & "RestaurantDataGridViewColumnHeader#! �  6�     5r   *   $��BatchNo��6E   #" [ 6V   $# BatchNo��6�   $	  120��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5s   *   $��Expiry��6E   #" [
 6U   $
# NDRX��6�   $	  150��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5t   *   $��Stock��6E   #" [ 6T   $# CUser��6�   $	  110��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�   5u   '   5w      5x      5y      �� 5z      $��Right=�6    #���  6<   $��Center=�6a   $��P Qty:��6|   $	 617��6�   $ 16��6�   �� 5{      -   5        $ txtPQty��5{   )   $��70��6   $��41��6:   #���  6`   $��Center=�6�   $
��Left=�6�   $	 676��6�   $ 13��6�   .��6�   .��5~   4   5      �� 5�      .+�5�      �� -   5        $ Border3��5�   !   
�������$��1,1,1,1q�6F   $ 3,3,3,3��6`   $��0,0,0,0q�6w   $ 59��6�   $	��103��6�   $	��610��6�   $	 610��6�   ._�5�      �� .+�5�   "   �� $��43��6,   $��25(�68   $
��Bold"�6F   
��� � �$��Center=�6k   $��Center=�6�   $	 297��6�   $ 11��6�   % J� RenderTransformOrigin$% 0.5,0.5&�6�   $	��130��6�   Total Qty :6�   �� 5�   "   -   5        $��txtTotalQty��5�   ,   $��51��6?   $��35(�6K   $
��Bold"�6Y   ���#DC143C$��Center=�6�   $��Center=�6�   $	 453��6�   $��89��6�   $ 4��6�   ��6�   �� $ TotalQty�& �� Mode$& TwoWay=�' �� UpdateSourceTrigger$' PropertyChanged=��� 5�   "   $��43��6,   $��25(�68   $
��Bold"�6F   
��� � �$��Center=�6k   $��Center=�6�   $	 243��6�   $ 53��6�   Total Amount :6�   �� 5�   "   $��43��6,   $��35(�68   $
��Bold"�6F   ���#DC143C$��Center=�6m   $��Center=�6�   $	 428��6�   $	��₹��6�   $ 48��6�   �� 5�   "   -   5        $��txtTotalAmount��5�   ,   $��51��6B   $��35(�6N   $
��Bold"�6\   ���#DC143C$��Center=�6�   $��Center=�6�   $	 453��6�   $	��153��6�   $ 47��6�   ��6�   �� $ TotalAmount�$& TwoWay=�$' PropertyChanged=�5�      5�      5�      5�      �� 5�      5�      �� 5�      -   5        $ Border1��5�      
�������$��1,1,1,1q�6>   $ 3,3,3,3��6X   $��10,0,0,0q�6o   $
��1221��6�   $	��317��6�   ._�5�        -   5        $ SalesGridView��5�   r   $ SalesGridView_KeyDown��5�   R   $
��Left=�5�   0   
��� � �$��10q�5�   =   $
��Auto=�5�      $
��Auto=�6E    . ��. 
�������$ Single=�5�      $
 TrueY�6*   #���  5�      #���  5�      {�. $	��Top=�6Z   $
��1221��6�   ��5�   K   �� *" objSalesBillM.ListSalesBillModel+$& TwoWay=���5�      Z�  6r   �� *
CurrentRow+ 5�      �� 5�       .  .P�5�   "   �� $  4��61   #! �  6;   #" [ 6�     5�   "   $��Sr.No.��6=   #" [ 6M   $
# SrNo��6�   $  40��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $��Product��6=   #" [ 6N   $# Product��6�   $	  150��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $��Packing��6=   #" [ 6N   $# Packing��6�   $	  150��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $��Company��6=   #" [ 6N   $# Company��6�   $	  150��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $	��MRP��6=   #" [ 6J   $	# MRP��6|   $	  150��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $��	Batch No.��6=   #" [ 6P   $# BatchNo��6�   $	  150��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $��Expiry Date��6=   #" [ 6R   $# 
ExpiryDate��6�   $	  150��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $��P Qty��6=   #" [ 6L   $	# MRP��6~   $	  100��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�     5�   "   $��Loos Qty��6=   #" [	 6O   $# LoosQty��6�   $	  100��6�   $($ "RestaurantDataGridViewColumnHeader��6�   #! �  6�   5�      5�      5�      5�      5�      5�      5�      