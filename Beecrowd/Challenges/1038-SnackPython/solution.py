X, Y = map(int, input().split())

prices = {
    1: 4.00,
    2: 4.50,
    3: 5.00,
    4: 2.00,
    5: 1.50
}

total = prices[X] * Y
print(f"Total: R$ {total:.2f}")
