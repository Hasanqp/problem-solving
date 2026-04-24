# Beecrowd Challenge 1099 - Sum of Consecutive Odd Numbers II

## 📋 Problem Description
- **Problem ID:** 1099
- **Title:** Sum of Consecutive Odd Numbers II
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1099)

### Problem Statement
Read N test cases. For each test case, read two integers X and Y. Calculate and print the sum of all odd numbers between them (excluding X and Y themselves).

## 💡 Solution Approach

### Strategy
1. Read integer N (number of test cases)
2. For each test case:
   - Read X and Y
   - Determine min and max values (order doesn't matter)
   - Initialize sum to 0
   - Loop from min+1 to max-1
   - Add odd numbers to sum
   - Print the sum

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read number of test cases |
| `Console.ReadLine().Split(' ')` | Split X and Y from input |
| `Math.Min(X, Y)` | Find smaller value |
| `Math.Max(X, Y)` | Find larger value |
| `for (int i = min + 1; i < max; i++)` | Loop between numbers (exclusive) |
| `i % 2 != 0` | Check if number is odd |
| `sum += i` | Add odd number to sum |
| `Console.WriteLine(sum)` | Print result for each test case |

## ⚠️ Important Notes
- **First input:** N (number of test cases)
- **Each test case:** two integers X and Y
- **Order doesn't matter** (X can be larger than Y)
- **Exclude X and Y** from sum
- **Only odd numbers** are added
- **Print one result per test case**