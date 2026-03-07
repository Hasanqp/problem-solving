# Beecrowd Challenge 1048 - Salary Increase

## 📋 Problem Description
- **Problem ID:** 1048
- **Title:** Salary Increase  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1048)

### Problem Statement
Read an employee's salary and calculate the new salary with a percentage increase based on the salary range:

| Salary Range | Increase Percentage |
|--------------|---------------------|
| 0 - 400.00 | 15% |
| 400.01 - 800.00 | 12% |
| 800.01 - 1200.00 | 10% |
| 1200.01 - 2000.00 | 7% |
| Above 2000.00 | 4% |

## 💡 Solution Approach

### Strategy
1. Read salary as double
2. Determine percentage based on salary range
3. Calculate increase amount: salary × percentage ÷ 100
4. Calculate new salary: salary + increase
5. Print all three values with 2 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `double.Parse(Console.ReadLine())` | Reads salary |
| `if-else if` chain | Determines percentage based on range |
| `salary * percentage / 100` | Calculates increase amount |
| `salary + increase` | Calculates new salary |
| `:F2` | Formats to 2 decimal places |

## 📊 Salary Increase Table

| Salary Range | Percentage | Increase Formula |
|--------------|------------|------------------|
| 0 - 400.00 | 15% | salary × 0.15 |
| 400.01 - 800.00 | 12% | salary × 0.12 |
| 800.01 - 1200.00 | 10% | salary × 0.10 |
| 1200.01 - 2000.00 | 7% | salary × 0.07 |
| > 2000.00 | 4% | salary × 0.04 |
