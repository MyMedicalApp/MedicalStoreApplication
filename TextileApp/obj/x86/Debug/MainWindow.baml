   M S B A M L   `   `   `  ����E  ATextileApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MedicalApp.UserControlsMedicalApp.UserControls  5      'clr-namespace:MedicalApp
MedicalApp  5      C&clr-namespace:TextBoxInputMaskBehaviorTextBoxInputMaskBehavior  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5   	       MedicalApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      4UC%clr-namespace:MedicalApp.UserControls     5      -ListViewclr-namespace:MedicalApp     5      <	Behaviors&clr-namespace:TextBoxInputMaskBehavior     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6my-http://schemas.microsoft.com/wpf/2008/toolkit  5   	   ccontrolsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  5   	   -   5           MainBackgroundBrush#���   5        � Title$  Accounting Application��5	       � WindowStartupLocation$ CenterScreen=�6$    � WindowState$ 	Maximized=�6I   
�������$
��Bold"�5   g   ��5   	   �� *&$SystemParameters.PrimaryScreenHeight+��5      �� *%#SystemParameters.PrimaryScreenWidth+ � 	Resources 5        Storyboard1 g� 	BeginTime �� 
TargetName �� TargetProperty g� RepeatBehavior O� KeyTime	 O� Value
 �� 	KeySpline  StoryboardFadeOut  StoryboardFadeIn��%�  &	       &	 �    &	 �    �� 5   
   .��5      U� $ 00:00:00X�6,   $ image��6A   $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6_   $ Forever��6�   .\�5      �� $ 00:00:04��6'   $	 0Q�6:   $
 0,1,1,1��6D   �� 5      $ 00:00:08��6'   $
	 -720Q�6:   $
 0,0,1,1��6G   �� 5      $ 00:00:09��6'   $
	 -765Q�6:   $
 0,0.024,0.48,1��6G   �� 5      $
 0,0.284,0,1��6'   $ 00:00:22��6?   $
	 2160Q�6R   5      5      �� 5   
   .��5      U� $ 00:00:00X�6,   $ (UIElement.Opacity)�6b    6A   Z� .\�5      �� $ 00:00:00.1500000��6'   $		 0.4Q�6B   5      5      �� 5   
   .��5      U� $ 00:00:00X�6,   $ (UIElement.Opacity)�6b    6A   Z� .\�5       �� $ 00:00:00��6'   $		 0.4Q�6:   �� 5!      $ 00:00:00.1500000��6'   $	 1Q�6B   5"      5#      5$      .��5&      ��  �� Orientation$ Vertical=�6   .+�5(   
   �� -   5         ��Name$ 
MenuBorder��5(        HeaderBackgroundBrush#���  6%   $	��Top=�6Z   $��0,5,0,5q�6o   ._�5)      o� $��Bottom=�6   $��20,0,0,0q�6.     	MenuStyle#���  6@   .@�5*      m� -   5         m�Name$ 
MasterMenu��5*   ,   $��_Master��6    m� InputGestureText$ Ctrl + m��6@     MenuItemStyle#���  6\   ���	#FFE6E6E6.@�51      m� -   5        $ GenericMasterMenuItem��51   6   $��GenericMaster��6   6U   m� 52      -   5        $ DoctorMasterMenuItem��52   6   $��_DoctorMaster��6   6T   53      m� 54      -   5        $ TransactionMenu��54   1   $��_Transaction��6   $ Ctrl + m��6J   #���  6f   ���	#FFE6E6E6.@�5:      m� -   5        $ SaleMenuItem��5:   .   $��_Sale��6   6D   5;      m� 5=      -   5        $ ReportsMenu��5=   m   $��_Reports��6   #���  6.   ���	#FFE6E6E65D      m� 5F      -	   5        $ ExitMenu��5F   �   $��E_xit��6   #���  6E   ���	#FFE6E6E66�   5G      5H      �� 5I   
   -
   5        $��MainArea��5I      $	��700��6!   $	��Top=�6.   .+�5J      �� $
��Auto=�6   $
��Auto=�6@   .��5K       � -   5          �Name$ 	mainFrame��5K   +   $
��Auto��6   $
��Left=�6?   $��0,0,0,0q�6Z   $	��Top=�6l   $
��Auto��6�     � NavigationUIVisibility$ Hidden=�6�   ���#f2f1e86�   5L      5M      �� 5P      -   5        $ BottomStatusBorder��5P      #���  61   $��30��6f   $��0,5,0,7q�6r   ._�5Q      �� -   5        $��	StatusBar��5Q      $
��Left=�6*   .+�5R      �� -   5        $��lblLogInUser��5R        �� Left$	 290��64   $��LoggedIn��6F   
���/���6V   �� 5S      -   5        $��lblCompayName��5S       $ 25��65   $,��&Powered By : UniqueInfotech (Mumbai) |��6F   
���/���6t   5T      5U      5W      5X      