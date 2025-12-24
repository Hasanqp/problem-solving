# Beecrowd Challenge 1019 - Time Conversion

## 📋 Problem Description
- **Problem ID:** 1019
- **Title:** Time Conversion  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1019)

### Problem Statement
Convert a duration in seconds to hours:minutes:seconds format.

## 💡 Solution Approach

### Strategy
1. Read total seconds as integer
2. Calculate hours: totalSeconds ÷ 3600
3. Calculate remaining seconds: totalSeconds % 3600
4. Calculate minutes: remainingSeconds ÷ 60
5. Calculate seconds: remainingSeconds % 60
6. Print in H:M:S format

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int(input())` | Reads total seconds |
| `totalSeconds // 3600` | Calculates hours (integer division) |
| `totalSeconds % 3600` | Gets remaining seconds after hours |
| `remainingSeconds // 60` | Calculates minutes |
| `remainingSeconds % 60` | Gets remaining seconds |
| `print(f"{hours}:{minutes}:{seconds}")` | Outputs in required format |


## 🚀 How to Run
```bash
python solution.py