   M S B A M L   `   `   `  ����E  AAlgorithms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Algorithms
Algorithms  5   	       Algorithms.Sort   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Algorithms     5   	   -   5          � Title$
  Sort��5   	   $	��650��6   $
��1200��6#   ���	#FF930F0F � WindowStartupLocation$ CenterScreen=�6G    � 
ResizeMode$ CanMinimize=�6l   .��5	      � .+�5
   
   � -   5         �Name$ grid1��5
      .+�5      �� -   5         ��Name$ sliderNumber��5       � Minimum$ 0Q�6+    � Maximum$
 2000Q�67   $��129,10,880.667,579q�6F    �� IsSnapToTickEnabled . 6}   �� 5      -   5         ��Name$ 	ArrayTime��5      ���#EEEEEE$��868,10,111.667,582q�6@   �� 5      -   5        $ LinkedListTime��5      ���#EEEEEE$��531,10,468.667,582q�6E   �� 5      -   5        	 ��Name$	 NumberTextBox��5      $��319,10,835.667,582q�6-   ��6t   �� 
 �� Path$
 Value� �� ElementName$ sliderNumber�� �� Mode$ OneWay=�6�   �� 5      -   5         ��Name$ btnSortArray��5      $��
Sort Array��6+   $��1088,10,9.667,582q�6@   6[   �� 5      -   5        $ btnSortLinkedList��5      $��731,10,339.667,582q�60   $��Sort Linked List��6L   6g   �� 5      -	   5        $ 	btnRandom��5      $��364,10,754.667,582q�6(   $��Random��6D   6U   �� 5      -
   5        $ BtnReset��5      $��445,10,668.667,582q�6'   $��Reset��6C   6l   �� 5      -   5        $ txbAlgorithms��5      $��10,10,1074.667,587q�6/   6M   5      �� 5   
   -   5         ��Name$ canvas1��5      $��10,50,14,10q�6"   ���#ccc5*      5,      5-      