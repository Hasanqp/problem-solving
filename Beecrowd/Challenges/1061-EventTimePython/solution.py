# Read start day
start_day_input = input().split()
start_day = int(start_day_input[1])

# Read start time
start_hour, start_minute, start_second = map(int, input().split(' : '))

# Read end day
end_day_input = input().split()
end_day = int(end_day_input[1])

# Read end time
end_hour, end_minute, end_second = map(int, input().split(' : '))

# Convert to seconds
start_total = start_day * 86400 + start_hour * 3600 + start_minute * 60 + start_second
end_total = end_day * 86400 + end_hour * 3600 + end_minute * 60 + end_second

# Calculate duration
duration = end_total - start_total

# Convert back
days = duration // 86400
duration %= 86400
hours = duration // 3600
duration %= 3600
minutes = duration // 60
seconds = duration % 60

# Print results
print(f"{days} dia(s)")
print(f"{hours} hora(s)")
print(f"{minutes} minuto(s)")
print(f"{seconds} segundo(s)")
