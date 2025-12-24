# Beecrowd Challenge 1015 - Distance Between Two Points

## 📋 Problem Description
- **Problem ID:** 1015
- **Title:** Distance Between Two Points  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1015)

### Problem Statement
Calculate the Euclidean distance between two points in a plane using the formula:  
**Distance = √[(x₂ - x₁)² + (y₂ - y₁)²]**

## 💡 Solution Approach

### Strategy
1. Read coordinates of first point (x1, y1)
2. Read coordinates of second point (x2, y2)
3. Apply Euclidean distance formula
4. Print result with 4 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `input().split()` | Splits input line into coordinates |
| `float()` | Converts string to float |
| `(x2 - x1)**2` | Calculates squared difference |
| `math.sqrt()` | Calculates square root |
| `{Distance:.4f}` | Formats output to 4 decimal places |

## 📐 Mathematical Formula

**Euclidean Distance:**

## 🚀 How to Run
```bash
python solution.py