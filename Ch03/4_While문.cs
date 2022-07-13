using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  날짜 : 2022/07/13
 *  이름 : 김철학
 *  내용 : 반복문 while 실습하기 교재 p162
 * 
 */
namespace Ch03
{
    internal class _4_While문
    {
        static void Main2(string[] args)
        {
            // while
            int sum=0;
            int k = 1;

            while (k<=10)
            {
                sum += k;
                k++;
            }
            Console.WriteLine("1부터 10까지의 합:"+sum);
            
            // do ~ while : 최초 1번 반복을 수행하는 반복문
            int total=0;
            int i = 1;

            do
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
                i++;
            }
            while (i<=10);
            Console.WriteLine("1부터 10까지의 짝수합"+total);

            // break
            int num = 1;

            while (true)
            {
                if (num % 5 == 0)
                {
                    break; //반복문 종료(브레이크)
                }
                num++;
            }
            // continue
        }
    }
}
