   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5      E ATextileApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MedicalApp.ViewModelsMedicalApp.ViewModels 5      A%clr-namespace:MedicalApp.UserControlsMedicalApp.UserControls 5	      'clr-namespace:MedicalApp
MedicalApp 5
      #   MedicalApp.Views.DoctorMaster   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6my-http://schemas.microsoft.com/wpf/2008/toolkit  5      iMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5      4
ViewModels#clr-namespace:MedicalApp.ViewModels  5      .UC%clr-namespace:MedicalApp.UserControls  5	      &Sortingclr-namespace:MedicalApp  5
      $
��1000��5      $	��650��6     � Title$  DoctorMaster��6"      ModalWindowStyle#���   5      $��Arial)�5      $��11(�6   
������� � WindowStartupLocation$ CenterScreen=�5       � ShowInTaskbar .   J� RenderTransformOrigin$ 0.5,0.5&�6C   ��5   t   Z�  � 	Resources 5        DoctorCodeColumnTemplate �� Path  ICodeColumnTemplate  DoctorNameColumnTemplate  Add1ColumnTemplate  Phone1ColumnTemplate  EmailColumnTemplate  CUserColumnTemplate  CDateTimeColumnTemplate 	 EUserColumnTemplate 
 EDateTimeColumnTemplate  LCodeColumnTemplate  DLockColumnTemplate  CreatedByColumnTemplate  CreatedDateColumnTemplate  UpdateddByColumnTemplate  UpdatedDateColumnTemplate  UpdatedCountColumnTemplate  LUTColumnTemplate��%b	  &	       &	 ~     &	 �     &	 u    &	 �    &	 g    &	 �    &	 Y    &		 �    &	
 O    &	 �    &	 E    &	 �    &	 ;    &	 �    &	 8    &	 �    &	 7    �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6[   ��6:   �� $ 
DoctorCode�6[   5      �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6V   ��6:   �� $ ICode�6V   5      �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6[   ��6:   �� $ 
DoctorName�6[   5      �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6U   ��6:   �� $
 Add1�6U   5      �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6W   ��6:   �� $ Phone1�6W   5      �� 5    
   .R�5!      �� $��Arial)�6   $��12(�6,   $��Stretch=�6V   ��6:   �� $ Email�6V   5"      �� 5#   
   .R�5$      �� $��Arial)�6   $��12(�6,   $��Stretch=�6V   ��6:   �� $ CUser�6V   5%      �� 5&   
   .R�5'      �� $��Arial)�6   $��12(�6,   $��Stretch=�6Z   ��6:   �� $ 	CDateTime�6Z   5(      �� 5)   
   .R�5*      �� $��Arial)�6   $��12(�6,   $��Stretch=�6V   ��6:   �� $ EUser�6V   5+      �� 5,   
   .R�5-      �� $��Arial)�6   $��12(�6,   $��Stretch=�6Z   ��6:   �� $ 	EDateTime�6Z   5.      �� 5/   
   .R�50      �� $��Arial)�6   $��12(�6,   $��Stretch=�6V   ��6:   �� $ LCode�6V   51      �� 52   
   .R�53      �� $��Arial)�6   $��12(�6,   $��Stretch=�6V   ��6:   �� $ DLock�6V   54      �� 55   
   .R�56      �� $��Arial)�6   $��12(�6,   $��Stretch=�6Z   ��6:   �� $ 	CreatedBy�6Z   57      �� 58   
   .R�59      �� $��Arial)�6   $��12(�6,   $��Stretch=�6\   ��6:   �� $ CreatedDate�6\   5:      �� 5;   
   .R�5<      �� $��Arial)�6   $��12(�6,   $��Stretch=�6[   ��6:   �� $ 
UpdateddBy�6[   5=      �� 5>   
   .R�5?      �� $��Arial)�6   $��12(�6,   $��Stretch=�6\   ��6:   �� $ UpdatedDate�6\   5@      �� 5A   
   .R�5B      �� $��Arial)�6   $��12(�6,   $��Stretch=�6]   ��6:   �� $ UpdatedCount�6]   5C      �� 5D   
   .R�5E      �� $��Arial)�6   $��12(�6,   $��Stretch=�6T   ��6:   �� $	 LUT�6T   5F      5G       J� CommandBindings 5I      )  #System.Windows.Input.CommandBinding  5J   
   -   5           Command$ Close��5J      5K       � DataContext 5M      2  ,MedicalApp.ViewModels.DoctorMasterViewModels  5N   
   .��5Q      � $
��1000��6   $	��650��6   	 � RowDefinitions	 5R   
   �� 5S      $��20 �6   �� 5T      $
��Auto �6   �� 5U      $��10 �6   �� 5V      $
��Auto �6   �� 5W      $
��Auto �6   �� 5X      $
��Auto �6   �� 5Y      $��10 �6   �� 5Z      $
��Auto �6   
 � ColumnDefinitions
 5\   
   �� 5]      $��20 �6   �� 5^      $
��Auto �6   �� 5_      $
��Auto �6   �� 5`      $
��Auto �6   �� 5a      $
��Auto �6   �� 5b      $
��Auto �6   �� 5c      $
��Auto �6   .+�5f   
   �� $	��860��6   $	��300��6   $
��Bold"�6,   $��1��6>   $��1��6K   ��5g      �� 5h      $
��Bold"�6   
��� ���$��16(�6B   DoctorMaster Entry6d   .��5j      � 	 5k      �� 5l      $��10 �6$   �� 5m      $��30 �6$   �� 5n      $��10 �6$   �� 5o      $��30 �6$   �� 5p      $��10 �6$   �� 5q      $��30 �6$   �� 5r      $��10 �6$   �� 5s      $��30 �6$   �� 5t      $��10 �6$   �� 5u      $��30 �6$   �� 5v      $��10 �6$   �� 5w      $��30 �6$   �� 5x      $��10 �6$   �� 5y      $��30 �6$   �� 5z      $��10 �6$   �� 5{      $��30 �6$   �� 5|      $��10 �6$   �� 5}      $��30 �6$   �� 5~      $��10 �6$   �� 5      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   �� 5�      $��10 �6$   �� 5�      $��30 �6$   
 5�      �� 5�      $��10 �6'   �� 5�      $
��Auto �6'   �� 5�      $
��Auto �6'   �� 5�      $��30 �6'   �� 5�      $
��Auto �6'   �� 5�      $
��Auto �6'   �� 5�      $��30 �6'   �� 5�      $
��Auto �6'   �� 5�      $
��Auto �6'   �� 5�      $��30 �6'   �� 5�      $
��Auto �6'   �� 5�      $
��Auto �6'   .+�5�      �� $��1��6   $��1��6%   $��_DoctorCode : ��65   $��Right=�6N   $��0,0,0,0q�6j   $��Center=�5�       �� Target 60   ��  �� ElementName$ txtDoctorCode���� 5�      -   5         ��Name$ txtDoctorCode��5�   t   $��1��6K   $��2��6X   $	��150��6h   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $  objDoctorMaster.DoctorCode�6�   �� 5�      $��1��6   $��4��6%   $��	_ICode : ��65   $��Right=�6I   $��0,0,0,0q�6e   $��Center=�5�       60   �� $ txtICode���� 5�      -   5        $ txtICode��5�   o   $��1��6F   $��5��6S   $	��150��6c   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.ICode�6�   �� 5�      $��1��6   $��7��6%   $��_DoctorName : ��65   $��Right=�6N   $��0,0,0,0q�6j   $��Center=�5�       60   �� $ txtDoctorName���� 5�      -   5        $ txtDoctorName��5�   t   $��1��6K   $��8��6X   $	��150��6h   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $  objDoctorMaster.DoctorName�6�   �� 5�      $��3��6   $��1��6%   $��_Add1 : ��65   $��Right=�6H   $��0,0,0,0q�6d   $��Center=�5�       60   �� $ txtAdd1���� 5�      -   5        $ txtAdd1��5�   n   $��3��6E   $��2��6R   $	��150��6b   $��22��6   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.Add1�6�   �� 5�      $��3��6   $��4��6%   $��
_Phone1 : ��65   $��Right=�6J   $��0,0,0,0q�6f   $��Center=�5�       60   �� $ 	txtPhone1���� 5�      -   5        $ 	txtPhone1��5�   p   $��3��6G   $��5��6T   $	��150��6d   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.Phone1�6�   �� 5�      $��3��6   $��7��6%   $��	_Email : ��65   $��Right=�6I   $��0,0,0,0q�6e   $��Center=�5�       60   �� $ txtEmail���� 5�      -   5        $ txtEmail��5�   o   $��3��6F   $��8��6S   $	��150��6c   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.Email�6�   �� 5�      $��5��6   $��1��6%   $��	_CUser : ��65   $��Right=�6I   $��0,0,0,0q�6e   $��Center=�5�       60   �� $ txtCUser���� 5�      -   5        $ txtCUser��5�   o   $��5��6F   $��2��6S   $	��150��6c   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.CUser�6�   �� 5�      $��5��6   $��4��6%   $��_CDateTime : ��65   $��Right=�6M   $��0,0,0,0q�6i   $��Center=�5�       60   �� $ txtCDateTime���� 5�      -	   5        $ txtCDateTime��5�   s   $��5��6J   $��5��6W   $	��150��6g   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.CDateTime�6�   �� 5�      $��5��6   $��7��6%   $��	_EUser : ��65   $��Right=�6I   $��0,0,0,0q�6e   $��Center=�5�       60   �� $ txtEUser���� 5�      -
   5        $ txtEUser��5�   o   $��5��6F   $��8��6S   $	��150��6c   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.EUser�6�   �� 5�      $��7��6   $��1��6%   $��_EDateTime : ��65   $��Right=�6M   $��0,0,0,0q�6i   $��Center=�5�       60   �� $ txtEDateTime���� 5�      -   5        $ txtEDateTime��5�   s   $��7��6J   $��2��6W   $	��150��6g   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.EDateTime�6�   �� 5�      $��7��6   $��4��6%   $��	_LCode : ��65   $��Right=�6I   $��0,0,0,0q�6e   $��Center=�5�       60   �� $ txtLCode���� 5�      -   5        $ txtLCode��5�   o   $��7��6F   $��5��6S   $	��150��6c   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.LCode�6�   �� 5�      $��7��6   $��7��6%   $��	_DLock : ��65   $��Right=�6I   $��0,0,0,0q�6e   $��Center=�5�       60   �� $ txtDLock���� 5�      -   5        $ txtDLock��5�   o   $��7��6F   $��8��6S   $	��150��6c   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.DLock�6�   �� 5�      $��9��6   $��1��6%   $��_CreatedBy : ��65   $��Right=�6M   $��0,0,0,0q�6i   $��Center=�5�       60   �� $ txtCreatedBy���� 5�      -   5        $ txtCreatedBy��5�   s   $��9��6J   $��2��6W   $	��150��6g   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.CreatedBy�6�   �� 5�      $��9��6   $��4��6%   $��_CreatedDate : ��65   $��Right=�6O   $��0,0,0,0q�6k   $��Center=�5�       60   �� $ txtCreatedDate���� 5�      -   5        $ txtCreatedDate��5�   u   $��9��6L   $��5��6Y   $	��150��6i   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $! objDoctorMaster.CreatedDate�6�   �� 5�      $��9��6   $��7��6%   $��_UpdateddBy : ��65   $��Right=�6N   $��0,0,0,0q�6j   $��Center=�5�       60   �� $ txtUpdateddBy���� 5�      -   5        $ txtUpdateddBy��5�   t   $��9��6K   $��8��6X   $	��150��6h   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $  objDoctorMaster.UpdateddBy�6�   �� 5�      $��11��6   $��1��6&   $��_UpdatedDate : ��66   $��Right=�6P   $��0,0,0,0q�6l   $��Center=�5�       60   �� $ txtUpdatedDate���� 5�      -   5        $ txtUpdatedDate��5�   v   $��11��6L   $��2��6Z   $	��150��6j   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $! objDoctorMaster.UpdatedDate�6�   �� 5�      $��11��6   $��4��6&   $��_UpdatedCount : ��66   $��Right=�6Q   $��0,0,0,0q�6m   $��Center=�5�       60   �� $ txtUpdatedCount���� 5�      -   5        $ txtUpdatedCount��5�   w   $��11��6M   $��5��6[   $	��150��6k   $��22��6�   $��Center=�6�   $
��Left=�6�   ��6   �� $" objDoctorMaster.UpdatedCount�6�   �� 5�      $��11��6   $��7��6&   $��_LUT : ��66   $��Right=�6H   $��0,0,0,0q�6d   $��Center=�5�       60   �� $ txtLUT���� 5�      -   5        $ txtLUT��5�   n   $��11��6D   $��8��6R   $	��150��6b   $��22��6~   $��Center=�6�   $
��Left=�6�   ��6   �� $ objDoctorMaster.LUT�6�   5�      5�      �� 5�   
   -   5        $��	LeftLine1��5�   F   $��4��6   $��1��6!   $��10��61   
�������$��2��6j   $	��Top=�6u   6�   �� 5�   
   $��5��6   $��1��6   $��25��6.   $	��960��6:   $��Right=�6F   $��0,5,0,5q�6b   $	��Top=�6s   .+�5�      ��  �� Left$ 15��6   $��Searc_h  : ��6%   $��Right=�6;   $��0,0,0,0q�6W   $��Center=�5�       61   �� $ 	txtSearch���� 5�      -   5        $ 	txtSearch��5�   b   $	 150��6   $	��150��6V   $��22��6u   $��Center=�6�   $
��Left=�6�   ��6(   �� $ objDoctorMaster.Search�6�   �� 5�      -   5        $��	btnSearch��5�        BlueButtonStyle#���  6P   ���	#FFFFFFFF$��12(�6�   $	 310��5�      $
��Bold"�6#    �� 	IsDefault .  $��72��6H   $��26��6S   $	��Top=�6_   ��5�   &   �� *SearchDoctorMasterCmd+.��5�      �� .��6   _Find6$   5�      �� 5�      -   5        $��btnSave��5�      #���  6K   ���	#FFFFFFFF$��12(�6�   $	 650��5�      $
��Bold"�6#    .  $��72��6H   $��26��6S   $	��Top=�6_   ��5�   $   �� *AddDoctorMasterCmd+.��5�      �� .��6   _Save6$   5�      �� 5�      -   5        $��btnReset��5�      #���  6N   $��12(�6x   $
��Bold"�6�   $	 750��5�      ���	#FFFFFFFF .  $��72��6M   $��26��6X   $	��Top=�6d   $
��Left=�6|   ��5�   %   �� *ResetDoctorMasterCmd+.��5�      �� .��6   _Reset6%   5�      �� 5     -   5        $��	btnDelete��5     #���  6P   $��12(�6z   $
��Bold"�6�   $	 850��5     ���	#FFFFFFFF .  $��72��6M   $��26��6X   $	��Top=�6d   $��Arial)�6|   ��5  &   �� *DeleteDoctorMasterCmd+.��5     �� .��6   	_Delete6&   5     5     �� 5  
   -   5        $��LeftLine��5  F   $��6��6   $��1��6!   $��10��61   
�������$��2��6i   $	��Top=�6t   6�   �� 5	  
   $��8��6   $��1��6   $��10��6.   $	��960��6C   $��8��6O   $	��290��6`   $
��Left=�6m   .+�5
     �� $��1q�6   
�������._�5     !  MedicalApp.SortableListView  -   5          Name$ BrokerGridView��5  �   $	��290��5  +   $	��960��68   $
��Left=�6D   
��� � �$��10q�5  M   $
��Auto=�5  #   $
��Auto=�6U    $� IsVirtualizing . ��.  �� SelectionMode$ Single=�5  #   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6;    # RestaurantEditListViewItemStyle#���  5  #     RestaurantEditListViewStyle#���  5  #   {�. $	��Top=�6j   ��5  _   �� *" objDoctorMaster.ListDoctorMaster+ �� Mode$ OneWay=���5  #   Z�  �� View 5     �� 5      �� AllowsColumnReorder .  .P�5     ��  �� Width$ 4��6-    # FirstColumnGridViewColumnHeader �� HeaderContainerStyle# �  67     EmptyColumnTemplate �� CellTemplate# [ 6�   #  MedicalApp.SortListViewColumn  5     $��
DoctorCode��69   # [ 6M      SortProperty$ 
DoctorCode��6�   $	 150��6�      	SortStyle$( "RestaurantDataGridViewColumnHeader��6�    & "RestaurantDataGridViewColumnHeader# �  6�     5     $��ICode��69   # [ 6H   $ ICode��6|   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��
DoctorName��69   # [ 6M   $ 
DoctorName��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $
��Add1��69   # [ 6G   $
 Add1��6z   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��Phone1��69   # [ 6I   $ Phone1��6~   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��Email��69   # [ 6H   $ Email��6|   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��CUser��69   # [ 6H   $ CUser��6|   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��	CDateTime��69   # [ 6L   $ 	CDateTime��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��EUser��69   # [	 6H   $ EUser��6|   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��	EDateTime��69   # [
 6L   $ 	EDateTime��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5     $��LCode��69   # [ 6H   $ LCode��6|   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5      $��DLock��69   # [ 6H   $ DLock��6|   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5!     $��	CreatedBy��69   # [ 6L   $ 	CreatedBy��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5"     $��CreatedDate��69   # [ 6N   $ CreatedDate��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5#     $��
UpdateddBy��69   # [ 6M   $ 
UpdateddBy��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5$     $��UpdatedDate��69   # [ 6N   $ UpdatedDate��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5%     $��UpdatedCount��69   # [ 6O   $ UpdatedCount��6�   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�     5&     $	��LUT��69   # [ 6F   $	 LUT��6x   $	 150��6�   $( "RestaurantDataGridViewColumnHeader��6�   # �  6�   5(     5*     5+     5,     5-     5.     