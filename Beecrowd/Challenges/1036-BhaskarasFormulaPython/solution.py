import math

# Read input values
values = input().split()
A = float(values[0])
B = float(values[1])
C = float(values[2])

# Calculate discriminant
delta = B**2 - 4 * A * C

# Check if impossible to calculate
if A == 0 or delta < 0:
    print("Impossivel calcular")
else:
    # Calculate roots using Bhaskara's formula
    R1 = (-B + math.sqrt(delta)) / (2 * A)
    R2 = (-B - math.sqrt(delta)) / (2 * A)
    
    # Print results with 5 decimal places
    print(f"R1 = {R1:.5f}")
    print(f"R2 = {R2:.5f}")
