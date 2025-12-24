totalSeconds = int(input())
hours = totalSeconds // 3600
remainingSeconds = totalSeconds % 3600
minutes = remainingSeconds // 60
seconds = remainingSeconds % 60
print(f"{hours}:{minutes}:{seconds}")