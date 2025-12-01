# Beecrowd Challenge 1011 - Sphere

## 📋 Problem Description
- **Problem ID:** 1011
- **Title:** Sphere  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1011)

### Problem Statement
Calculate the volume of a sphere given its radius (R) using the formula:  
**V = (4/3) × π × R³**  
Use π = 3.14159 and print the result with 3 decimal places.

## 💡 Solution Approach

### Strategy
1. Read the radius value as float
2. Calculate volume: (4/3) × π × R³
3. Print result in exact format: `VOLUME = {volume}`

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `float(input())` | Reads radius as float |
| `(4.0/3.0) * 3.14159 * R**3` | Calculates sphere volume |
| `{VOLUME:.3f}` | Formats output to 3 decimal places |

## ⚠️ Important Notes
- **Use 4.0/3.0** not 4/3 to avoid integer division
- **Spaces required:** before and after "="
- **Three decimal places** mandatory
- **π = 3.14159** must be used

## 🚀 How to Run
```bash
python solution.py