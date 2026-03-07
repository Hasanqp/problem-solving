valor = float(input())
# Convert to cents and add small epsilon for rounding
cents = int(valor * 100 + 0.001)

notas = [10000, 5000, 2000, 1000, 500, 200]
moedas = [100, 50, 25, 10, 5, 1]

print("NOTAS:")
for nota in notas:
    quantidade = cents // nota
    cents %= nota
    print(f"{quantidade} nota(s) de R$ {nota/100:.2f}")

print("MOEDAS:")
for moeda in moedas:
    quantidade = cents // moeda
    cents %= moeda
    print(f"{quantidade} moeda(s) de R$ {moeda/100:.2f}")