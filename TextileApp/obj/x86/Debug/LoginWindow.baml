   M S B A M L   `   `   `  ����B  >UI.Base, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null2&clr-namespace:UI.Base;assembly=UI.BaseUI.Base  5      E ATextileApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MedicalApp.ViewModelsMedicalApp.ViewModels 5         MedicalApp.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6ctr&clr-namespace:UI.Base;assembly=UI.Base     5      :
ViewModels#clr-namespace:MedicalApp.ViewModels     5      -   5          �Name$  window��5
   	    � Title$ Login��5      $	��270��6   $	��400��6       ModalWindowStyle#���   6,   $
��Bold"�5   	   ���	#FFFFFFFF
����  � � WindowStartupLocation$ CenterScreen=�5   O   $��Arial)�5	      $��11(�6-    J� RenderTransformOrigin$ 0.5,0.5&�6;   $��0��5
       � ShowInTaskbar .  � 	Resources 5        StoryboardEntrance g� 	BeginTime �� TargetProperty �� 
TargetName	 O� KeyTime
 O� Value �� 	KeySpline��%�  &	       �� 5   
   .��5      U� $ 00:00:00X�6,   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6b    6A   Z� .\�5      �� $	 00:00:00��6'   $	
 230Q�6:   $ 1,0,0,1��6F   �� 5      $	 00:00:00.5000000��6'   $	
 -30Q�6B   $ 1,0,0,1��6N   �� 5      $	 00:00:00.7000000��6'   $
 0Q�6B   $ 0,0,0,1��6L   5      5      5      z�5      V� 5   
   .~�5      ��  �� ScaleX$ 1Q�6    �� ScaleY$ 1Q�6(   �� 5       �� AngleX$ 0Q�6    �� AngleY$ 0Q�6'   �� 5       �� Angle$ 0Q�6   T� 5       T� X$ 0Q�6!    T� Y$ 0Q�6'   5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5       �� #��[ 6   5!       J� CommandBindings 5#      )  #System.Windows.Input.CommandBinding  5$   
   -   5           Command$ Close��5$      5%   	    � DataContext 5'      0  *MedicalApp.ViewModels.MstAccountViewModels  5(   
   .��5*      ��  �� Orientation$ Vertical=�6   $��Center=�6(   $	��Top=�6E   $��0,10,0,0q�6]   .+�5+   
   �� $
��Left=�6   $��0,0,0,0q�6/   $��Center=�6@   $��
User Name:��6[   $
��Wrap=�6m   $��Verdana)�6�   $��20(�6�   $��Medium"�6�   �� 5,   
   -   5         ��Name$ txtUserName��5.       $
��Left=�5,      $��0,0,0,0q�6-   $��Center=�6>   $	��200��6Y   $��30��6e    �� TextWrapping$
 Wrap=�5-       �� MaxLines$ 1��6&    �� 	MaxLength$ 50��63   $��12(�5.      $��0��65   ��6B   ��  �� Path$ objMstAccount.AccountName��� 50      $
��Left=�6   $��0,0,0,0q�63   $��Center=�6D   $��	Password:��6_   $
��Wrap=�6p   $��Verdana)�6�   $��20(�6�   $��Medium"�6�   G� 52   
   -   5         G�Name$ 
pbPassword��52   �   $
��Left=�6   $��0,0,0,0q�61   $��Center=�6B   $	��200��6]   $��30��6i    G� 	MaxLength$ 32��6u   $��12(�6�   $��1��53      �� 54   
   -   5          ��Name$  btnLogin��56   0     BlueButtonStyle#���  54      $
��Left=�6;   $��0,5,0,0q�6V   $��Bottom=�55      $	��200��6,   $��35��68   $��Login��6D   ���	#FFFFFFFF$��20(�56      ! �� 	IsDefault! . $��2��6B   ��6P   �� *AddMstAccountCmd+58      59      