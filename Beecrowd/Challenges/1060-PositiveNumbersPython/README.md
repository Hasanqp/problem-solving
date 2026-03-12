# Beecrowd Challenge 1060 - Positive Numbers

## 📋 Problem Description
- **Problem ID:** 1060
- **Title:** Positive Numbers  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1060)

### Problem Statement
Read 6 numbers (positive or negative, no zeros) and count how many of them are positive. Print the total count.

## 💡 Solution Approach

### Strategy
1. Initialize counter to 0
2. Read 6 numbers in a loop
3. For each number, check if it's greater than 0
4. Increment counter if positive
5. Print final count with message

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `count = 0` | Initialize counter |
| `for i in range(6):` | Loop 6 times |
| `float(input())` | Read each number as float |
| `if number > 0:` | Check if number is positive |
| `count += 1` | Increment counter |
| `print(f"{count} valores positivos")` | Print result in Portuguese |

## ⚠️ Important Notes
- **Six numbers** as input (one per line)
- **Positive numbers:** greater than 0
- **Negative numbers:** less than 0
- **No zeros** in input (as per problem statement)
- **Portuguese format:** `{count} valores positivos`