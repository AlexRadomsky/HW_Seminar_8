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
void sortRows(int [,]arr) 
{ 
 // loop for rows of array 
    for (int i = 0; i < arr.GetLength(0); i++) 
 { 
  // loop for column of array 
  for (int j = 0; j < arr.GetLength(1); j++) 
  { 
   for (int k = 0; k < arr.GetLength(1) - j - 1; k++) 
   { 
    if (arr[i, k] < arr[i, k + 1]) 
    { 
     int t = arr[i, k]; 
     arr[i, k] = arr[i, k + 1]; 
     arr[i, k + 1] = t; 
                } 
            } 
        } 
    } 

    for (int i = 0; i < arr.GetLength(0); i++) 
 { 
  for (int j = 0; j < arr.GetLength(1); j++) 
   Console.Write(arr[i, j] + "\t"); 
        Console.WriteLine(); 
    } 
} 
 
int[,] my2DIntArray = create2DIntArray(3, 4); 
show2DIntArray(my2DIntArray); 
Console.WriteLine("My sorted array: "); 
sortRows(my2DIntArray);