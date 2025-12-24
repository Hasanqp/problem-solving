# Beecrowd Challenge 1016 - Distance

## 📋 Problem Description
- **Problem ID:** 1016
- **Title:** Distance  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1016)

### Problem Statement
Given a distance (in km) between two cars (X at 60 km/h and Y at 90 km/h), calculate how many minutes car Y needs to cover that distance relative to car X.

## 💡 Solution Approach

### Strategy
1. Read the distance as integer
2. Calculate time: distance × 2 minutes
3. Print result with "minutos" message

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Reads integer distance |
| `distance * 2` | Since Y gains 1 km every 2 minutes |
| `print(f"{time} minutos")` | Outputs result |

## 📐 Logic Explanation

- Car X speed: 60 km/h
- Car Y speed: 90 km/h  
- Relative speed: 90 - 60 = 30 km/h
- Time to cover 30 km: 1 hour = 60 minutes
- Therefore: **1 km = 2 minutes**

**Formula:** Time (minutes) = Distance × 2

## ⚠️ Important Notes
- **Single integer input**
- **Simple multiplication:** distance × 2
- **Exact format:** `{time} minutos`
- **No decimal places needed** - result is always integer


## 🚀 How to Run
```bash
python solution.py