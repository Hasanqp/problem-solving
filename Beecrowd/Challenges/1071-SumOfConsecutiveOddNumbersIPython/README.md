# Beecrowd Challenge 1071 - Sum of Consecutive Odd Numbers I

## 📋 Problem Description
- **Problem ID:** 1071
- **Title:** Sum of Consecutive Odd Numbers I
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1071)

### Problem Statement
Read two integer values X and Y. Calculate and print the sum of all odd numbers between them (excluding X and Y themselves).

## 💡 Solution Approach

### Strategy
1. Read X and Y as integers
2. Determine the smaller (min) and larger (max) values
3. Initialize sum_odds to 0
4. Loop from min+1 to max-1 (exclusive of endpoints)
5. Check if each number is odd and add to sum
6. Print the total sum

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Read X and Y values |
| `min(X, Y)` | Find the smaller value |
| `max(X, Y)` | Find the larger value |
| `range(min_val + 1, max_val)` | Loop between numbers (exclusive) |
| `i % 2 != 0` | Check if number is odd |
| `sum_odds += i` | Add odd number to sum |

## ⚠️ Important Notes
- **Two integer inputs** (one per line)
- **Sum only numbers between X and Y** (exclusive)
- **Odd numbers:** not divisible by 2 (i % 2 != 0)
- **Order doesn't matter** (min/max handles it)
- **Result fits in integer**
- **Empty range** when min+1 >= max gives sum = 0
