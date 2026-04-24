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
   - Initialize total to 0
   - Loop from min+1 to max-1
   - Add odd numbers to total
   - Print the total

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Read number of test cases |
| `map(int, input().split())` | Read and convert X and Y |
| `min(X, Y)` | Find smaller value |
| `max(X, Y)` | Find larger value |
| `range(min_val + 1, max_val)` | Loop between numbers (exclusive) |
| `if i % 2 != 0:` | Check if number is odd |
| `total += i` | Add odd number to total |
| `print(total)` | Print result for each test case |

## ⚠️ Important Notes
- **First input:** N (number of test cases)
- **Each test case:** two integers X and Y on one line
- **Order doesn't matter** (X can be larger than Y)
- **Exclude X and Y** from sum
- **Only odd numbers** (not divisible by 2)
- **Print one result per test case**