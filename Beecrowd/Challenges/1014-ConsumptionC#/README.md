# Beecrowd Challenge 1014 - Consumption

## 📋 Problem Description
- **Problem ID:** 1014
- **Title:** Consumption  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1014)

### Problem Statement
Calculate a car's average fuel consumption (km/l) given total distance traveled and total fuel spent.

## 💡 Solution Approach

### Strategy
1. Read total distance (integer) and fuel spent (double)
2. Calculate average consumption: distance ÷ fuel
3. Print result with 3 decimal places and "km/l" unit

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Convert.ToInt32()` | Reads integer distance |
| `Convert.ToDouble()` | Reads double fuel amount |
| `X / Y` | Calculates consumption (km per liter) |
| `ToString("F3")` | Formats output to 3 decimal places |

## ⚠️ Important Notes
- **Two-line input:** distance on first line, fuel on second
- **3 decimal places** mandatory
- **Exact format:** `{average} km/l`
- **Automatic conversion:** integer ÷ double = double


## 🚀 How to Run
```bash
C# Solution.cs