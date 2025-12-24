values = input().split()
a = int(values[0])
b = int(values[1])
c = int(values[2])

maiorAB = (a + b + abs(a - b)) // 2
maior = (maiorAB + c + abs(maiorAB - c)) // 2

print(f"{maior} eh o maior")