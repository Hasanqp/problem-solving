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
1. Use two separate loops to read each valid score
2. For each input, check if it's in range [0, 10]
3. If invalid, print "nota invalida" and continue reading
4. If valid, store the score and break the loop
5. After collecting two valid scores, calculate average
6. Print average with 2 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `double.Parse(Console.ReadLine())` | Read score as double |
| `while (true)` | Loop until valid score is entered |
| `input >= 0 && input <= 10` | Check if score is valid |
| `Console.WriteLine("nota invalida")` | Print error message |
| `break` | Exit loop after valid score |
| `(nota1 + nota2) / 2` | Calculate average |
| `$"{media:F2}"` | Format with 2 decimal places |

## ⚠️ Important Notes
- **Range:** 0 to 10 (inclusive)
- **Invalid scores:** less than 0 or greater than 10
- **Two separate loops** for each valid score
- **Portuguese message:** "nota invalida" (lowercase)
- **Format:** `media = {value}` with 2 decimal places

## 🚀 How to Run
```bash
dotnet run