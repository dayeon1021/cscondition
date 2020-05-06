﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());
            /*
            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다...");
            }else
            {
                Console.WriteLine("홀수입니다...");
            }
            
            switch(input % 2)
            {
                case 0: 
                    Console.WriteLine("짝수입니다...");
                    break;
                case 1:
                    Console.WriteLine("홀수입니다...");
                    break;

            }
            */

            Console.WriteLine(input > 0 ? "자연수입니다" : "자연수가 아닙니다");
            Console.WriteLine(input %2 == 0 ? "짝수입니다" : "홀수가 아닙니다");

            Console.Write("이번 달은 몇 월인가요? : ");
            int input2= int.Parse(Console.ReadLine());
            switch (input2)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;

                default:
                    Console.WriteLine("대체 어느 행성에서 살고 계십니까?");
                    break;
            }

            Console.Write("입력 :  ");
            String line = Console.ReadLine();
            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요!");
            }
            else
            {
                Console.WriteLine("인사 안해요??");
            }
        }
    }
}
