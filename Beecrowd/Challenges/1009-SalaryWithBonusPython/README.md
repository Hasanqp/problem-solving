# Beecrowd Challenge 1009 - Salary with Bonus

## 📋 Problem Description
- **Problem ID:** 1009
- **Title:** Salary with Bonus  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1009)

### Problem Statement
Calculate a seller's total salary based on their fixed salary and total sales. The seller receives 15% commission on all sales. Print the result with 2 decimal places in the exact format: `TOTAL = R$ {total}`

## 💡 Solution Approach

### Strategy
1. Read seller's name (though not used in calculation)
2. Read fixed salary and total sales
3. Calculate total: fixed salary + (sales × 15%)
4. Print result in exact required format

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Console.ReadLine()` | Reads seller's name |
| `double.Parse(Console.ReadLine())` | Reads salary and sales values |
| `sales * 0.15` | Calculates 15% commission |
| `ToString("F2")` | Formats output to 2 decimal places |

## ⚠️ Important Notes
- **Exact output format required:** `TOTAL = R$ {total}`
- **Include exactly one space** after "TOTAL = R$"
- **Two decimal places** mandatory
- **Line break** after output

## 🚀 How to Run
```bash
python solution.py