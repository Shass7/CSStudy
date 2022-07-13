using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 2022/07/13
 * 이름 김동민
 * 내용 문자열 실습하기 교재 p112
 * 
 *
 */

namespace Ch02
{
    internal class _6_문자열
    {
        static void Main(string[] args)
        {
            string greeting = "Good Moring";
            Console.WriteLine(greeting);
            Console.WriteLine();

            // 문자열 길이
            Console.WriteLine("길이 :"+greeting.Length);
            Console.WriteLine();

            // 문자열 추출
            Console.WriteLine("greeting 1번째 문자:" + greeting[0]);
            Console.WriteLine("greeting 6번째 문자:" + greeting[6]);

            // 문자열 인덱스
            Console.WriteLine("'G' 인덱스 : " + greeting.IndexOf('G');
            Console.WriteLine("'M' 인덱스 : " + greeting.IndexOf('M');
            Console.WriteLine("'G' 인덱스 : " + greeting.IndexOf('G');
            Console.WriteLine("'G' 인덱스 : " + greeting.LastIndexOf('o');
            
            // 문자열 자르기

            // 문자열 교체
            string replaced = greeting.Replace("Moring," "Afternoon")
            Console.WriteLine(replaced);
            Console.WriteLine();

            // 문자열 변환
            int     var1 = 1;
            double  var2 = 2.123;
            bool    var3 = true;

            string  str1=var1.ToString();
            string  str2=var2.ToString();
            string  str3=var3.ToString();

            Console.WriteLine("str1 :"+str1);
            Console.WriteLine("str2 :"+str2);
            Console.WriteLine("str3 :"+str3f);

            string s1 = "100";
            string s2 = "3.14";
            string s3 = "false";

            int     r1 = int.Parse(s1);
            double  r1 = double.Parse(s2);
            bool    r1 = bool.Parse(s2);

            Console.WriteLine("r1 :"+r1);
            Console.WriteLine("r2 :"+r2);
            Console.WriteLine("r3 :"+r3);


        }
    }
}
