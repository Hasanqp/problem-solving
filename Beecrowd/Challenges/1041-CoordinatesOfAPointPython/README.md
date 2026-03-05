# Beecrowd Challenge 1041 - Coordinates of a Point

## 📋 Problem Description
- **Problem ID:** 1041
- **Title:** Coordinates of a Point  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1041)

### Problem Statement
Read two floating-point coordinates (x, y) and determine:
- If point is at origin (0,0): "Origem"
- If point is on X-axis (y = 0): "Eixo X"
- If point is on Y-axis (x = 0): "Eixo Y"
- Otherwise, determine which quadrant: Q1, Q2, Q3, or Q4

## 💡 Solution Approach

### Strategy
1. Read x and y coordinates as floats
2. Check special cases first (origin, axes)
3. Then check quadrants based on signs
4. Print appropriate Portuguese message

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `map(float, input().split())` | Reads and converts two coordinates |
| `x == 0 and y == 0` | Checks if point is at origin |
| `x == 0` | Checks if point is on Y-axis |
| `y == 0` | Checks if point is on X-axis |
| Sign comparisons | Determines quadrant based on +/- |
