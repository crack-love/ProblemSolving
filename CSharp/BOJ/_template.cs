﻿using System.Collections.Immutable;

namespace BOJ;
class P
{
    StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
    StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    int[] dx = new int[] { 0, -1, 0, 1, -1, -1, 1, 1, 0 };
    int[] dy = new int[] { -1, 0, 1, 0, -1, 1, 1, -1, 0 };
    bool OutOfBound(int r, int c, int x, int y) => x < 0 || x >= r || y < 0 || y >= c;
    string[] ReadLine() => sr.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
    static void Main0()
    {
        new P().Solve();
    }

    void Solve()
    {
        sw.Flush();
    }
}