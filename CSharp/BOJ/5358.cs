﻿using System.Text;
namespace BOJ;
class P5358
{
    static void Main0() => new P5358().Solve();
    StreamReader sr = new(Console.OpenStandardInput(), bufferSize: 102400);
    StreamWriter sw = new(Console.OpenStandardOutput(), bufferSize: 102400);
    int[] dx = { 0, 0, -1, 1, -1, -1, 1, 1, 0 };
    int[] dy = { -1, 1, 0, 0, -1, 1, 1, -1, 0 };
    bool Step(int x, int y, int r, int c) => x < 0 || x >= r || y < 0 || y >= c;
    string ReadLineUntil() { string s; do { s = sr.ReadLine(); } while (s.Length <= 0); return s; }
    string[] seps = { " ", "\t", };
    string[] ReadSplit() => ReadLineUntil().Split(seps, StringSplitOptions.RemoveEmptyEntries);
    T[] ReadArray<T>(Func<string, T> f) => ReadSplit().Select(f).ToArray();
    T Read1<T>(Func<string, T> f) => f(ReadLineUntil());
    (T, T) Read2<T>(Func<string, T> f) { var s = ReadArray(f); return (s[0], s[1]); }
    (T, T, T) Read3<T>(Func<string, T> f) { var s = ReadArray(f); return (s[0], s[1], s[2]); }

    void Solve()
    {
        var sb = new StringBuilder();
        while (!sr.EndOfStream)
        {
            var str = ReadLineUntil();
            foreach(var c in str)
            {
                if (c == 'i')
                    sb.Append('e');
                else if (c == 'e')
                    sb.Append('i');
                else if (c == 'I')
                    sb.Append('E');
                else if (c == 'E')
                    sb.Append('I');
                else
                    sb.Append(c);
            }
            sw.WriteLine(sb.ToString());
            sb.Clear();
        }

        sw.Flush();
    }
}