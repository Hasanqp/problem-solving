max_value = 0
position = 0

for i in range(1, 101):
    number = int(input())
    if number > max_value:
        max_value = number
        position = i

print(max_value)
print(position)