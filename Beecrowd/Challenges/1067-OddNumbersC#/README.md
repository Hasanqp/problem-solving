# Beecrowd Challenge 1067 - Odd Numbers

## 📋 Problem Description
- **Problem ID:** 1067
- **Title:** Odd Numbers
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1067)

### Problem Statement
Read an integer value X (1 ≤ X ≤ 1000). Print all odd numbers from 1 to X, each on a new line, including X if it is odd.

## 💡 Solution Approach

### Strategy
1. Read integer X
2. Loop from 1 to X
3. Check if each number is odd using modulo operator
4. Print odd numbers only

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read X value |
| `for (int i = 1; i <= X; i++)` | Loop from 1 to X |
| `i % 2 != 0` | Check if number is odd |
| `Console.WriteLine(i)` | Print odd number |

## ⚠️ Important Notes
- **Single integer input** X
- **X range:** 1 to 1000
- **Odd numbers:** not divisible by 2 (i % 2 != 0)
- **Start from 1** (first odd number)
- **One number per line**