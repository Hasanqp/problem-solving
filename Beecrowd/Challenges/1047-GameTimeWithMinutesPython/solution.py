start_h, start_m, end_h, end_m = map(int, input().split())

start_total = start_h * 60 + start_m
end_total = end_h * 60 + end_m

if end_total <= start_total:
    end_total += 24 * 60

duration = end_total - start_total
hours = duration // 60
minutes = duration % 60

print(f"O JOGO DUROU {hours} HORA(S) E {minutes} MINUTO(S)")
