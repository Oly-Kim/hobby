using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.History
{
    public  class Problem10869
    {
        public static void Submit()
        {
            //두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 
            //두 자연수 A와 B가 주어진다. (1 ≤ A, B ≤ 10,000)
            //첫째 줄에 A+B,
            //둘째 줄에 A-B,
            //셋째 줄에 A*B,
            //넷째 줄에 A/B,
            //다섯째 줄에 A%B를 출력한다.

            // 7 3 
            //10
            //4
            //21
            //2
            //1
            string[] inputMessage = Console.ReadLine().Split();
            string a = inputMessage[0];
            string b = inputMessage[1];

            int addition = Int32.Parse(a) + Int32.Parse(b);
            int subtraction = Int32.Parse(a) - Int32.Parse(b);
            int multiplication = Int32.Parse(a) * Int32.Parse(b);
            double division = double.Parse(a) / double.Parse(b);
            int quotient = Int32.Parse(a) % Int32.Parse(b);
            Console.WriteLine(addition);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
            Console.WriteLine(quotient);
        }
        
    }
}
