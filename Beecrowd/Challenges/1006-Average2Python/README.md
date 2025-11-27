# Beecrowd Challenge 1006 - Average 2

## 📋 Problem Description
- **Problem ID:** 1006
- **Title:** Average 2  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1006)

### Problem Statement
Calculate the student's average with weights 2, 3, and 5 for three grades, and print the result with 1 decimal place in the format: `MEDIA = {average}`

## 💡 Solution Approach

### Strategy
1. Read three float values (grades A, B, and C)
2. Calculate weighted average: (A × 2 + B × 3 + C × 5) / 10
3. Print the result with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `float(input())` | Reads input and converts to float |
| `(A * 2 + B * 3 + C * 5) / 10` | Calculates weighted average |
| `{MEDIA:.1f}` | Formats output to 1 decimal place |
| `print(f"MEDIA = {MEDIA:.1f}")` | Outputs result in required format |

## 🚀 How to Run
```bash
python solution.py