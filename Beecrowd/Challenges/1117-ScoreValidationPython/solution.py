valid_scores = []
invalid_messages = []

while len(valid_scores) < 2:
    score = float(input())
    if 0 <= score <= 10:
        valid_scores.append(score)
    else:
        print("nota invalida")

media = sum(valid_scores) / 2
print(f"media = {media:.2f}")