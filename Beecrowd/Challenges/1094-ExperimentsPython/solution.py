N = int(input())

total = 0
coelhos = 0
ratos = 0
sapos = 0

for _ in range(N):
    amount, type_ = input().split()
    amount = int(amount)
    
    total += amount
    
    if type_ == 'C':
        coelhos += amount
    elif type_ == 'R':
        ratos += amount
    elif type_ == 'S':
        sapos += amount

percentC = (coelhos / total) * 100
percentR = (ratos / total) * 100
percentS = (sapos / total) * 100

print(f"Total: {total} cobaias")
print(f"Total de coelhos: {coelhos}")
print(f"Total de ratos: {ratos}")
print(f"Total de sapos: {sapos}")
print(f"Percentual de coelhos: {percentC:.2f} %")
print(f"Percentual de ratos: {percentR:.2f} %")
print(f"Percentual de sapos: {percentS:.2f} %")