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
| `int.Parse(Console.ReadLine())` | Read N value |
| `for (int i = 1; i <= 10; i++)` | Loop from 1 to 10 |
| `int result = i * N` | Calculate product |
| `Console.WriteLine($"{i} x {N} = {result}")` | Print multiplication table line |

## ⚠️ Important Notes
- **Single integer input** N (1 < N < 1000)
- **Multiplication table** from 1 to 10
- **Format exactly:** `{i} x {N} = {result}`
- **One line per multiplication**