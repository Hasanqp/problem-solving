X = int(input())
Y = int(input())

min_val = min(X, Y)
max_val = max(X, Y)
sum_odds = 0

for i in range(min_val + 1, max_val):
    if i % 2 != 0:
        sum_odds += i

print(sum_odds)
