# Beecrowd Challenge 1047 - Game Time with Minutes

## 📋 Problem Description
- **Problem ID:** 1047
- **Title:** Game Time with Minutes  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1047)

### Problem Statement
Read the start time and end time of a game (in hours and minutes) and calculate the duration. The game can start on one day and end on the next day. Maximum duration is 24 hours, minimum is 1 minute.

## 💡 Solution Approach

### Strategy
1. Read four integers: start hour, start minute, end hour, end minute
2. Convert both times to total minutes since midnight
3. If end time ≤ start time, add 24 hours (1440 minutes) to end time
4. Calculate duration in minutes
5. Convert back to hours and minutes
6. Print in Portuguese format

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `map(int, input().split())` | Reads and converts four integers |
| `start_h * 60 + start_m` | Converts start time to minutes |
| `end_h * 60 + end_m` | Converts end time to minutes |
| `if end_total <= start_total` | Checks if game spans midnight |
| `end_total += 24 * 60` | Adds 24 hours (1440 minutes) if needed |
| `duration // 60` | Calculates hours (integer division) |
| `duration % 60` | Calculates remaining minutes |
