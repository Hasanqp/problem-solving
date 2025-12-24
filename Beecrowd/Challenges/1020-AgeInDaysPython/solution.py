totalDays = int(input())
years = totalDays // 365
remainingDays = totalDays % 365
months = remainingDays // 30
days = remainingDays % 30
print(f"{years} ano(s)")
print(f"{months} mes(es)")
print(f"{days} dia(s)")