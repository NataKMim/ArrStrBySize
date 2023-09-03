string[] AddStrToArr(string[] arrStr, string s)
{
    int count = arrStr.Length + 1;
    string [] arrStr_tmp = new string[count];
    
    for (int i = 0; i < count-1; i++)
    {
        arrStr_tmp[i] = arrStr[i];
    }
    arrStr_tmp[count-1] = s;
    return arrStr_tmp;
}

void PrintArrStr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    return;
}

string[] SelArrStrBySize(string[] arr, int size)
{
    string[] arrStrSz;
    arrStrSz = new string[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= size) 
        {
            arrStrSz = AddStrToArr(arrStrSz, arr[i]);
        }
    }
    return arrStrSz;
}

string [] arr_str;
string [] arr_str_s3;
int count = 0;
int sz = 3;
string s;

arr_str  =  new string[count];
Console.WriteLine("Введите массив строк");

do
{
    s = Console.ReadLine();
    if (s != "") arr_str = AddStrToArr(arr_str, s);

} while (s != "");

arr_str_s3 = SelArrStrBySize(arr_str, sz);

Console.WriteLine("Полученный массив строк:");
PrintArrStr(arr_str);

if (arr_str_s3.Length > 0) 
{
    Console.WriteLine($"Массив строк,  длиной до {sz} символов включительно:");
    PrintArrStr(arr_str_s3);
}
else Console.WriteLine($"Строк длиной до {sz} символов включительно не обнаружено");
