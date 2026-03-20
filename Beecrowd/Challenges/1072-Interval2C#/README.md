# Beecrowd Challenge 1072 - Interval 2

## 📋 Problem Description
- **Problem ID:** 1072
- **Title:** Interval 2
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1072)

### Problem Statement
Read an integer N, then read N integer numbers X. Count how many of these X values are inside the interval [10, 20] and how many are outside this interval.

## 💡 Solution Approach

### Strategy
1. Read N (number of test cases)
2. Initialize counters for in and out
3. Loop N times to read each X
4. Check if X is in interval [10,20] (inclusive)
5. Increment appropriate counter
6. Print both counts with "in" and "out" messages

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read N and each X |
| `int inCount = 0, outCount = 0` | Initialize counters |
| `for (int i = 0; i < N; i++)` | Loop N times |
| `if (X >= 10 && X <= 20)` | Check if X is in interval |
| `inCount++` or `outCount++` | Increment appropriate counter |
| `Console.WriteLine($"{inCount} in")` | Print results |

## ⚠️ Important Notes
- **First input:** N (number of values)
- **Next N lines:** integer values X
- **Interval [10,20]** includes 10 and 20
- **Counters:** one for "in", one for "out"
- **Output format:** `{inCount} in` and `{outCount} out`
- **N < 10000**, X range: -10⁷ < X < 10⁷
