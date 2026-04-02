# Beecrowd Challenge 1098 - Sequence IJ 4

## 📋 Problem Description
- **Problem ID:** 1098
- **Title:** Sequence IJ 4
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1098)

### Problem Statement
Print a sequence following the pattern:
- I goes from 0 to 2 in steps of 0.2
- For each I, J takes values: I+1, I+2, I+3
- Format with proper decimal handling (integers without decimal point)

## 💡 Solution Approach

### Strategy
1. Loop I from 0 to 2.0001 (to include 2.0) in steps of 0.2
2. Round I to 1 decimal place to avoid floating-point errors
3. Inner loop for J values 1, 2, 3
4. Calculate J = j + I
5. Print with integer format if value is whole number, otherwise with 1 decimal

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `for (double i = 0; i <= 2.0001; i += 0.2)` | Loop I from 0 to 2 in 0.2 increments |
| `Math.Round(i, 1)` | Round I to 1 decimal place |
| `for (int j = 1; j <= 3; j++)` | Inner loop for 3 J values |
| `Math.Round(j + I, 1)` | Calculate and round J to 1 decimal |
| `I % 1 == 0` | Check if I is a whole number |
| `(int)I` | Cast to int for whole numbers |

## 📊 Sequence Pattern

| I | J values |
|---|----------|
| 0 | 1, 2, 3 |
| 0.2 | 1.2, 2.2, 3.2 |
| 0.4 | 1.4, 2.4, 3.4 |
| 0.6 | 1.6, 2.6, 3.6 |
| 0.8 | 1.8, 2.8, 3.8 |
| 1 | 2, 3, 4 |
| 1.2 | 2.2, 3.2, 4.2 |
| 1.4 | 2.4, 3.4, 4.4 |
| 1.6 | 2.6, 3.6, 4.6 |
| 1.8 | 2.8, 3.8, 4.8 |
| 2 | 3, 4, 5 |

## ⚠️ Important Notes
- **No input** required
- **I values:** 0, 0.2, 0.4, ..., 2.0 (11 values)
- **J values:** 3 values per I (total 33 lines)
- **Whole numbers:** print without decimal (e.g., `I=0 J=1`)
- **Decimal numbers:** print with 1 decimal (e.g., `I=0.2 J=1.2`)
- **Use 2.0001** in loop to include 2.0