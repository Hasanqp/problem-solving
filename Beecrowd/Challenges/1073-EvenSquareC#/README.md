# Beecrowd Challenge 1073 - Even Square

## 📋 Problem Description
- **Problem ID:** 1073
- **Title:** Even Square
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1073)

### Problem Statement
Read an integer N. Print the square of each even number from 1 to N (inclusive if N is even).

## 💡 Solution Approach

### Strategy
1. Read integer N
2. Loop from 1 to N
3. Check if current number is even
4. Calculate its square
5. Print in format: `{number}^2 = {square}`

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read N value |
| `for (int i = 1; i <= N; i++)` | Loop from 1 to N |
| `if (i % 2 == 0)` | Check if number is even |
| `int square = i * i` | Calculate square |
| `Console.WriteLine($"{i}^2 = {square}")` | Print formatted result |

## ⚠️ Important Notes
- **Single integer input** N
- **N range:** 5 < N < 2000
- **Only even numbers** are processed
- **Format exactly:** `{i}^2 = {square}`
- **No scientific notation** (ensure integer output)