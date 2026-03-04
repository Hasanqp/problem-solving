n1, n2, n3, n4 = map(float, input().split())

media = (n1*2 + n2*3 + n3*4 + n4) / 10
print(f"Media: {media:.1f}")

if media >= 7.0:
    print("Aluno aprovado.")
elif media < 5.0:
    print("Aluno reprovado.")
else:
    print("Aluno em exame.")
    exam = float(input())
    print(f"Nota do exame: {exam:.1f}")
    final = (media + exam) / 2
    print("Aluno aprovado." if final >= 5.0 else "Aluno reprovado.")
    print(f"Media final: {final:.1f}")
