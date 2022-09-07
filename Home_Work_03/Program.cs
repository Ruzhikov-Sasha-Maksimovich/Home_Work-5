void GetSumFromArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int oconchatelno = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = oconchatelno;
        }
      }
    }
  }
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

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
System.Console.WriteLine("Введите rows: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Введите stolbec: ");
int stolbec = Convert.ToInt32(Console.ReadLine()!);
int[,] array = new int[rows, stolbec];
NewArray(array);
PrintArray(array);

Console.WriteLine("\n" + "Окончательный массив");
GetSumFromArray(array);
PrintArray(array);