using System;
using System.Collections.Generic;

namespace C_Review
{
    
    class Program
    {
        //print 1-255
        public static void PrintNums()
        {
            for(var i=1; i<256; i++){
                Console.WriteLine(i);
            }
        }

        //print odds 1-255
        public static void PrintOdds(){
            for(var i=1; i<256; i++){
                if(i%2>0){
                    Console.WriteLine(i);
                }
                else{
                    continue;
                }
            }
        }

        public static void PrintNumSum()
        {
            int sum = 0;
            for(var i=1; i<256; i++){
                sum= sum+i;
                Console.WriteLine("Number is {0} and the sum is {1}", i, sum);
            }
        }

        public static void Itterate(int[] arr){
            for(var i=0; i<arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }
        public static void findMax(int[] maxarr){
            int max = maxarr[0];
            for(var i=1; i<maxarr.Length; i++){
                if(maxarr[i]>max){
                    max= maxarr[i];
                }
                else{
                    continue;
                }
            }
            Console.WriteLine(max);
        }


        static void Main(string[] args)
        {
            //PrintNums();
            //PrintOdds();
            //PrintNumSum();
            //Itterate(new int[] {1, 2, -3, 4, -5});
            //findMax(new int[] {0, 1, 2, -3, 4, -5});




            //Multiplication table
        //     int[] numbers = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        //     int[,] multiply= new int[11,11];
        //     for(var i=1; i<=10; i++){
        //         for(var a=1; a<=10; a++){
        //             if(a == 1){
        //                 multiply[i,a] = i;
        //             }
        //             else{
        //             multiply[i,a]=i*a;  
        //             }
        //         }  
        //     }
       
        //     foreach(int line in multiply){
        //         Console.WriteLine(line);
        //     }
        // }

        }
    }
}

