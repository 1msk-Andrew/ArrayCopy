using System;

namespace Array_Copy
{
    class Program
    {
        public void Copy(Array first, Array second, int offset)
        {

        }
        static void Main(string[] args)
        {
            //Ввод пользовательских данных
            Console.Write("Введите элементы массива, который хотите изменить, через запятую --> ");
            string first_str = Console.ReadLine();
            Console.Write("Введите элементы второго массива через запятую --> ");
            string second_str = Console.ReadLine();
            Console.Write("Введите индекс, начиная с которого необходимо заменить элементы массива --> ");
            int index = Convert.ToInt32(Console.ReadLine());

            //Получение массивов из строк
            Array first = first_str.Split(", ");
            Array second = second_str.Split(", ");

            //Вывод полученного массива
            Console.Write("Полученный массив --> ");
            for (int i = 0; i < first.Length; i++)
            {
                Console.Write(first.GetValue(i));
                if (i != first.Length - 1)
                    Console.Write(", ");
            }
        }
    }
}
