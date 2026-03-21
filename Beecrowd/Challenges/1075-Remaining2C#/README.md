# Beecrowd Challenge 1075 - Remaining 2

## 📋 Problem Description
- **Problem ID:** 1075
- **Title:** Remaining 2
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1075)

### Problem Statement
Read an integer N. Print all numbers between 1 and 10000 (inclusive) that, when divided by N, leave a remainder of 2.

## 💡 Solution Approach

### Strategy
1. Read integer N
2. Loop from 1 to 10000
3. Check if i % N == 2
4. If true, print the number
5. Each number on a new line

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read N value |
| `for (int i = 1; i <= 10000; i++)` | Loop through all numbers |
| `i % N == 2` | Check if remainder is 2 |
| `Console.WriteLine(i)` | Print number if condition is true |

## ⚠️ Important Notes
- **Single integer input** N (N < 10000)
- **Range:** 1 to 10000 inclusive
- **Condition:** `i % N == 2` (remainder of division equals 2)
- **One number per line**
- **N could be larger than 2** (no numbers will satisfy condition if N ≤ 2)
