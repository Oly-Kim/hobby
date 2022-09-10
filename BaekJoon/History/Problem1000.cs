using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.History
{
    public static  class Problem1000
    {
        public static void Submit()
        {
            //두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

            //INPUT
            //첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)

            //OUTPUT
            //첫째 줄에 A+B를 출력한다.

            string[] inputMessage = Console.ReadLine().Split();
            int a = Convert.ToInt32(inputMessage[0]);
            int b = Convert.ToInt32(inputMessage[1]);
            int sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
