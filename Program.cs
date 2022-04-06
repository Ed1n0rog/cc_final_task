/* 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

string[] stringArray = {"hello", "123", "string", "hi"};
string[] newStringArray;
int a = 0;
newStringArray = new string[10];

for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        newStringArray[a] = stringArray[i];
        a++;
    }
}

for (int j = 0; j < newStringArray.Length; j++)
{
    Console.Write($"{newStringArray[j]} ");
}