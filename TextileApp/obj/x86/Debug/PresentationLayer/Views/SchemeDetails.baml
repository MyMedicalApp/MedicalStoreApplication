   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5      E ATextileApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MedicalApp.ViewModelsMedicalApp.ViewModels 5      A%clr-namespace:MedicalApp.UserControlsMedicalApp.UserControls 5	      'clr-namespace:MedicalApp
MedicalApp 5
      $   MedicalApp.Views.SchemeDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6my-http://schemas.microsoft.com/wpf/2008/toolkit  5      iMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  5      4
ViewModels#clr-namespace:MedicalApp.ViewModels  5      .UC%clr-namespace:MedicalApp.UserControls  5	      &Sortingclr-namespace:MedicalApp  5
      $	��300��5      $	��250��6     � Title$  Half Scheme Details��6!      ModalWindowStyle#���   5      $��Arial)�5      $��11(�6   
������� � WindowStartupLocation$ CenterScreen=�5       � ShowInTaskbar .   J� RenderTransformOrigin$ 0.5,0.5&�6C   ��5   t   Z�  � 	Resources 5        StoryboardEntrance g� 	BeginTime �� TargetProperty �� 
TargetName O� KeyTime	 O� Value
 �� 	KeySpline��%�  &	       �� 5   
   .��5      U� $ 00:00:00X�6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6b    6A   Z� .\�5      �� $ 00:00:00��6'   $		 230Q�6:   $
 1,0,0,1��6F   �� 5      $ 00:00:00.5000000��6'   $		 -30Q�6B   $
 1,0,0,1��6N   �� 5      $ 00:00:00.7000000��6'   $	 0Q�6B   $
 0,0,0,1��6L   5      5      5      z�5      V� 5   
   .~�5      ��  �� ScaleX$ 1Q�6    �� ScaleY$ 1Q�6(   �� 5       �� AngleX$ 0Q�6    �� AngleY$ 0Q�6'   �� 5       �� Angle$ 0Q�6   T� 5       T� X$ 0Q�6!    T� Y$ 0Q�6'   5       � Triggers 5       :� 5!   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5"      �� #��[ 6   5#       J� CommandBindings 5%      )  #System.Windows.Input.CommandBinding  5&   
   -   5           Command$ Close��5&      5'      .��5+   
   �� $��Center=�6   $��Center=�62   $��	-10,0,0,0q�6M   .+�5,      �  � RowDefinitions 5-      �� 5.      $
��Auto �6$   �� 5/      $
��Auto �6$   �� 50      $
��Auto �6$   �� 51      $
��Auto �6$   �� 52      $
��Auto �6$    � ColumnDefinitions 54      �� 55      $
��Auto �6'   �� 56      $
��Auto �6'   �� 57      $
��Auto �6'   .+�5:      �� $��1��6   $��1��6%   $��Half Scheme : ��65   $��Right=�6N   $��0,20,0,0q�6j   $��Center=�6|   �� 5;      -   5         ��Name$ cmbHalfScheme��5;   D   $��1��6   $��2��6(   $	��150��68   $��22��6[   $��0,20,0,0q�6g   $��Center=�6y   $
��Left=�6�   5<      �� 5=      $��2��6   $��1��6%   $��Scheme % : ��65   $��Right=�6K   $��	0,10,0,10q�6g   $��Center=�6z   �� 5>      -   5         ��Name$ txtSchemePercent��5>   C   $��2��6   $��2��6'   $	��150��67   $��22��6]   $��	0,10,0,10q�6i   $��Center=�6|   $
��Left=�6�   �� 5?      $��3��6   $��1��6%   $��Scheme % : ��65   $��Right=�6K   $��0,0,0,0q�6g   $��Center=�6x   �� 5@      -   5        $ txtSchemeAmount��5@   C   $��3��6   $��2��6'   $	��150��67   $��22��6\   $��Center=�6h   $
��Left=�6�   �� 5B      -   5        $��btnSave��5B      $��4��6(   $��2��65   $��0,10,0,0q�6E     BlueButtonStyle#���  6W   ���	#FFFFFFFF$��12(�6�   $
��Bold"�6�   $	��150��6�   $��35��6�   $	��Top=�6�   .��5C      �� .��6!   _Save6(   5D      5F      5G      5J      