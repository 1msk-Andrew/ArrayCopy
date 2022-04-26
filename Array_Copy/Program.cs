using System;
using System.Collections;

namespace Array_Copy
{
    class Program
    {
        public static object[] Copy(object[] first, object[] second, int offset)
        {
            for(int i = 0; i < second.Length; i++)
            {
                if (i + offset < first.Length)
                    first[i+offset] = second[i];
                else
                {
                    Array.Resize(ref first, offset + second.Length);
                    first[i + offset] = second[i];
                }
            }
            return first;
        }
        static void Main(string[] args)
        {
            //Ввод пользовательских данных
            Console.Write("Введите элементы массива, который хотите изменить, через запятую --> ");
            string first_str = Console.ReadLine();
            Console.Write("Введите элементы второго массива через запятую --> ");
            string second_str = Console.ReadLine();
            Console.Write("Введите индекс, начиная с которого необходимо заменить элементы массива --> ");
            int index;
            do 
            {
                index = Convert.ToInt32(Console.ReadLine());
                if (index < 0)
                    Console.Write("Введён индекс меньше нуля, повторите ввод --> ");
            } while (index < 0);

            //Получение массивов из строк
            string[] first = first_str.Split(", ");
            string[] second = second_str.Split(", ");
            //Измнение массива и конвертация в массив строк
            first = Array.ConvertAll(Copy(first, second, index), (object o) => (string)o);

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
