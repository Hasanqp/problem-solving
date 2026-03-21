# Beecrowd Challenge 1078 - Multiplication Table

## 📋 Problem Description
- **Problem ID:** 1078
- **Title:** Multiplication Table
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1078)

### Problem Statement
Read an integer N and print its multiplication table from 1 to 10.

## 💡 Solution Approach

### Strategy
1. Read integer N
2. Loop from 1 to 10
3. Calculate product: i × N
4. Print in format: `{i} x {N} = {result}`

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Read N value |
| `range(1, 11)` | Generate numbers from 1 to 10 |
| `i * N` | Calculate product |
| `print(f"{i} x {N} = {i * N}")` | Print multiplication table line |

## ⚠️ Important Notes
- **Single integer input** N (1 < N < 1000)
- **Multiplication table** from 1 to 10
- **Format exactly:** `{i} x {N} = {result}`
- **One line per multiplication**
- **Use range(1, 11)** to include 10