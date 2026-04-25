# Beecrowd Challenge 1115 - Quadrant

## 📋 Problem Description
- **Problem ID:** 1115
- **Title:** Quadrant
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1115)

### Problem Statement
Read coordinates (X, Y) of multiple points. For each point, determine which quadrant it belongs to. The program stops when either X or Y is zero (NULL). Points on axes are ignored.

## 💡 Solution Approach

### Strategy
1. Read coordinates in an infinite loop
2. If X == 0 or Y == 0, break (no output for this point)
3. Determine quadrant based on signs:
   - X > 0, Y > 0 → primeiro (Q1)
   - X < 0, Y > 0 → segundo (Q2)
   - X < 0, Y < 0 → terceiro (Q3)
   - X > 0, Y < 0 → quarto (Q4)
4. Print quadrant name in Portuguese

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `while True:` | Infinite loop until break |
| `map(int, input().split())` | Read and convert X and Y |
| `if X == 0 or Y == 0:` | Stop condition (on axis) |
| `break` | Exit the loop |
| `if X > 0 and Y > 0:` | Check Q1 |
| `elif X < 0 and Y > 0:` | Check Q2 |
| `elif X < 0 and Y < 0:` | Check Q3 |
| `else:` | Must be Q4 (X > 0, Y < 0) |
| `print(...)` | Print quadrant name |


## 🚀 How to Run
```bash
python solution.py