# Beecrowd Challenge 1002 - Area of a Circle

## 📋 Problem Description
- **Problem ID:** 1002
- **Title:** Area of a Circle  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1002)

### Problem Statement
Calculate the area of a circle given its radius R. Use the formula:  
**A = π × R²** and print the result with 4 decimal places.

## 💡 Solution Approach

### Strategy
1. Read the radius value as input
2. Calculate the area using π = 3.14159
3. Print the result with 4 decimal places in format: `A={area}`

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `float(input())` | Reads radius and converts to float |
| `3.14159 * R * R` | Calculates area using πR² formula |
| `print(f"A={A:.4f}")` | Outputs result with 4 decimal places |

## 🚀 How to Run
```bash
python solution.py