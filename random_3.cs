using System;

class Program {
    static void Main() {
        Random rand = new Random(42);

        // 0 이상 1 미만 실수
        Console.WriteLine(rand.NextDouble());

        // 1 ~ 100 정수
        Console.WriteLine(rand.Next(1, 101));

        // 배열에서 무작위 선택
        string[] pick = { "짜장면", "짬뽕", "볶음밥" };
        Console.WriteLine(pick[rand.Next(pick.Length)]);
    }
}