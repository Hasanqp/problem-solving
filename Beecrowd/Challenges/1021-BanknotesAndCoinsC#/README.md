# Beecrowd Challenge 1021 - Banknotes and Coins

## 📋 Problem Description
- **Problem ID:** 1021
- **Title:** Banknotes and Coins  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1021)

### Problem Statement
Read a monetary value and calculate the minimum number of banknotes and coins needed. Consider notes: 100, 50, 20, 10, 5, 2 and coins: 1, 0.50, 0.25, 0.10, 0.05, 0.01.

## 💡 Solution Approach

### Strategy
1. Read value as double and convert to cents (integer)
2. Handle floating-point precision by adding 0.001
3. Process banknotes in descending order (100 to 2)
4. Print "NOTAS:" header and banknote counts
5. Process coins in descending order (1 to 0.01)
6. Print "MOEDAS:" header and coin counts

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `double.Parse()` | Reads monetary value |
| `(int)(valorDouble * 100 + 0.001)` | Converts to cents, handles precision |
| `notas[]` and `moedas[]` | Arrays of denominations in cents |
| `valorTotal / nota` | Calculates note count |
| `valorTotal %= nota` | Updates remaining value |
| `(nota / 100.0):F2` | Converts back to reais format |

## 🔢 Key Concepts

**Why convert to cents?**
- Avoids floating-point precision errors
- Enables integer arithmetic
- More reliable calculations

**Denominations in cents:**
- 100 reais = 10000 cents
- 0.01 reais = 1 cent
- All denominations multiplied by 100

## ⚠️ Important Notes
- **Floating point input** with two decimals
- **Two sections:** "NOTAS:" and "MOEDAS:"
- **Add 0.001** to handle rounding errors
- **Portuguese format:** `nota(s)` and `moeda(s)`
- **Two decimal places** in output

 
## 🚀 How to Run
```bash
C# Solution.cs