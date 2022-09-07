System.Console.WriteLine("Введите rows: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите stolbec: ");
int stolbec = Convert.ToInt32(Console.ReadLine()!);

int[,] array = new int[rows, stolbec];
NewArray(array);
WriteArray(array);

int minSum = 0;
int sumLine = GetSumFromArray(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = GetSumFromArray(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSum = i;
  }
}




int GetSumFromArray(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

void NewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
System.Console.WriteLine(minSum + 1 + " (" + sumLine + ")");