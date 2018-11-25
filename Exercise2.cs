using System;

namespace netcore_internship
{
    public static class Exercise2
    {
            // Sort an array of characters in alphabatic order
            public static void Run(){
                
                // Sort this array in alphabetical order and print the right order to the screen.        
                var arr = new char[]{ 'z','q','a','u','w','r','c','f'};
                // Your output should be: a c f q r u w z

                Array.Sort(arr);
                for(int i = 0; i < arr.Length; i++)
                {
                   Console.Write( arr[i]+" ");
                }
                Console.WriteLine();
                
            }
    }
}
