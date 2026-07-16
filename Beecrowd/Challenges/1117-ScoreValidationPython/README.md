# Beecrowd Challenge 1117 - Score Validation

## 📋 Problem Description
- **Problem ID:** 1117
- **Title:** Score Validation
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1117)

### Problem Statement
Read scores until two valid scores (between 0 and 10 inclusive) are entered. For each invalid score, print "nota invalida". After two valid scores, calculate and print the average with 2 decimal places.

## 💡 Solution Approach

### Strategy
1. Use a list to store valid scores
2. Continue reading scores until we have 2 valid scores
3. For each input, check if it's in range [0, 10]
4. If invalid, print "nota invalida"
5. If valid, add to the list
6. After collecting two valid scores, calculate average
7. Print average with 2 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `valid_scores = []` | List to store valid scores |
| `while len(valid_scores) < 2:` | Loop until we have 2 valid scores |
| `float(input())` | Read score as float |
| `if 0 <= score <= 10:` | Check if score is valid (Python chained comparison) |
| `valid_scores.append(score)` | Add valid score to list |
| `else:` | Invalid score case |
| `print("nota invalida")` | Print error message |
| `sum(valid_scores) / 2` | Calculate average of two scores |
| `{media:.2f}` | Format with 2 decimal places |

## ⚠️ Important Notes
- **Range:** 0 to 10 (inclusive)
- **Invalid scores:** less than 0 or greater than 10
- **Python chained comparison:** `0 <= score <= 10`
- **Portuguese message:** "nota invalida" (lowercase)
- **Format:** `media = {value}` with 2 decimal places
- **The `invalid_messages` list is unused** (can be removed)

## 🚀 How to Run
```bash
python solution.py