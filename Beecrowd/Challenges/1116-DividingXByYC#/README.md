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
| `int.Parse(Console.ReadLine())` | Read number of test cases |
| `Console.ReadLine().Split(' ')` | Read and split X and Y |
| `if (Y == 0)` | Check for division by zero |
| `(double)X / Y` | Cast to double for decimal result |
| `ToString("F1")` | Format to 1 decimal place |

## ⚠️ Important Notes
- **First input:** N (number of test cases)
- **Each test case:** two integers X and Y
- **Division by zero:** print "divisao impossivel"
- **Use casting** to double for accurate division
- **1 decimal place** in output

## 🚀 How to Run
```bash
dotnet run