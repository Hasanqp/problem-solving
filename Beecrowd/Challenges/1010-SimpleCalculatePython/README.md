# Beecrowd Challenge 1010 - Simple Calculate

## 📋 Problem Description
- **Problem ID:** 1010
- **Title:** Simple Calculate  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1010)

### Problem Statement
Read product codes, units, and prices for two products, then calculate and display the total amount to pay.

## 💡 Solution Approach

### Strategy
1. Read first line: code1, units1, price1
2. Read second line: code2, units2, price2
3. Calculate total: (units1 × price1) + (units2 × price2)
4. Print result in exact format: `VALOR A PAGAR: R$ {total}`

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `input().split()` | Splits input line into list |
| `int()` | Converts to integer for codes and units |
| `float()` | Converts to float for prices |
| `units * price` | Calculates product total |
| `{total:.2f}` | Formats output to 2 decimal places |

## ⚠️ Important Notes
- **Exact output format:** `VALOR A PAGAR: R$ {total}`
- **Spaces required:** after ":" and after "R$"
- **Two decimal places** mandatory
- **Input format:** Two lines with 3 values each

## 🚀 How to Run
```bash
python solution.py