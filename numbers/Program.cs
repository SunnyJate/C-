// int a = 18;
// int b = 6;
// int c = a + b;
// Console.WriteLine(c);
// int a = 2100000000;
// int b = 2100000000;
// long c = checked(a + b);
// Console.WriteLine(c);
// int count=0;
//  for (int a = 0; a <= 10; a++)
 
//  {
//     for (int b = 1; b <= 10; b++)
//     {
//         for (int c = a + b; c<=20;)
//         {

//             bool myTest = c > 10;

//             if(myTest){
//                 Console.WriteLine($"The ouptup is greater than 10 which is {a} + {b} ={c}");
//                 // count++;
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine($"The ouptup is smaller than 10 which is {a} + {b} = {c}");
//                 count++;
//                 break;
//             }
            
//         }
        
//     }
//  }
//  Console.WriteLine($"Number of operations are {count}");

// int max = int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"The range of integers is {min} to {max}");

// int what = max - 3;
// Console.WriteLine($"An example of overflow: {what}");
 

 int sum = 0;
 for (int number = 1; number < 21; number++)
 {
    if(number % 3 == 0 )
    {
        sum = sum + number;
    }
 }
 Console.WriteLine($"The sum is {sum}");