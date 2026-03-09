# Beecrowd Challenge 1050 - DDD

## 📋 Problem Description
- **Problem ID:** 1050
- **Title:** DDD  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1050)

### Problem Statement
Read an integer DDD (direct distance dialing) code and print the corresponding Brazilian city. If the code is not found in the table, print "DDD nao cadastrado".

## 💡 Solution Approach

### Strategy
1. Read integer DDD code
2. Use switch statement to match with known codes
3. Print corresponding city name
4. Print error message for unknown codes

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Reads integer DDD code |
| `switch (ddd)` | Matches input with known codes |
| `case 61:` | Checks for Brasília code |
| `Console.WriteLine()` | Prints city name or error message |
| `default:` | Handles unknown DDD codes |

## 📞 DDD Codes Table

| DDD Code | City |
|----------|------|
| 61 | Brasilia |
| 71 | Salvador |
| 11 | Sao Paulo |
| 21 | Rio de Janeiro |
| 32 | Juiz de Fora |
| 19 | Campinas |
| 27 | Vitoria |
| 31 | Belo Horizonte |

## ⚠️ Important Notes
- **Single integer input**
- **Case-sensitive** cities printed exactly as shown
- **Portuguese output:** "DDD nao cadastrado" for unknown codes
- **No spaces** in city names (e.g., "Sao Paulo" not "São Paulo")
