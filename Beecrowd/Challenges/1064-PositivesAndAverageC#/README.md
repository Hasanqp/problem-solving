# Beecrowd Challenge 1064 - Positives and Average

## 📋 Problem Description
- **Problem ID:** 1064
- **Title:** Positives and Average
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1064)

### Problem Statement
Read 6 numbers (integer or floating point). Print how many of them were positive and the average of all positive values, with one digit after the decimal point.

## 💡 Solution Approach

### Strategy
1. Initialize counter and sum to 0
2. Read 6 numbers in a loop
3. For each number, check if it's greater than 0
4. If positive, increment counter and add to sum
5. Calculate average = sum / count
6. Print count and average with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int count = 0` | Initialize positive counter |
| `double sum = 0` | Initialize sum of positives |
| `for (int i = 0; i < 6; i++)` | Loop 6 times |
| `CultureInfo.InvariantCulture` | Ensures correct decimal parsing |
| `if (number > 0)` | Check if number is positive |
| `count++` | Increment counter |
| `sum += number` | Add to sum |
| `sum / count` | Calculate average |
| `ToString("F1")` | Format to 1 decimal place |

## ⚠️ Important Notes
- **Six numbers** as input (one per line)
- **At least one number** will be positive
- **Positive numbers:** greater than 0
- **Use InvariantCulture** for decimal parsing
- **1 decimal place** for average
- **Portuguese format:** `{count} valores positivos`