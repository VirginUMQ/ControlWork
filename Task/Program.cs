Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16"); // вывод кириллицы в терминал

// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// =============================================================================================



string [] CreateArray () 
{
    Console.WriteLine ("\t\tИтоговая контрольная работа\n\t\t  Создание массива строк");
    
    int numEl = 0;

    for (int i = 0; i == 0;) {
        Console.Write("Введите количество строк в массиве (> 0): ");
    bool check = int.TryParse(Console.ReadLine(), out numEl);
    if (numEl > 0 && check) { i++; }
    }

    string [] Ar = new string [numEl];

    for (int i = 0; i < Ar.Length; i++) {
        Console.Write($"Введите произвольную строку для {i} элемента массива: ");
        Ar[i] = Console.ReadLine();
    }

    return Ar;
}



void PrintUserArray (string [] UserAr) {
    Console.WriteLine("\nВы создали массив из следующих строк:");
    foreach (string i in UserAr) { Console.WriteLine(i); }
}



string [] ChangeArray (string [] UserAr)
{
    
    int count = 0;
    for (int i = 0; i < UserAr.Length; i++) {
        if (UserAr[i].Length <= 3) { count ++; }
    }

    string [] NewArray = new string [count];

    for (int i = 0, k = 0; i < NewArray.Length; k++) {
        if (UserAr[k].Length <= 3) { NewArray[i] = UserAr[k]; i++; }
    }

    return NewArray;
}



void PrintNewArray (string [] NewAr)
{
    if (NewAr.Length == 0) { Console.WriteLine("\nВ массиве все строки имеют более 3 символов."); }
    else {
    Console.WriteLine("\nМассив из строк, длина которых меньше, либо равна 3 символам:");
    foreach (string i in NewAr) { Console.WriteLine(i); }
    }
}



Console.Clear();
string [] UserArray = CreateArray();
PrintUserArray(UserArray);
string [] NewArray = ChangeArray(UserArray);
PrintNewArray(NewArray);


