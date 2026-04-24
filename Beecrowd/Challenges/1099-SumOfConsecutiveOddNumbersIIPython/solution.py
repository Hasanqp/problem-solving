N = int(input())

for _ in range(N):
    X, Y = map(int, input().split())
    
    min_val = min(X, Y)
    max_val = max(X, Y)
    
    total = 0
    for i in range(min_val + 1, max_val):
        if i % 2 != 0:
            total += i
    
    print(total)