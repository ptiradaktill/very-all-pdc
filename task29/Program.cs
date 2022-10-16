Console.WriteLine("Введите цифры массива.Пример: 2, 4, 6, 2, 6, 0, 1, 6"); 
string[] arrNum = Console.ReadLine().Split(", ");
if (arrNum.Length != 8 ) 
{ 
    Console.WriteLine("Данный массив не состоит из 8 символов!"); 
    return; 
}
int[] digArr = new int[arrNum.Length];
for(int i = 0; i < arrNum.Length; i++) 
{ 
    digArr[i] = Int32.Parse(arrNum[i]); 
} 
Console.WriteLine("[{0}]" , string.Join(", ", digArr));