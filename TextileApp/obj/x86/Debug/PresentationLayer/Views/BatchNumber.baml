   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5      E ATextileApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MedicalApp.ViewModelsMedicalApp.ViewModels 5      A%clr-namespace:MedicalApp.UserControlsMedicalApp.UserControls 5	      'clr-namespace:MedicalApp
MedicalApp 5
      "   TextileApp.Views.BatchNumber   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6my-http://schemas.microsoft.com/wpf/2008/toolkit  5      iMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5      4
ViewModels#clr-namespace:MedicalApp.ViewModels  5      .UC%clr-namespace:MedicalApp.UserControls  5	      &Sortingclr-namespace:MedicalApp  5
      $	��550��5      $	��250��6     � Title$  Batch Details��6!      ModalWindowStyle#���   5      $��Arial)�5      $��11(�6   
������� � WindowStartupLocation$ CenterScreen=�5       � ShowInTaskbar .   J� RenderTransformOrigin$ 0.5,0.5&�6C   ��5   t   Z�  � 	Resources 5        BatchNoColumnTemplate �� Path  MRPColumnTemplate  ExpiryColumnTemplate  StockColumnTemplate  StoryboardEntrance g� 	BeginTime �� TargetProperty �� 
TargetName	 O� KeyTime
 O� Value �� 	KeySpline��%�  &	       &	 {     &	      &	 z    &	 �    �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6X   ��6:   �� $ BatchNo�6X   5      �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��20��6:   $��Stretch=�6`   ��6F   �� $	 MRP�6`   5      �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6W   ��6:   �� $ Expiry�6W   5      �� 5   
   .R�5      �� $��Arial)�6   $��12(�6,   $��Stretch=�6V   ��6:   �� $ Stock�6V   5      �� 5   
   .��5      U� $ 00:00:00X�6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6b    6A   Z� .\�5      �� $	 00:00:00��6'   $	
 230Q�6:   $ 1,0,0,1��6F   �� 5      $	 00:00:00.5000000��6'   $	
 -30Q�6B   $ 1,0,0,1��6N   �� 5       $	 00:00:00.7000000��6'   $
 0Q�6B   $ 0,0,0,1��6L   5!      5"      5#      z�5$      V� 5%   
   .~�5&      ��  �� ScaleX$ 1Q�6    �� ScaleY$ 1Q�6(   �� 5'       �� AngleX$ 0Q�6    �� AngleY$ 0Q�6'   �� 5(       �� Angle$ 0Q�6   T� 5)       T� X$ 0Q�6!    T� Y$ 0Q�6'   5*       � Triggers 5,      :� 5-   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5.      �� #��[ 6   5/       J� CommandBindings 51      )  #System.Windows.Input.CommandBinding  52   
   -   5           Command$ Close��52      53      .��55      � .+�56   
   !  MedicalApp.SortableListView  -   5          Name$ BatchNumberGridView��5<   �   !  MedicalApp.SortableListView   KeyDown$! BatchNumberGridView_KeyDown��5:   `   $	��200��56   #   $	��520��60   $
��Left=�6<   
��� � �$��10q�57   M   $
��Auto=�58   #   $
��Auto=�6U    $� IsVirtualizing . ��.  �� SelectionMode$ Single=�5:   #   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6;    # RestaurantEditListViewItemStyle#���  5;   #     RestaurantEditListViewStyle#���  5<   #   {�. $	��Top=�6j   ��56   W   �� * objBatchMaster.ListBatchMaster+ �� Mode$ OneWay=���57   #   Z�  �� View 5=      �� 5>       �� AllowsColumnReorder .  .P�5?      ��  �� Width$ 4��6%    # FirstColumnGridViewColumnHeader  �� HeaderContainerStyle#  �  6/    	 EmptyColumnTemplate! �� CellTemplate#! [	 6x   #  MedicalApp.SortListViewColumn  5@      $	��MRP��61   #! [ 6>   "   SortProperty$	" MRP��6p   $	 150��6�   #   	SortStyle$(# "RestaurantDataGridViewColumnHeader��6�    &
 "RestaurantDataGridViewColumnHeader#  � 
 6�     5A      $��BatchNo��61   #! [ 6B   $" BatchNo��6x   $	 150��6�   $(# "RestaurantDataGridViewColumnHeader��6�   #  � 
 6�     5B      $��Expiry��61   #! [ 6A   $
" NDRX��6v   $	 150��6�   $(# "RestaurantDataGridViewColumnHeader��6�   #  � 
 6�     5C      $��Stock��61   #! [ 6@   $" CUser��6t   $	 150��6�   $(# "RestaurantDataGridViewColumnHeader��6�   #  � 
 6�   5D      5F      5H      5I      