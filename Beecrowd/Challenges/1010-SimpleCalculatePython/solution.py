line1 = input().split()
code1 = int(line1[0])
units1 = int(line1[1])
price1 = float(line1[2])

line2 = input().split()
code2 = int(line2[0])
units2 = int(line2[1])
price2 = float(line2[2])

total = units1 * price1 + units2 * price2
print(f"VALOR A PAGAR: R$ {total:.2f}")