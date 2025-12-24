# Beecrowd Challenge 1020 - Age in Days

## 📋 Problem Description
- **Problem ID:** 1020
- **Title:** Age in Days  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1020)

### Problem Statement
Convert a person's age in days to years, months, and days format.
**Assumptions:** 1 year = 365 days, 1 month = 30 days.

## 💡 Solution Approach

### Strategy
1. Read total days as integer
2. Calculate years: totalDays ÷ 365
3. Calculate remaining days: totalDays % 365
4. Calculate months: remainingDays ÷ 30
5. Calculate days: remainingDays % 30
6. Print each with Portuguese labels

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Convert.ToInt32()` | Reads total days |
| `totalDays / 365` | Calculates years |
| `totalDays % 365` | Gets remaining days after years |
| `remainingDays / 30` | Calculates months |
| `remainingDays % 30` | Gets remaining days |


## 🚀 How to Run
```bash
C# Solution.cs