import os
import re

cs_count = 0
py_count = 0

for root, dirs, files in os.walk("."):
    for file in files:
        if file.endswith(".cs"):
            cs_count += 1
        if file.endswith(".py"):
            py_count += 1

total = cs_count + py_count

with open("README.md", "r", encoding="utf-8") as f:
    content = f.read()

new_stats = f"""| Metric | Count |
|---|---|
| Total Problems | {total} |
| C# Solutions | {cs_count} |
| Python Solutions | {py_count} |
| Platforms | Beecrowd |"""

content = re.sub(
    r"\| Metric.*?\| Platforms .*?\|",
    new_stats,
    content,
    flags=re.S
)

with open("README.md", "w", encoding="utf-8") as f:
    f.write(content)