# Beecrowd Challenge 1013 - The Greatest

## 📋 Problem Description
- **Problem ID:** 1013
- **Title:** The Greatest  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1013)

### Problem Statement
Read three integer values and find the greatest one using the formula:  
**maior = (a + b + |a - b|) / 2**  
Print the greatest value followed by "eh o maior" (is the greatest in Portuguese).

## 💡 Solution Approach

### Strategy
1. Read three integer values from a single line
2. Use the formula to find greatest between a and b
3. Use the same formula to compare result with c
4. Print the greatest value with required message

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Console.ReadLine().Split()` | Splits input into three values |
| `int.Parse()` | Converts string values to integer |
| `(a + b + Math.Abs(a - b)) / 2` | Formula to find greatest between two numbers |
| `Math.Abs()` | Returns absolute value |

## 📐 Mathematical Formula

The formula `(a + b + |a - b|) / 2` always returns the greater of two numbers:
- If a ≥ b: result = (a + b + (a - b)) / 2 = (2a) / 2 = a
- If a < b: result = (a + b + (b - a)) / 2 = (2b) / 2 = b

## ⚠️ Important Notes
- **Single line input:** all three values on one line
- **Use Math.Abs()** for absolute value
- **Integer division** is safe here
- **Exact format:** `{value} eh o maior`


## 🚀 How to Run
```bash
C# Solution.cs