# Beecrowd Challenge 1061 - Event Time

## 📋 Problem Description
- **Problem ID:** 1061
- **Title:** Event Time
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1061)

### Problem Statement
Calculate the duration of an event that starts and ends within April. Given the start day/time and end day/time, compute the total duration in days, hours, minutes, and seconds.

## 💡 Solution Approach

### Strategy
1. Parse start day and time from input
2. Parse end day and time from input
3. Convert both to total seconds
4. Calculate difference (end - start)
5. Convert back to days, hours, minutes, seconds
6. Print each value with Portuguese labels

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Split(' ')` | Parses day input ("Dia xx") |
| `Split(':')` | Parses time input (hh:mm:ss) |
| `int.Parse()` | Converts strings to integers |
| `day * 86400` | Converts days to seconds |
| `hour * 3600` | Converts hours to seconds |
| `minute * 60` | Converts minutes to seconds |
| `duration / 86400` | Calculates days |
| `duration %= 86400` | Remaining seconds after days |
| `duration / 3600` | Calculates hours |
| `duration %= 3600` | Remaining seconds after hours |
| `duration / 60` | Calculates minutes |
| `duration % 60` | Remaining seconds |

## ⏱️ Time Conversions

| Unit | Seconds |
|------|---------|
| 1 day | 86,400 |
| 1 hour | 3,600 |
| 1 minute | 60 |

## ⚠️ Important Notes
- **4 lines of input**:
  1. "Dia dd" (start day)
  2. "hh : mm : ss" (start time)
  3. "Dia dd" (end day)
  4. "hh : mm : ss" (end time)
- **All within April** (day values 1-30)
- **Minimum duration**: 1 minute
- **Portuguese labels**: "dia(s)", "hora(s)", "minuto(s)", "segundo(s)"
- **Print 0** for any null value
