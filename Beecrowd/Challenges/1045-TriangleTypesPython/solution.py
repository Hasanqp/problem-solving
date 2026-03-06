A, B, C = map(float, input().split())

# Sort in decreasing order
sides = sorted([A, B, C], reverse=True)
A, B, C = sides

if A >= B + C:
    print("NAO FORMA TRIANGULO")
else:
    if A**2 == B**2 + C**2:
        print("TRIANGULO RETANGULO")
    if A**2 > B**2 + C**2:
        print("TRIANGULO OBTUSANGULO")
    if A**2 < B**2 + C**2:
        print("TRIANGULO ACUTANGULO")
    if A == B == C:
        print("TRIANGULO EQUILATERO")
    elif A == B or A == C or B == C:
        print("TRIANGULO ISOSCELES")
