﻿using HW2;

Task1 matrix = new Task1();

/*int[,] snakeMatrix1 = matrix.VerticalSnake(3, 4);
matrix.Print(snakeMatrix1);*/

/*int[,] snakeMatrix2 = matrix.DiagonalSnake(5);
matrix.Print(snakeMatrix2);*/

/*int[,] snakeMatrix3 = matrix.HorizontalSpiralSnake(3, 4);
matrix.Print(snakeMatrix3);
*/

int[,] snakeMatrix3 = matrix.VerticalSpiralSnake(3, 4);
matrix.Print(snakeMatrix3);