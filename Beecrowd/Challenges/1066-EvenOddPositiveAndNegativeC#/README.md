# Beecrowd Challenge 1066 - Even, Odd, Positive and Negative

## 📋 Problem Description
- **Problem ID:** 1066
- **Title:** Even, Odd, Positive and Negative
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1066)

### Problem Statement
Read five integer values and count how many are:
- Even
- Odd
- Positive
- Negative

Print all four counts with appropriate Portuguese messages.

## 💡 Solution Approach

### Strategy
1. Initialize four counters (even, odd, positive, negative)
2. Read 5 integers in a loop
3. For each number:
   - Check even/odd using modulo operator
   - Check positive/negative (zero counts as neither)
4. Print all four counts with Portuguese labels

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read each integer |
| `number % 2 == 0` | Check if number is even |
| `number % 2 != 0` | Check if number is odd |
| `number > 0` | Check if positive |
| `number < 0` | Check if negative |
| `else` | Zero (neither positive nor negative) |

## ⚠️ Important Notes
- **Five integers** as input (one per line)
- **Zero is even** but **neither positive nor negative**
- **Portuguese formats:**
  - `{even} valor(es) par(es)`
  - `{odd} valor(es) impar(es)`
  - `{positive} valor(es) positivo(s)`
  - `{negative} valor(es) negativo(s)`
- **All lowercase** in messages
