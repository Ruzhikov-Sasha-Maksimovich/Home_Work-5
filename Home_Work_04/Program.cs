void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");
      else 
      {
        Console.Write($"{array[i,j]} ");
      }
    }
    Console.WriteLine();
  }
}
System.Console.WriteLine("Введите размеры:");
int stolbec = Convert.ToInt32(Console.ReadLine()!);
int[,] spiralMassive = new int[stolbec, stolbec];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMassive.GetLength(0) * spiralMassive.GetLength(1))
{
  spiralMassive[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMassive.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMassive.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMassive.GetLength(1) - 1)
    j--;
  else
    i--;
}
PrintArray(spiralMassive);