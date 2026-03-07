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
1. Read value as float and convert to cents (integer)
2. Handle floating-point precision by adding 0.001
3. Process banknotes in descending order (100 to 2)
4. Print "NOTAS:" header and banknote counts
5. Process coins in descending order (1 to 0.01)
6. Print "MOEDAS:" header and coin counts

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `float(input())` | Reads monetary value |
| `int(valor * 100 + 0.001)` | Converts to cents, handles precision |
| `notas = [10000, 5000, 2000, 1000, 500, 200]` | Banknote values in cents |
| `moedas = [100, 50, 25, 10, 5, 1]` | Coin values in cents |
| `cents // nota` | Calculates note count (integer division) |
| `cents %= nota` | Updates remaining value |
| `nota/100:.2f` | Converts back to reais with 2 decimals |

## 🔢 Key Concepts

**Why convert to cents?**
- Avoids floating-point precision errors
- Enables integer arithmetic
- More reliable calculations with currency

**Denominations in cents:**
- 100 reais = 10000 cents
- 0.01 reais = 1 cent
- All values multiplied by 100

**The +0.001 trick:**
- Handles rounding errors in float-to-int conversion
- Ensures correct results for edge cases

## ⚠️ Important Notes
- **Floating point input** with two decimals
- **Two sections:** "NOTAS:" and "MOEDAS:" headers
- **Add 0.001** to handle rounding errors
- **Portuguese format:** `nota(s)` and `moeda(s)`
- **Two decimal places** in output
- **Use `//`** for integer division


## 🚀 How to Run
```bash
python solution.py