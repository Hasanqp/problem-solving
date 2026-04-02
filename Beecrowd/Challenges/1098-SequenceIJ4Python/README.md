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
1. Initialize I = 0.0
2. Loop while I ≤ 2.0001 (to include 2.0)
3. For each I, loop j = 1, 2, 3
4. Calculate J = I + j
5. Round both values to 1 decimal place
6. Print as integer if whole number, otherwise with 1 decimal
7. Increment I by 0.2

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `I = 0.0` | Initialize I |
| `while I <= 2.0001:` | Loop from 0 to 2 in 0.2 steps |
| `for j in range(1, 4):` | Inner loop for 3 J values |
| `J = I + j` | Calculate J |
| `round(I, 1)` | Round I to 1 decimal place |
| `round(J, 1)` | Round J to 1 decimal place |
| `I_rounded % 1 == 0` | Check if value is whole number |
| `I += 0.2` | Increment I |

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
- **Use 2.0001** in loop condition to include 2.0 due to floating-point precision
- **Rounding both I and J** ensures consistent output