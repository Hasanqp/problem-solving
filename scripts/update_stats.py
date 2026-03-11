import os
import json
import re

cs_count = 0
py_count = 0

for root, dirs, files in os.walk("Beecrowd/Challenges"):
    for file in files:
        if file.endswith(".cs"):
            cs_count += 1
        elif file.endswith(".py"):
            py_count += 1

data = {
    "total": cs_count + py_count,
    "cs": cs_count,
    "py": py_count
}

# write stats.json
with open("stats.json", "w") as f:
    json.dump(data, f, indent=2)

# update README
with open("README.md", "r", encoding="utf-8") as f:
    content = f.read()

new_stats = f"""| Metric | Count |
|---|---|
| Total Problems | {data["total"]} |
| C# Solutions | {data["cs"]} |
| Python Solutions | {data["py"]} |
| Platforms | Beecrowd |
"""

content = re.sub(
    r"\| Metric \| Count \|[\s\S]*?\| Platforms .*?\|",
    new_stats,
    content
)

with open("README.md", "w", encoding="utf-8") as f:
    f.write(content)
