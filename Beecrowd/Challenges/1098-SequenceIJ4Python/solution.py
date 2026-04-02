I = 0.0

while I <= 2.0001:
    for j in range(1, 4):
        J = I + j

        I_rounded = round(I, 1)
        J_rounded = round(J, 1)

        if I_rounded % 1 == 0:
            print(f"I={int(I_rounded)} J={int(J_rounded)}")
        else:
            print(f"I={I_rounded:.1f} J={J_rounded:.1f}")

    I += 0.2