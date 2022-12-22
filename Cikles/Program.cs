
//ЦИКЛ FOR

//string Method4(int count,string text)
//{
    
  //  string result = string.Empty; // результат = пустой строке
    //for(int i=0;i < count;i++)
    //{
      //result = result + text;
      
    //}
    //return result;
//}

//string res = Method4 (10, "z");
//Console.WriteLine (res);





//Цикл в цикле

for (int i = 2; i <= 10; i++)    //внешний цикл
{
   for (int j = 2; j <= 10; j++)      //внутренний цикл
    {
        Console.WriteLine ($"{i} * {j} = {i*j}");  // способ интерполяций строк
    }
    Console.WriteLine();
}