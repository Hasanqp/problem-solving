# Beecrowd Challenge 1094 - Experiments

## 📋 Problem Description
- **Problem ID:** 1094
- **Title:** Experiments
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1094)

### Problem Statement
Maria conducted laboratory experiments using three types of animals: rabbits (C - Coelho), rats (R - Rato), and frogs (S - Sapo). Given N experiments with quantities and animal types, calculate:
- Total number of animals used
- Total count for each animal type
- Percentage of each type relative to total

## 💡 Solution Approach

### Strategy
1. Read N (number of experiments)
2. Initialize counters for total, coelhos, ratos, sapos
3. Loop through N experiments:
   - Read amount and type
   - Add to total and appropriate animal counter
4. Calculate percentages for each type
5. Print all results with proper formatting

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read number of experiments |
| `string[] values = Console.ReadLine().Split(' ')` | Split input into amount and type |
| `total += amount` | Add to total animals |
| `if (type == 'C')` | Check for rabbit type |
| `else if (type == 'R')` | Check for rat type |
| `else if (type == 'S')` | Check for frog type |
| `(double)coelhos / total * 100` | Calculate percentage (cast to double) |
| `:F2` | Format percentage with 2 decimal places |