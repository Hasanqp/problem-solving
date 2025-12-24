# Beecrowd Challenge 1017 - Fuel Spent

## 📋 Problem Description
- **Problem ID:** 1017
- **Title:** Fuel Spent  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1017)

### Problem Statement
Calculate the amount of fuel (in liters) needed for a trip given time spent and average speed. The car consumes 12 km per liter.

## 💡 Solution Approach

### Strategy
1. Read time spent (hours) and average speed (km/h)
2. Calculate distance: time × speed
3. Calculate fuel needed: distance ÷ 12
4. Print result with 3 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Reads integer time and speed |
| `(time * average) / 12` | Calculates fuel needed |
| `{spentfuel:.3f}` | Formats output to 3 decimal places |

## 📐 Calculation Steps

1. **Distance = Time × Average Speed**
2. **Fuel = Distance ÷ Fuel Efficiency (12 km/L)**
3. **Combined formula:** Fuel = (Time × Speed) ÷ 12

## ⚠️ Important Notes
- **Two-line input:** time on first line, speed on second
- **3 decimal places** mandatory
- **Automatic float division** in Python
- **Simple arithmetic** - no complex formulas


## 🚀 How to Run
```bash
python solution.py