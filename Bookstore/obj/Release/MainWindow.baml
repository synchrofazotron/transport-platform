   M S B A M L   `   `   `  ����   	Bookstore    Bookstore.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$  
mainwindow�� � Title$ 	BookStore��$	��470��$	��790�� � AllowsTransparency .  � WindowStyle$
 None=� � Icon$ bs.png�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=� J� Opacity$ 1Q���Z� ��Z�  � 	Resources    OnMouseLeftButtonDown1	 �� TargetProperty
 �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  MouseEnter1  Mouseleave1  Minimizemouseneter   EasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode  Minimiazmoseleave.  (System.Windows.Media.Animation.CubicEase  OnSizeChangedstart-  'System.Windows.Media.Animation.BackEase4  .System.Windows.Media.Animation.ExponentialEase��%4  &	        &	 �    &	     &	 n    &	 �    &	 k    �� .��U� $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$
 close��.\�  $ 0��$ 3Q��� $ 0:0:0.6��$ 3Q�U� $U	 O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$
 close��.\�  $ 0��$ -3Q��� $ 0:0:0.6��$ -3Q�U� $	 (UIElement.Opacity)�$
 close��.\�  $ 0��$	 0.7Q�  $ 0:0:0.6��$ 1Q��� .��U� $	 (UIElement.Opacity)�$
 close��.\�  $ 0��$	 0.7Q�  $ 0:0:0.5��$ 1Q��� .��U� $	 (UIElement.Opacity)�$
 close��.\�  $ 0��$ 1Q�  $ 0:0:0.3��$	 0.7Q��� .��U� $	 (UIElement.Opacity)�$
 image��.\�  $ 0��$	 0.7Q�  $ 0:0:0.6��$ 1Q�   $ EaseIn=��� .��U� $	 (UIElement.Opacity)�$
 image��.\�  $ 0��$ 1Q�  $ 0:0:0.6��$	 0.7Q�   $ EaseOut=��� .��U� $	 (UIElement.Opacity)�$
 Admin12��.\�  $ 0��$ 0Q�  $ 0:0:1.5��$ 1Q�U� $	 (UIElement.Opacity)�$
 label��.\�  $ 0��$ 0Q�  $ 0:0:0.3��$ 0Q�  $ 0:0:2��$ 1Q�U� $	 (UIElement.Opacity)�$
 combobox_shop_Select��.\�  $ 0��$ 0Q�  $ 0:0:0.3��$ 0Q�  $ 0:0:2��$ 1Q�U� $	 (UIElement.Opacity)�$
 label1��.\�  $ 0��$ 0Q�  $ 0:0:0.7��$ 0Q�  $ 0:0:2.4��$ 1Q�U� $	 (UIElement.Opacity)�$
 combobox_warehouse_select��.\�  $ 0��$ 0Q�  $ 0:0:0.7��$ 0Q�  $ 0:0:2.4��$ 1Q�U� $	 (UIElement.Opacity)�$
 label2��.\�  $ 0��$ 0Q�  $ 0:0:1��$ 0Q�  $ 0:0:2.8��$ 1Q�U� $	 (UIElement.Opacity)�$#
 combobox_warehouse_loc_select��.\�  $ 0��$ 0Q�  $ 0:0:1��$ 0Q�  $ 0:0:2.8��$ 1Q�U� $	 (UIElement.Opacity)�$
 button_add_shop_to_ware��.\�  $ 0��$ 0Q�  $ 0:0:1.4��$ 0Q�  $ 0:0:2��$	 0.7Q�  $ 0:0:2.5��$	 0.2Q�  $ 0:0:3.2��$ 1Q�U� $	 (UIElement.Opacity)�$"
 button_delete_shop_from_ware��.\�  $ 0��$ 0Q�  $ 0:0:1.4��$ 0Q�  $ 0:0:2��$	 0.7Q�  $ 0:0:2.5��$	 0.2Q�  $ 0:0:3.2��$ 1Q�U� $	 (UIElement.Opacity)�$
 datagrid_admin12��.\�  $ 0��$ 0Q�   $ EaseIn=�  $ 0:0:1.5��$ 0Q�   $ EaseIn=�  $ 0:0:2.3��$ 1Q�   $ EaseIn=�  $ 0:0:3.2��$ 1Q�   $ EaseIn=�U� $	 (FrameworkElement.Width)�$
 datagrid_admin12��.\�  $ 0��$	 250Q�   $ EaseIn=�  $ 0:0:1.5��$	 250Q�   $ EaseIn=�  $ 0:0:2.3��$	 250Q�   $ EaseIn=�  $ 0:0:3.2��$	 250Q�   $ EaseIn=�U� $	 (FrameworkElement.Height)�$
 datagrid_admin12��.\�  $ 0��$ 30Q�   $ EaseIn=�  $ 0:0:1.5��$ 30Q�   $ EaseIn=�  $ 0:0:2.3��$ 30Q�   $ EaseIn=�  $ 0:0:3.2��$	 330Q�   $ EaseIn=�U� $	 (UIElement.Opacity)�$
 admin_img_png��.\�  $ 0��$ 1Q�   $ EaseIn=�  $ 0:0:0.5��$ 0Q�   $ EaseIn=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     RenderingBias$ Quality=�   Opacity$	 0.7Q�   
BlurRadius$ 3Q�   	Direction$	 314Q�   ShadowDepth$ 3Q� � Triggers :�  :� RoutedEvent$ Mouse.MouseEnter�� :� 
SourceName$ close��.[��� -    ��Name$! MouseEnter1_BeginStoryboard��#��[ ��  �� BeginStoryboardName$! Mouseleave1_BeginStoryboard��:� $ Mouse.MouseEnter��$ image��.[��� -   $( "Minimizemouseneter_BeginStoryboard��#��[ �� $' !Minimiazmoseleave_BeginStoryboard��:� $ Mouse.MouseLeave��$ image��.[��� -   $' !Minimiazmoseleave_BeginStoryboard��#��[ �� $( "Minimizemouseneter_BeginStoryboard��:� $ Mouse.MouseLeave��$ close��.[��� $! MouseEnter1_BeginStoryboard���� -   $! Mouseleave1_BeginStoryboard��#��[ :� $ FrameworkElement.Loaded��.[��� -   $) #Minimizemouseneter_BeginStoryboard1��#��[ �� -   $( "Minimiazmoseleave_BeginStoryboard1��#��[ :� $ ButtonBase.Click��$ _dialogShow��.[��� -   $( "OnSizeChangedstart_BeginStoryboard��#��[ :� $ ButtonBase.Click��$
 back��.[��� $( "OnSizeChangedstart_BeginStoryboard��.��� $��Center=�.+��� �� -	    ��Name$	 bs2��}�. $��Center=�$	��460��$��Center=�$	��780��.+��� -
    ��Name$ Фигура_1��$	��469�� �� Left$ -3��$#��bs2_Images\Фигура 1.png��
 �� Top$ 0��$	��784���� -   $ Слой_1__копия_��$	��469��$ -3��$,��&bs2_Images\Слой 1 (копия).png��$ 74��$	��784���� -   $ Фигура_2��$��3��$ -4��$#��bs2_Images\Фигура 2.png��$ 73��$	��786���� -   $ Фигура_3��$��29��$	 645��$#��bs2_Images\Фигура 3.png��$ 0��$	��136���� -   $ 	BookStore��$��30��$	 289��$��bs2_Images\BookStore.png��$ 19��$	��139���� -   $ 
Слой_3��$��29��$	 646��$��bs2_Images\Слой 3.png��$ 0��$	��137���� -   $ Группа_1��$��26��$	 643��$ -5��$	��138��.+��� -   $ Фигура_4��$��19��$ 0��$#��bs2_Images\Фигура 4.png��$ 0��$	��138���� -   $ close��$��17��$
 73.5��$'��!bs2_Images\close (копия).png��$ 9��$��45��$	 0.7Q� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� �� -    ��Name$ combo1��$ 20��$	 110��$	��130��&   System.Windows.Media.TextOptions    TextFormattingMode$  Display=�! � ToolTip$! Choose the shop��" �� SelectedIndex$" 0��$y�Hidden=�&	   System.Windows.Controls.DataGrid	  -   # 	 Name$# 	datagrid1��$ 	  	RowHeight$$ 60Q�% 	  AutoGenerateColumns% .  $	 173��$	 110��$	��330��$	��580��#��� �����	#191395BB& 	  HeadersVisibility$& Column=�' 	  RowBackground' �	#00000000( 	  HorizontalGridLinesBrush#( � ��) 	  VerticalGridLinesBrush#) � ��$  Display=�* 	  CanUserReorderColumns* .  + 	  CanUserResizeColumns+ .  , 	  CanUserResizeRows, .  - 	  
IsReadOnly- . . 	  ColumnHeaderHeight$. 30Q�"/ 	  VerticalScrollBarVisibility$/ Visible=�$y�Hidden=�0 	  SelectionMode$0 Single=�1 	  Columns1 0
  *System.Windows.Controls.DataGridTextColumn
  ,  &System.Windows.Controls.DataGridColumn2   Header$2 	Book Name��3   Width5  /System.Windows.Controls.DataGridLengthConverter$3 * 1  +System.Windows.Controls.DataGridBoundColumn4   Binding4 �� *	reader0+5   ElementStyle5 �� 6 �� 
TargetType"6 ��.��� 7 �� Property7 � ��8 �� Value$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9   EditingElementStyle9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 	Shop Name��$3 80 4 �� *	reader4+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Authors��$	3 100 4 �� *	reader3+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Genre��$3 70 4 �� *	reader2+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Price��$3 40 4 �� *	reader1+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Amount��$3 SizeToHeader 4 �� *	reader5+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  ��� -   : ��Name$
: user��$��Login as Client��$��70��$	 487��$	 110��$	��230��$"! All function for shop client��$  Display=����	#FF6BBB0A�� -   $: 	expeditor��$��Login as Expeditor��$	 487��$	 200��$	��230��$��70                     ��$  Display=�$ ! All function for expeditor�����	#FFDA1400�� -   $ img_openbook��$	��512��$	 -44��$	 -37��$	��512��$��bs2_Images/Book_icon.png��   ;   Color$; 	#FF897777��$	 0.5Q��� -   $ img_expeditor��$	��455��$	 144��$ 80��$	��631��$"��bs2_Images/expeditor_png.png��$y�Hidden=�   $; 	#FF897777��$	 0.5Q��� -   $ admin_img_png��$	��440��$	 170��$ 80��$	��603��$��bs2_Images/admin_png.png��$y�Hidden=�   $; 	#FF897777��$	 0.5Q��� -   $: admin��$��Login as Administrator��$	 487��$	 290��$	��230��$��70                     ��$)! #All function for shop administrator��$  Display=����	#FF573633�� -   < ��Name$< label_c��$��
SBS© 2013��$	 650��$	 415��#��� ��$  Display=��� -   $
: back��$
��Back��$ 20��$ 28��$��75��$  Display=����	#FF573633$y�Hidden=�	  -   $# datagrid_orderstatus��$$ 60Q�% .  $	 173��$	 110��$	��330��$	��580��#��� �����	#191395BB$& Column=�' �	#00000000#( � ��#) � ��$  Display=�* .  + .  , .  - . $. 30Q�$/ Visible=�$y�Hidden=�$0 Single=�1 
  $2 ID��$3 20 4 �� *	reader0+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Status��$3 80 4 �� *	reader6+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 	Book Name��$3 * 4 �� *	reader1+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Amount��$3 SizeToHeader 4 �� *	reader2+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Client��$3 80 4 �� *	reader3+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 	Warehouse��$3 80 4 �� *	reader4+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 	Expeditor��$3 80 4 �� *	reader5+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �	  -   $# datagrid_warehouse��$$ 60Q�% .  $	 173��$	 110��$	��330��$	��580��#��� �����	#191395BB$& Column=�' �	#00000000#( � ��#) � ��$  Display=�* .  + .  , .  - . $. 30Q�$/ Visible=�$y�Hidden=�$0 Single=�1 
  $2 	Shop Name��$3 * 4 �� *	reader0+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Warehouse Name��$3 * 4 �� *	reader1+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Warehouse Location��$3 * 4 �� *	reader2+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �	  -   $# datagrid_books��$$ 60Q�% .  $	 173��$	 110��$	��330��$	��580��#��� �����	#191395BB$& Column=�' �	#00000000#( � ��#) � ��$  Display=�* .  + .  , .  - . $. 30Q�$/ Visible=�$y�Hidden=�$0 Single=�1 
  $2 	Shop Name��$3 80 4 �� *	reader0+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Warehouse Name��$	3 120 4 �� *	reader1+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 	Book Name��$3 * 4 �� *	reader2+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Amount��$3 SizeToHeader 4 �� *	reader3+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  ��� -    = ��Name$= StackPanel_Expeditor��> �� Orientation$> Vertical=�$	��Top=�$��LeftToRight=�$ 20��$	 110��? �� CanVerticallyScroll? . ��. .+��� -!   @ ��Name$@ order_list_box��$  Display=�$y�Hidden=� A �� PathB �� RelativeSourceC �� AncestorType��%W   '9�       �� "6 9�.��� 7 �@9�
IsExpanded8 �� $A 
IsSelected�B �� "C ��.@�9� -"   D 9�Name$D order_status_expander�����	#191395BB$	��135��$��Order's��$  Display=����� $	��180��$	��Top=�.���� $	��180��.+�� $	��305��.+��� -#   E ��Name$	E New��$��Нова��$  Display=�$��15��$��83��$��	20,20,0,0q�$	��Top=�$
��Left=��� -$   $E 	completed��$��Виконана��$  Display=�$��15��$��83��$��	20,35,0,0q�$	��Top=�$
��Left=��� -%   $E rejected��$��Відхилена��$  Display=�$��15��$��83��$��	20,50,0,0q�$	��Top=�$
��Left=��� -&   $E 
inprogress��$��У виконанні��$  Display=�$��15��$��83��$��	20,65,0,0q�$
��Left=�$	��Top=��� -'   $E canceled��$��Скасована��$  Display=�$��15��$��83��$��	20,80,0,0q�$	��Top=�$
��Left=��� $��Order status��$	��105��$	��Top=�$��1q�$
��Left=�$	��105��$��5,0,0,0q���Z� �� -(   $: order_status_change��$��Process order...��$	��105��$��20��$��	5,110,0,0q�$	��Top=�$
��Left=��� -)   $: complete_order��$��Complete Order��$	��105��$��20��$��	5,133,0,0q�$	��Top=�$
��Left=�{�.  �� -*   $: reject_order��$��Reject Order��$	��105��$��20��$��	5,156,0,0q�$	��Top=�$
��Left=�{�.  9� -+   $D Warehouse_expander�����	#191395BB$	��135��$��
Warehouses��$  Display=����� $��30��$	��Top=�.���� $��30��.+��� -,   $: 
shoow_ware��$��Show...��$	��105��$��20��$��5,5,0,0q�$	��Top=�$
��Left=�9� --   $D Books_expander�����	#191395BB$	��135��$��Books��$  Display=����� $��55��$	��Top=�.���� $��55��.+�� $��55��.+��� -.   $ combobox_exp_books��$ 20��$	 110��$	��105��$��5,5,0,0q�$  Display=�$! Choose the shop��$y�Visible=�$��20��$	��Top=�$
��Left=�$" 0���� -/   $: book_add_new��$��Add New Book...��$	��105��$��20��$��5,28,0,0q�$	��Top=�$
��Left=����� F �� 
TargetType"F ��.R��� ���� "6 ��.��� 7 � ��8 �� "F ��.R��� #��z���� -0   $= StackPanel_Admin��$> Vertical=�$	��Top=�$��LeftToRight=�$ 20��$	 110��? . ��. .+��� -1   $@ admin_panel_left��$  Display=�$y�Hidden=� ��%W   '9�       �� "6 9�.��� 7 �@9�
IsExpanded8 �� $A 
IsSelected�B �� "C ��.@�9� -2   $D admin_warehouse�����	#191395BB$	��135��$��
Warehouses��$  Display=����� $��65��$	��Top=�.���� $��65��.+�� $��65��.+��� -3   $: admin_warehouse_add_btn��$��Add Warehouse...��$	��105��$��20��$��5,10,0,0q�$	��Top=�$
��Left=�{�. �� -4   $: _dialogShow��$��Shop/Warehouse��$	��105��$��20��$��5,35,0,0q�$	��Top=�$
��Left=�{�. ���� "F ��.R��� ���� "6 ��.��� 7 � ��8 �� "F ��.R��� #��z���� -5   $= StackPanel_CLIENT��$> Vertical=�$	��Top=�$��LeftToRight=�$ 20��$	 140��? . ��. .+��� -6   $@ client_list��$  Display=� ��%W   '9�       �� "6 9�.��� 7 �@9�
IsExpanded8 �� $A 
IsSelected�B �� "C ��.@�9� -7   $D client_orders�����	#191395BB$	��135��$��Orders��$  Display=�$y�Hidden=����� $	��100��$	��Top=�.���� $	��100��.+�� $	��100��.+��� -8   G ��Name$G txt_box_client_name��$��23��$	��Top=�$��5,10,5,0q����	#66FFFFFF���	#660E87DA$
��Name��$��Center=�$��Center=����	#990065AA�� -9   $G txtbox_client_surr��$��23��$	��Top=�$��5,38,5,0q����	#66FFFFFF���	#660E87DA$��Surname��$��Center=�$��Center=����	#990065AA�� -:   $: client_add_order��$��Show orders...��$	��105��$��20��$��5,72,0,0q�$	��Top=�$
��Left=�{�. ���� "F ��.R��� ���� "6 ��.��� 7 � ��8 �� "F ��.R��� #��z���� -;   $= Admin12��$> Vertical=�$	��Top=�$��LeftToRight=�$	 170��$	 110��? . ��. $	��220��$	��330�����	#191395BB$y�Hidden=�.+��� -<   $@ admin_panel_center��$  Display=� ��%W   '9�       �� "6 9�.��� 7 �@9�
IsExpanded8 �� $A 
IsSelected�B �� "C ��.@�� .+��� -=   $< label��$��Shop:��$��20��$	��Top=�$��
0,20,200,0q�$��Right=�$��Right=�$��48��$��0q�$��Center=��� ->   $��combobox_shop_Select��$��20��$��	0,20,25,0q�$��Right=�$	��160��$	��Top=��� -?   $< label1��$��
Warehouse:��$��20��$	��Top=�$��
0,50,200,0q�$��Right=�$��72��$��Right=�$��0q�$��Center=��� -@   $��combobox_warehouse_select��$��20��$��	0,50,25,0q�$��Right=�$	��160��$	��Top=��� -A   $< label2��$��Warehouse location:��$��20��$	��Top=�$��-18,80,200,-5q�$��Right=�$	��120��$��Right=�$��0q�$��Center=��� -B   $#��combobox_warehouse_loc_select��$��20��$��	0,80,25,0q�$��Right=�$	��160��$	��Top=��� -C   $��button_add_shop_to_ware��$��Add Shop��$
��Left=�$	��100��$��
25,0,0,-80q�$��20��$��Bottom=��� -D   $"��button_delete_shop_from_ware��$��Remove Shop��$��Right=�$	��100��$��
0,0,25,-80q�$��21��$��Bottom=����� "F ��.R��� ���� "6 ��.��� 7 � ��8 �� "F ��.R��� #��z���� -E   $< 
label_type��$"��Selected warehouse is Shared��$��Center=�$��Center=�$��Disabled=����	#FF780000$��16(�$��0,10,0,0q�	  -F   $# datagrid_admin12��$$ 40Q�% .  $	��330��#��� �����	#191395BB$& Column=�' �	#00000000#( � ��#) � ��$  Display=�* .  + .  , .  - . $. 30Q�$/ Visible=�$0 Single=�$	 515��$	 110��$	��250��$ 0Q�$y�Hidden=�1 
  $
2 Shop��$3 * 4 �� *	reader0+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 	Warehouse��$3 85 4 �� *	reader1+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Location��$3 75 4 �� *	reader2+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �	  -G   $# datagrid_client_5��$$ 60Q�% .  $	 173��$	 110��$	��330��$	��580��#��� �����	#191395BB$& Column=�' �	#00000000#( � ��#) � ��$  Display=�* .  + .  , .  - . $. 30Q�$/ Visible=�$y�Hidden=�$0 Single=�1 
  $2 	Book Name��$3 * 4 �� *	reader0+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Amount��$3 SizeToHeader 4 �� *	reader1+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 	Shop Name��$	3 100 4 �� *	reader2+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $2 Status��$	3 100 4 �� *	reader3+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  �
  $
2 Date��$	3 120 4 �� *	reader4+5 �� "6 ��.��� 7 � ��$
8 Wrap=��� 7 �@��TextAlignment$8 Center=��� 7 � ��$8 Center=�9 �� "6 ��.��� 7 � ��
8 ��  ��� -H   $ image��$��672.667,4,89.333,438q�$��bs2_Images/minimiz.png��$
��Fill=�$��18��$��18��$	 0.7Q�