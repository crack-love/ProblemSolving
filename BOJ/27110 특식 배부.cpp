// https://www.acmicpc.net/problem/27110

#include <bits/stdc++.h>
#define for1(i,r) for(int i=0;i<r;++i)
#define for2(i,j,r,c) for(int i=0;i<r;++i)for(int j=0;j<c;++j)
#define step(i,j,r,c) if (i < 0 || j < 0 || i >= r || j >= c) continue
#define fastio ios::sync_with_stdio(0); cin.tie(0); cout.tie(0)
#define x first
#define y second
#define all(x) x.begin(),x.end()
typedef int64_t ll;
const int dx[8] = { 0,0,1,-1,1,1,-1,-1 }, dy[8] = { 1,-1,0,0,1,-1,1,-1 };
using namespace std;

struct p27110
{
	int main()
	{
		fastio;

		int n;
		cin >> n;
		int a, b, c;
		cin >> a >> b >> c;
		int ans = 0;
		ans = min(n, a) + min(n, b) + min(n, c);
		cout << ans;

		return 0;
	};
}