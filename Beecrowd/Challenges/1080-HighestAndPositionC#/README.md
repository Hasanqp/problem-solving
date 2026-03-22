# Beecrowd Challenge 1080 - Highest and Position

## 📋 Problem Description
- **Problem ID:** 1080
- **Title:** Highest and Position
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1080)

### Problem Statement
Read 100 distinct positive integer numbers. Find and print the highest number and its position in the input sequence (1-based index).

## 💡 Solution Approach

### Strategy
1. Initialize `max` to 0 (since all numbers are positive)
2. Initialize `position` to 0
3. Loop from 1 to 100 (1-based indexing)
4. For each number, compare with current maximum
5. If greater, update `max` and record `position`
6. Print the highest number and its position

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int max = 0` | Track highest number (start at 0) |
| `int position = 0` | Track position of highest number |
| `for (int i = 1; i <= 100; i++)` | Loop 100 times with 1-based index |
| `int.Parse(Console.ReadLine())` | Read each number |
| `if (number > max)` | Check if current number is higher |
| `max = number; position = i;` | Update highest value and position |
| `Console.WriteLine(max)` | Print highest number |
| `Console.WriteLine(position)` | Print position (1-based) |

## ⚠️ Important Notes
- **100 integer inputs** (one per line)
- **Distinct positive numbers** (no duplicates, all > 0)
- **Position is 1-based** (first input is position 1)
- **Initialize `max = 0`** ensures first number is always higher
- **Two lines of output:** highest number first, then position