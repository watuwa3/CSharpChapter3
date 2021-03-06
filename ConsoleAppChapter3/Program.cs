// C#プログラミングのイディオム／定石＆パターン
// Chapter 3.1.2 デリゲートによる実現
// Chapter 3.1.3 匿名メソッドの利用 (C# 2.0以降)
// Chapter 3.2.1 最も冗長なラムダ式 (C# 3.0以降)
// Chapter 3.2.2 judge変数の除去、if文の除去
// Chapter 3.2.3 { return }の除去、型の明示除去、()の除去
// Chapter 3.2.4 ラムダ式を使った例

using System;
using System.Numerics;
using System.Collections.Generic;

int Count(int[] _numbers, Predicate<int> judge)
{
    int count = 0;
    foreach (var n in _numbers)
    {
        //Console.WriteLine("param={0}", n % 2);
        if (judge(n) == true)
            count++;
    }
    return count;
}

var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

Console.WriteLine("Count(n % 2) = {0}", Count(numbers, n => n % 2 == 0));
Console.WriteLine("Count(n % 1) = {0}", Count(numbers, n => n % 2 == 1)); // 奇数の数をカウント
Console.WriteLine("Count(n >= 5) = {0}", Count(numbers, n => n >= 5)); // 5以上の数をカウント
Console.WriteLine("Count(5 < n <10) = {0}", Count(numbers, n => 5 <= n && n < 10)); // 5以上10未満の数をカウント
Console.WriteLine("Count(Contains'1') = {0}", Count(numbers, n => n.ToString().Contains('1'))); // 数字の'1'を含まれている数をカウント
