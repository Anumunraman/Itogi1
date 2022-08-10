namespace Project
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите количество строк, которые хотите ввести: ");
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
            string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите строку №{0}:\r\n    ", i + 1);
                strs[i] = Console.ReadLine(); //Заполняем его
            }
            Console.WriteLine("Вы ввели следующие строки:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(strs[i]);
            }
            Console.Write("Нажмите [Enter] для выхода...");
            Console.ReadLine();
            var resultArr = strs.Where(x=>x.Length < 4).ToArray();
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < resultArr.Length; i++)
            {
                Console.Write(resultArr[i] + "\t");
            }
            Console.WriteLine();

        }
        
    }
}




 