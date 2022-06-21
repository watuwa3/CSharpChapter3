// C#プログラミングのイディオム／定石＆パターン
// Chapter 3.1 汎用性のない Count メソッド
int Count(int num)
{
    var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    int count = 0;
    foreach (var number in numbers)
    {
        if (number == num)
            count++;
    }
    return count;
}

Console.WriteLine("Count(5) = {0}", Count(5));
