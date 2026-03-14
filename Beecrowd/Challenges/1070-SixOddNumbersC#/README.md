# Beecrowd Challenge 1070 - Six Odd Numbers

## 📋 Problem Description
- **Problem ID:** 1070
- **Title:** Six Odd Numbers
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1070)

### Problem Statement
Read an integer value X and print the 6 consecutive odd numbers starting from X, each on a new line. If X is even, start from the next odd number.

## 💡 Solution Approach

### Strategy
1. Read integer X
2. If X is even, increment by 1 to make it odd
3. Print 6 odd numbers by adding 2 each time
4. Each number on a new line

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read X value |
| `if (X % 2 == 0) X++` | Ensure starting from odd number |
| `for (int i = 0; i < 6; i++)` | Loop 6 times |
| `Console.WriteLine(X)` | Print current odd number |
| `X += 2` | Move to next odd number |

## ⚠️ Important Notes
- **Single integer input** X
- **X can be any positive integer**
- **If X is even:** start from X+1 (next odd)
- **If X is odd:** include X as first number
- **Six consecutive odd numbers** total
- **Step of 2** between consecutive odds