# Beecrowd Challenge 1044 - Multiples

## 📋 Problem Description
- **Problem ID:** 1044
- **Title:** Multiples  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1044)

### Problem Statement
Read two integer values (A and B) and determine if they are multiples of each other. Print "Sao Multiplos" if they are multiples, otherwise print "Nao sao Multiplos".

## 💡 Solution Approach

### Strategy
1. Read two integers A and B
2. Check if A is divisible by B OR B is divisible by A
3. Print appropriate Portuguese message based on result

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `map(int, input().split())` | Reads and converts two integers |
| `A % B == 0` | Checks if A is divisible by B |
| `B % A == 0` | Checks if B is divisible by A |
| `or` | Logical OR operator |
| `print()` | Outputs Portuguese message |

## 📐 Mathematical Concept

Two numbers are multiples if one is divisible by the other:
- A is a multiple of B if A ÷ B has remainder 0
- B is a multiple of A if B ÷ A has remainder 0
