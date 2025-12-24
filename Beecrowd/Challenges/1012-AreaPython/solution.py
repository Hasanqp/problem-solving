values = input().split()
A = float(values[0])
B = float(values[1])
C = float(values[2])

TRIANGULO = (A * C) / 2
CIRCULO = 3.14159 * C * C
TRAPEZIO = (A + B) * (C / 2)
QUADRADO = B * B
RETANGULO = A * B

print(f"TRIANGULO: {TRIANGULO:.3f}")
print(f"CIRCULO: {CIRCULO:.3f}")
print(f"TRAPEZIO: {TRAPEZIO:.3f}")
print(f"QUADRADO: {QUADRADO:.3f}")
print(f"RETANGULO: {RETANGULO:.3f}")