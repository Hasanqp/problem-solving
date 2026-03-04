# Beecrowd Challenge 1038 - Snack

## 📋 Problem Description
- **Problem ID:** 1038
- **Title:** Snack  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1038)

### Problem Statement
Calculate the total price of a snack order based on the product code and quantity. The menu is:

| Code | Product | Price (R$) |
|------|---------|------------|
| 1 | Cachorro Quente | 4.00 |
| 2 | X-Salada | 4.50 |
| 3 | X-Bacon | 5.00 |
| 4 | Torrada simples | 2.00 |
| 5 | Refrigerante | 1.50 |

## 💡 Solution Approach

### Strategy
1. Read product code (X) and quantity (Y) from input
2. Use dictionary to map product codes to prices
3. Calculate total: price × quantity
4. Print result with 2 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `map(int, input().split())` | Reads and converts two integers |
| `prices = {1:4.00, 2:4.50, ...}` | Dictionary mapping codes to prices |
| `prices[X] * Y` | Calculates total amount |
| `{total:.2f}` | Formats output to 2 decimal places |

## 📋 Menu Table

| Code | Product | Price (R$) |
|------|---------|------------|
| 1 | Cachorro Quente | 4.00 |
| 2 | X-Salada | 4.50 |
| 3 | X-Bacon | 5.00 |
| 4 | Torrada simples | 2.00 |
| 5 | Refrigerante | 1.50 |

## ⚠️ Important Notes
- **Single line input:** code and quantity
- **Dictionary lookup** instead of if/else or switch
- **Only codes 1-5** are valid (assuming valid input)
- **2 decimal places** mandatory
- **Portuguese format:** `Total: R$ {value}`
