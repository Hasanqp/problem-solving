# Beecrowd Challenge 1116 - Dividing X by Y

## 📋 Problem Description
- **Problem ID:** 1116
- **Title:** Dividing X by Y
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1116)

### Problem Statement
Read N pairs of integers X and Y. For each pair, calculate and print X ÷ Y with 1 decimal place. If Y = 0, print "divisao impossivel".

## 💡 Solution Approach

### Strategy
1. Read N (number of test cases)
2. Loop N times:
   - Read X and Y
   - If Y == 0, print "divisao impossivel"
   - Else, calculate X / Y and print with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Read number of test cases |
| `for _ in range(N):` | Loop N times |
| `map(int, input().split())` | Read and convert X and Y |
| `if Y == 0:` | Check for division by zero |
| `print("divisao impossivel")` | Print error message |
| `else:` | Valid division case |
| `f"{X / Y:.1f}"` | Calculate and format to 1 decimal place |

## ⚠️ Important Notes
- **First input:** N (number of test cases)
- **Each test case:** two integers X and Y
- **Division by zero:** print "divisao impossivel"
- **Automatic float division** in Python
- **1 decimal place** in output

## 🚀 How to Run
```bash
python solution.py