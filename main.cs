using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
      int[] celsiusArray = new int[7];
      int[] fahrenheitArray = new int[7];

    for(int i=0; i < celsiusArray.Length; i++)
    {
      Console.WriteLine("Enter temperature in Celsius: ");
      celsiusArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    
   Console.WriteLine("Temperature in Fahrenheit: " );
  
  for(int i=0; i < celsiusArray.Length; i++)

    {
     var fahrenheitTemp = ((celsiusArray[i]*9)/5)+32;
      fahrenheitArray[i] = fahrenheitTemp;
      Console.WriteLine(fahrenheitTemp);
    }
  
   Console.WriteLine("Sorted Array");
    
    Array.Sort(fahrenheitArray);
    Array.Reverse(fahrenheitArray);
    foreach (var temp in fahrenheitArray)

  
    Console.WriteLine(temp);
  
    Console.WriteLine("The Sum of the Fahrenheit Temperatures: ");
    Console.WriteLine(fahrenheitArray.Sum());
    
    Console.WriteLine("The Average Fahrenheit Temperature is: ");
    Console.WriteLine(fahrenheitArray.Average()+ " degrees Fahrenheit");
  }
}
      
    
    
      
  
