using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  * 날짜 : 2022년 07월 12일
  * 이름 : 김동민
  * 내용 : C# 개발환경 설정, hello world 출력 교재 p44
  */

namespace Ch01
{
    
    internal class helloworld
    {
        static void Main(string[] args)
        {
            // 기본출력
            Console.WriteLine("hello world");
            Console.WriteLine("hello C#!");

            // 서식출력
            Console.WriteLine("hello");
            Console.WriteLine("Korea\n");

            // 포맷출력
            Console.WriteLine("{0}, {1}", "hell", "Busan");
        }   
    }
}
    