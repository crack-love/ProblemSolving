import sys
def input_line(): return sys.stdin.readline().strip()
def input_cast(f): return f(input_line())
def input_unpack(f): return map(f, input_line().split())
