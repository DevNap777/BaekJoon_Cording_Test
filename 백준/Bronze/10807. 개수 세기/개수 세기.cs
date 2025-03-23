using System.Data;

namespace backjun_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 첫째 줄에 정수 갯수 N
            // 둘째 줄에는 정수가 공백으로 구분되어 있음
            // 셋째 줄에는 찾으려고 하는 정수 V

            // 첫째 줄 정수 입력
            int number = int.Parse(Console.ReadLine());

            // 둘째 줄 정수 공백으로 지정
            string[] findNum = Console.ReadLine().Split( );

            // 셋째 줄 정수 입력
            int v = int.Parse(Console.ReadLine());

            // 결과를 담을 수 있는 정수형 변수 선언
            int result = 0;
            // 반복문 설정
            // i는 0부터 시작, 첫째 줄 정수보다 작으면 종료, 1씩 증가
            for (int i = 0; i < number; i++)
            {   // 만약 찾고자 하는 정수가 배열 안에 있으면
                if (v == int.Parse(findNum[i]))
                    // 1씩 증가
                result++;
            }
            Console.WriteLine(result);
        }   
    }
}