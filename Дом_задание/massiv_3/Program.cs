//1. Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
namespace massiv_3
{
    public class Program 
    {
        public static void Main (string [] arg){
            Random rand = new Random();

            int size = 10;
            int [] array = new int [size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next (1, 100);
            }
            
            int count = 0;
            for (int i = 0; i <size; i++)
            {
                 if ( array [i] > 20 && array [i]< 90)   
                     {
                       count = count + 1;                      
                     }                   
            }
            foreach (int item in array)
            {
                System.Console.Write (item + " ");
            }
             Console.Write($"=>, {count}");
             
        }

    }
}
 




