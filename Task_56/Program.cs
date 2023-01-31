int[,] create2DIntArray(int rows, int cols) { 
 Random rnd = new Random();     
 int[,] array = new int[rows, cols]; 
 for (int i = 0; i < rows * cols; i++) 
 { 
  array[i / cols , i % cols] = rnd.Next(1, 10); 
 } 
 return array; 
} 
void show2DIntArray(int[,] array) 
{ 
 Console.WriteLine("My 2D int array:"); 
 for (int i = 0; i < array.GetLength(0); i++) 
 { 
  for (int j = 0; j < array.GetLength(1); j++) 
  { 
   Console.Write(array[i,j] + "\t"); 
  } 
  Console.WriteLine(); 
 } 
} 
void NumberRowMinSum(int[,] array) 
{ 
    int minRow = 0; 
    int minSumRow = 0; 
    int sumRow = 0; 
    for (int i = 0; i < array.GetLength(1); i++) 
    { 
        minRow += array[0, i]; 
 } 
     for (int i = 0; i < array.GetLength(0); i++) 
     { 
         for (int j = 0; j < array.GetLength(1); j++)  
   sumRow += array[i, j]; 
   Console.WriteLine("Sum of " + (i+1) + " row: " + sumRow); 
         if (sumRow < minRow) 
         { 
             minRow = sumRow; 
             minSumRow = i; 
         } 
         sumRow = 0; 
     } 
     Console.Write($"{minSumRow + 1} line"); 
} 
int[,] my2DIntArray = create2DIntArray(3, 4); 
show2DIntArray(my2DIntArray); 
Console.WriteLine(); 
NumberRowMinSum(my2DIntArray);