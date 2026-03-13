# Beecrowd Challenge 1064 - Positives and Average

## 📋 Problem Description
- **Problem ID:** 1064
- **Title:** Positives and Average
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1064)

### Problem Statement
Read 6 numbers (integer or floating point). Print how many of them were positive and the average of all positive values, with one digit after the decimal point.

## 💡 Solution Approach

### Strategy
1. Initialize counter and sum to 0
2. Read 6 numbers in a loop
3. For each number, check if it's greater than 0
4. If positive, increment counter and add to sum
5. Calculate average = sum / count
6. Print count and average with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `count = 0` | Initialize positive counter |
| `sum_pos = 0` | Initialize sum of positives |
| `for i in range(6):` | Loop 6 times |
| `float(input())` | Read each number as float |
| `if number > 0:` | Check if number is positive |
| `count += 1` | Increment counter |
| `sum_pos += number` | Add to sum |
| `sum_pos / count` | Calculate average |
| `{average:.1f}` | Format to 1 decimal place |

## ⚠️ Important Notes
- **Six numbers** as input (one per line)
- **At least one number** will be positive (guaranteed)
- **Positive numbers:** greater than 0
- **1 decimal place** for average
- **Portuguese format:** `{count} valores positivos`