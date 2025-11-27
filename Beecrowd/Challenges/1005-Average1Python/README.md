# Beecrowd Challenge 1005 - Average 1

## 📋 Problem Description
- **Problem ID:** 1005
- **Title:** Average 1  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1005)

### Problem Statement
Calculate the student's average with weights 3.5 and 7.5 for two grades, and print the result with 5 decimal places in the format: `MEDIA = {average}`

## 💡 Solution Approach

### Strategy
1. Read two float values (grades A and B)
2. Calculate weighted average: (A × 3.5 + B × 7.5) / 11
3. Print the result with 5 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `float(input())` | Reads input and converts to float |
| `(A * 3.5 + B * 7.5) / 11` | Calculates weighted average |
| `{MEDIA:.5f}` | Formats output to 5 decimal places |
| `print(f"MEDIA = {MEDIA:.5f}")` | Outputs result in required format 

## 🚀 How to Run
```bash
python solution.py