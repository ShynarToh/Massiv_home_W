//Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

namespace massiv_3
{
    public class Program 
    {
        public static void Main (string [] arg){
            Random rand = new Random();

            int size = 100;
            double [] array = new double [size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.NextDouble() * new Random().Next(1, 100);
            }
            foreach (double item in array)
            {
                System.Console.Write (item + " ");
            }
            
            double maxDigit = 0;
            double minDigit = 0;
            
            for (int i = 0; i <size; i++)
            {
                 if ( array [i] > maxDigit)   
                     {
                       maxDigit = array [i];
                       i++;                      
                     }    
                     if ( array [i] < minDigit)   
                     {
                       minDigit = array [i];
                       i++;                      
                     }                      
            }
            double result = maxDigit - minDigit;
             Console.Write($" => {result}");
             
        }

    }
}
