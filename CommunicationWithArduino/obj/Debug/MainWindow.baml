   M S B A M L   `   `   `  ����S  OCommunicationWithArduino, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CommunicationWithArduinoCommunicationWithArduino  5   	   )    #CommunicationWithArduino.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:CommunicationWithArduino     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  J� RenderTransformOrigin$ 0.306,0.371&�6   $��0,0,10,1q�6/   ��5
   
   �� 5       j� Stretch$
 None=�6   .+�5   
   �� -   5         ��Name$ button2��5      $6��0Kliknij mnie jeśli
 dioda Cię nie przekonała��6"   $
��Left=�6b   $��
33,158,0,0q�6}   $	��Top=�6�   $	��148��6�   $��85��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ CheckBoxMainLight��5      $��Uwaga mocne wrażenia��6.   $
��Left=�6M   $��
51,256,0,0q�6h   $	��Top=�6|   6�   �� 5   
   $
��Left=�6   $	��124��61   $��	36,19,0,0q�6>   $	��Top=�6Q   $	��160��6i   #��� ��6u    J� OpacityMask# � ��6�   .+�5      �� $��
Connection��6   $��Center=�6)   $��0,5,0,15q�6F   �� 5      -   5         ��Name$ 
CBComPorts��5      $��25��6,   $	��120��68   $��Center=�6D   $	��Top=�6a   $��0,0,0,0q�6y   �� 5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5        $ 	BTconnect��5      $��Connect��60   $��25��6B   $��75��6N   $��23,21,62,19q�6r   $��0��6�   $��2��6�   $ 
0.493,0.52&�6�   �� 5      -   5         ��Name$ image1��5      $��1��6,   $��19��6>   $��25��6I   $��Center=�6U   $��Center=�6r   $��green_light.png��6�   $��23,21,38,19q�6�   �� 5      -   5        $ image2��5      $��1��6,   $��19��6>   $��25��6I   $��Center=�6U   $��Center=�6r   $��greenLight2.png��6�   $��23,21,38,19q�6�   $y�Hidden=�6�   5      5"      5$      �� 5%   
   -   5        	 ��Name$	 StackPanelControl��5%   E   $��201,49,98,175q�6   ���	#FFDEF9DC{�.  .+�5&      � ���	#FFFFD8D8$��94��6*    5'      �� 5(      �� 5)      
 � RowDefinitions
 5+      �� 5,      �� 5-      .+�5/      �� -   5        $ CheckBoxPWM��5/      $��Brightness 
Controll��60   $
��Left=�6S   $	��Top=�6o   $��2��6�   $��	98,11,0,0q�6�   $��2��6�   6�   d� 50      -	   5         d�Name$ CheckBoxDiode��50      $��	Power OFF��66   $
��Left=�6J   $	��Top=�6e   $��35��6�   $��77��6�   $��	10,10,0,0q�6�   �� 51      -
   5         ��Name$ Slider1��51      $
��Left=�6*   {�.  $	��Top=�6W   $��40��6o   $	��170��6{    � Maximum$	 255Q�6�   $��1��6�   $��2��6�   $��
10,10,0,-3q�6�    � SmallChange$ 20Q�6�    � LargeChange$ 30Q�6�   52      53      �� 54   
   -   5         ��Name$ Text1��54      $
��Left=�6#   $��286,178,0,0q�6>   $
��Wrap=�6S   $��0��6g   $	��Top=�6p   57      58      