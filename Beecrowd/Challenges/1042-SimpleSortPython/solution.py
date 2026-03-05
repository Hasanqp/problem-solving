a, b, c = map(int, input().split())
original = [a, b, c]
sorted_nums = sorted(original)

for num in sorted_nums:
    print(num)
print()
for num in original:
    print(num)