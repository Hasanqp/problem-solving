while True:
    M, N = map(int, input().split())
    
    if M <= 0 or N <= 0:
        break
    
    min_val = min(M, N)
    max_val = max(M, N)
    
    numbers = list(range(min_val, max_val + 1))
    total = sum(numbers)
    
    print(f"{' '.join(map(str, numbers))} Sum={total}")