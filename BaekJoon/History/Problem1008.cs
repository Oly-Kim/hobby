using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon.History
{
    public static class Problem1008
    {
        public static void Submit()
        {
            //두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.

            //INPUT
            //첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)

            //OUTPUT
            //첫째 줄에 A/B를 출력한다. 실제 정답과 출력값의 절대오차 또는 상대오차가 10-9 이하이면 정답이다.

            //0.33 3333333333 3333333333 3333333333
            string[] inputMessage = Console.ReadLine().Split();
            double a = double.Parse(inputMessage[0]);
            double b = double.Parse(inputMessage[1]);
            double dv = a / b;
            Console.WriteLine("{0:f12}", dv);
        }
    }
}
