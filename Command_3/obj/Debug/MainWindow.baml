   M S B A M L   `   `   `  ����D  @Command_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Command_3	Command_3  5   	       Command_3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (selfclr-namespace:Command_3     5   	     � Title$  
MainWindow��5   	   $	��200��6   $	��300��6)    � WindowStartupLocation$ CenterScreen=�65    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ self:CustomCommands.Exit��5
      6`   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   o� .@�5      m� $
��File��6   .@�5      m�  m� Command$ self:CustomCommands.Exit��6   5      5      �� 5   
   $��1��6   $��Center=�6"   $��Center=�6?   .+�5      �� $��self:CustomCommands.Exit��6   .��68   Exit6>   5      5      5      