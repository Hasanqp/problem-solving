# Beecrowd Challenge 1095 - Sequence IJ 1

## 📋 Problem Description
- **Problem ID:** 1095
- **Title:** Sequence IJ 1
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1095)

### Problem Statement
Print a sequence following the pattern:
- I starts at 1, J starts at 60
- Each step: I increases by 3, J decreases by 5
- Continue while J >= 0

## 💡 Solution Approach

### Strategy
1. Initialize I = 1, J = 60
2. Use while loop until J becomes negative
3. Print current I and J values
4. Update: I += 3, J -= 5
5. Stop when J < 0

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int I = 1` | Starting I value |
| `int J = 60` | Starting J value |
| `while (J >= 0)` | Loop while J is non-negative |
| `Console.WriteLine($"I={I} J={J}")` | Print current sequence values |
| `I += 3` | Increment I by 3 |
| `J -= 5` | Decrement J by 5 |