# Beecrowd Challenge 1065 - Even Between Five Numbers

## 📋 Problem Description
- **Problem ID:** 1065
- **Title:** Even Between Five Numbers
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1065)

### Problem Statement
Read five integer values and count how many of them are even. Print the result with the message "valores pares" (all lowercase).

## 💡 Solution Approach

### Strategy
1. Initialize counter to 0
2. Read 5 integers in a loop
3. For each number, check if it's even using modulo operator
4. Increment counter if even
5. Print final count with message

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `count = 0` | Initialize counter |
| `for i in range(5):` | Loop 5 times |
| `int(input())` | Read each integer |
| `number % 2 == 0` | Check if number is even |
| `count += 1` | Increment counter |
| `print(f"{count} valores pares")` | Print result in Portuguese |

## ⚠️ Important Notes
- **Five integers** as input (one per line)
- **Even numbers:** divisible by 2 (number % 2 == 0)
- **Zero is even** (0 % 2 == 0)
- **Portuguese format:** `{count} valores pares`
- **All lowercase** in message
- **Use `%` operator** for even check
