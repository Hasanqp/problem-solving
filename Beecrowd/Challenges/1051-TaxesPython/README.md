# Beecrowd Challenge 1051 - Taxes

## 📋 Problem Description
- **Problem ID:** 1051
- **Title:** Taxes  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1051)

### Problem Statement
Calculate the income tax based on progressive tax brackets:
- Up to R$ 2000.00: **Isento** (tax-free)
- R$ 2000.01 to R$ 3000.00: **8%** on the amount above R$ 2000.00
- R$ 3000.01 to R$ 4500.00: **18%** on the amount above R$ 3000.00 (plus previous bracket)
- Above R$ 4500.00: **28%** on the amount above R$ 4500.00 (plus previous brackets)

## 💡 Solution Approach

### Strategy
1. Read salary as float
2. Check salary range using if-elif-else
3. Calculate tax progressively (only on amounts exceeding each bracket)
4. Print "Isento" for tax-free salaries
5. Print tax with 2 decimal places for taxable salaries

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `float(input())` | Reads salary value |
| `salary <= 2000.00` | Checks if salary is tax-free |
| `(salary - 2000.00) * 0.08` | Calculates 8% tax on amount above R$ 2000 |
| `1000 * 0.08` | Fixed tax for first bracket (R$ 1000 at 8%) |
| `1500 * 0.18` | Fixed tax for second bracket (R$ 1500 at 18%) |
| `(salary - 4500.00) * 0.28` | Calculates 28% tax on amount above R$ 4500 |
| `{tax:.2f}` | Formats tax to 2 decimal places |

## 📊 Tax Brackets

| Salary Range | Tax Rate | Calculation Method |
|--------------|----------|-------------------|
| Up to R$ 2000.00 | 0% | Isento |
| R$ 2000.01 - R$ 3000.00 | 8% | (salary - 2000) × 0.08 |
| R$ 3000.01 - R$ 4500.00 | 18% | 80 + (salary - 3000) × 0.18 |
| Above R$ 4500.00 | 28% | 80 + 270 + (salary - 4500) × 0.28 |

## ⚠️ Important Notes
- **Progressive taxation:** each bracket applies only to the portion within that range
- **Output format:** "R$ {tax:.2f}" with space after R$
- **Special case:** "Isento" for salaries ≤ R$ 2000.00
- **2 decimal places** mandatory
- **Use f-string** for clean formatting
