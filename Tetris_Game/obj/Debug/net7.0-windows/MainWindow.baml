   M S B A M L   `   `   `  ????F  BTetris_Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tetris_GameTetris_Game  5   	       Tetris_Game.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Tetris_Game     5   	   -   5          ? Title$  Tetris??5   	   $	??600??6   $	??800??6%   $	??600??5	   	   $	??600??6   
???????$??Segoe UI Light)?5   	   $??28(?5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??auto  ?6   ?? 5      $??* ?6   ??5   
   ?? 5       ?? ImageSource$ Assets/Background.png??6   .+?5   
   (? $??1??6   $??1??5      $??0,0,0,20q?5      .??5    
   ?? -   5         ??Name$ 
GameCanvas??5       
???   ?$	??250??5#      $	??500??5$      $
}?True??5%      5&      5(      ?? 5)   
   -   5         ??Name$ 	ScoreText??5)      $??0??5*      $??1??5+      $??Score: ??5,      $
??0,10q?5-       ?? TextAlignment$ Center=?5.      ?? 50   
   $??1??6   $??0??51      $??Center=?52      $??Right=?53      .+?54      ?? $
??Hold??6   $ Center=?55      ?? 56      -   5         ??Name$ 	HoldImage??56      $??20q?57      $	??125??58      59      ?? 5:   
   $??1??6   $??2??5;      $??Center=?5<      $
??Left=?5=      .+?5>      ?? $
??Next??6   $ Center=?6$   ?? 5?      -   5        $ 	NextImage??5?      $??20q?5@      $	??125??5A      5B      ? 5C   
   -   5         ?Name$ GameOverMenu??5C   #   $y?Hidden=?6   ???	#CC000000$??2??6P   $??3??6a   .+?5D      ?? $??Center=?6   $??Center=?66   .+?5E      ?? $??	Game Over??6   $??48(?6-   $ Center=?6;   ?? 5F      -   5        $ FinalScoreText??5F      $??Score: ??5G       $??36(?6/   $ Center=?6=   ?? 5H      -   5        $??
Play again??5H      
???????$??0,0,20,0q?5J      $??5q?5K      5L      5N      5O      5P      5Q      