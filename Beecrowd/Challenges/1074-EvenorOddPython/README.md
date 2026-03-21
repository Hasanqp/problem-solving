# Beecrowd Challenge 1074 - Even or Odd

## 📋 Problem Description
- **Problem ID:** 1074
- **Title:** Even or Odd
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1074)

### Problem Statement
Read N integer values and for each value print:
- "NULL" if the value is zero
- Otherwise, print if it's EVEN/ODD and POSITIVE/NEGATIVE

## 💡 Solution Approach

### Strategy
1. Read N (number of test cases)
2. Loop N times to read each X
3. If X == 0, print "NULL"
4. Otherwise:
   - Determine if EVEN or ODD using modulo operator
   - Determine if POSITIVE or NEGATIVE using comparison
   - Combine with a space and print in uppercase

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Read N and each X |
| `if X == 0:` | Check for zero case |
| `X % 2 == 0` | Check if even |
| `else` | Odd |
| `X > 0` | Check if positive |
| `else` | Negative |
| `print(result)` | Print final result |

## ⚠️ Important Notes
- **First input:** N (number of values)
- **Next N lines:** integer values X
- **Zero:** print "NULL" only
- **Uppercase letters** in output
- **One space** between words
- **Format:** `EVEN POSITIVE`, `EVEN NEGATIVE`, `ODD POSITIVE`, `ODD NEGATIVE`
