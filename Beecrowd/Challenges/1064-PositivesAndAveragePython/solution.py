count = 0
sum_pos = 0

for i in range(6):
    number = float(input())
    if number > 0:
        count += 1
        sum_pos += number

average = sum_pos / count
print(f"{count} valores positivos")
print(f"{average:.1f}")
