import os
import json

cs_count = 0
py_count = 0

for root, dirs, files in os.walk("Beecrowd/Challenges"):
    for file in files:
        if file.endswith(".cs"):
            cs_count += 1
        if file.endswith(".py"):
            py_count += 1

data = {
    "total": cs_count + py_count,
    "cs": cs_count,
    "py": py_count
}

with open("stats.json", "w") as f:
    json.dump(data, f)