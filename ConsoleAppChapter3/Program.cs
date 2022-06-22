// C#プログラミングのイディオム／定石＆パターン
// Chapter 3.1.2 デリゲートによる実現
// Chapter 3.1.3 匿名メソッドの利用 (C# 2.0以降)
// Chapter 3.2.1 最も冗長なラムダ式 (C# 3.0以降)
// Chapter 3.2.2 judge変数の除去、if文の除去

using System;
using System.Numerics;
using System.Collections.Generic;

int Count(int[] _numbers, Predicate<int> judge)
{
    int count = 0;
    foreach (var n in _numbers)
    {
        Console.WriteLine("param={0}", n % 2);
        if (judge(n) == true)
            count++;
    }
    return count;
}

var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };

var count = Count(numbers, (int n) => { return n % 2 == 0; });

Console.WriteLine("Count(n % 2) = {0}", count);
