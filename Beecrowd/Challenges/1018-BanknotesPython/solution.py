value = int(input())
print(value)

banknotes = [100, 50, 20, 10, 5, 2, 1]
current_value = value

for note in banknotes:
    quantity = current_value // note
    current_value %= note
    print(f"{quantity} nota(s) de R$ {note},00")