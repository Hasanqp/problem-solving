# Beecrowd Challenge 1037 - Interval

## 📋 Problem Description
- **Problem ID:** 1037
- **Title:** Interval  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1037)

### Problem Statement
Read a floating-point number and determine which interval it belongs to:
- [0,25] (including 0 and 25)
- (25,50] (greater than 25 up to 50)
- (50,75] (greater than 50 up to 75)
- (75,100] (greater than 75 up to 100)
If the number is outside these ranges, print "Fora de intervalo".

## 💡 Solution Approach

### Strategy
1. Read a double value
2. Check each interval in order using if-else conditions
3. Print appropriate Portuguese message based on interval

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `double.Parse(Console.ReadLine())` | Reads floating-point number |
| `n >= 0 && n <= 25` | Checks first interval [0,25] |
| `n > 25 && n <= 50` | Checks second interval (25,50] |
| `n > 50 && n <= 75` | Checks third interval (50,75] |
| `n > 75 && n <= 100` | Checks fourth interval (75,100] |
| `else` | Handles values outside all intervals |

## 📐 Interval Notation

| Interval | Notation | Meaning |
|----------|----------|---------|
| [0,25] | Square brackets | Includes 0 and 25 |
| (25,50] | Mixed | Excludes 25, includes 50 |
| (50,75] | Mixed | Excludes 50, includes 75 |
| (75,100] | Mixed | Excludes 75, includes 100 |

## ⚠️ Important Notes
- **Single double input**
- **Portuguese output:**
  - "Intervalo [0,25]"
  - "Intervalo (25,50]"
  - "Intervalo (50,75]"
  - "Intervalo (75,100]"
  - "Fora de intervalo"
- **Boundary conditions matter:**
  - 25 belongs to first interval
  - 25.00001 belongs to second
- **If-else chain** ensures only one condition matches
