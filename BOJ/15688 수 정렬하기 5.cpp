// https://www.acmicpc.net/problem/15688

#include <bits/stdc++.h>
#define for1(i,r) for(int i=0;i<r;++i)
#define for2(i,j,r,c) for(int i=0;i<r;++i)for(int j=0;j<c;++j)
#define step(i,j,r,c) if (i < 0 || j < 0 || i >= r || j >= c) continue
const int dx[4] = { 0,0,1,-1 }, dy[4] = { 1,-1,0,0 };
using namespace std;

struct p15688
{
	int main()
	{
		ios::sync_with_stdio(0);
		cin.tie(0); cout.tie(0);

		int n;
		cin >> n;
		int a[(int)1e6];
		for1(i, n)
		{
			cin >> a[i];
		}

		sort(a, a + n);
		for1(i, n)
		{
			cout << a[i] << "\n";
		}

		return 0;
	}
};