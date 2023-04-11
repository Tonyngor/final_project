// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите количество строк: ");
int numberOfLines = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[numberOfLines];
for (int i = 0; i < numberOfLines; i++)
{
    Console.WriteLine("Введите строку: " + i);
    stringArray[i] = Console.ReadLine();
}
void coontCharacters()
{
    Console.WriteLine();
    Console.WriteLine("Строки с количеством символов 3 или меньше: ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        string text = stringArray[i];
        int characters = 0;
        for (int j = 0; j < text.Length; j++)
        {
            characters = characters + 1;
        }
        if (characters <= 3)
        {
            Console.WriteLine(text);
        }
    }
}
coontCharacters();
