# Beecrowd Challenge 1042 - Simple Sort

## 📋 Problem Description
- **Problem ID:** 1042
- **Title:** Simple Sort  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1042)

### Problem Statement
Read three integers, sort them in ascending order, and print them. Then print a blank line, followed by the original values in the order they were read.

## 💡 Solution Approach

### Strategy
1. Read three integers
2. Store original values in a list
3. Create sorted copy using `sorted()`
4. Print sorted values (each on new line)
5. Print blank line
6. Print original values (each on new line)

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `map(int, input().split())` | Reads and converts three integers |
| `original = [a, b, c]` | Stores values in read order |
| `sorted(original)` | Creates new sorted list (ascending) |
| `for num in sorted_nums` | Prints sorted values line by line |
| `print()` | Blank line between outputs |
| `for num in original` | Prints original values line by line |

## ⚠️ Important Notes
- **Single line input** with three integers
- **Two sets of output:** sorted then original
- **Blank line** between the two sets
- **Each number on its own line**
- **`sorted()`** returns a new list (original unchanged)
