# Beecrowd Challenge 1046 - Game Time

## 📋 Problem Description
- **Problem ID:** 1046
- **Title:** Game Time  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1046)

### Problem Statement
Read the start time and end time of a game (in hours). Calculate the duration considering that the game can start on one day and end on the next, with maximum duration of 24 hours.

## 💡 Solution Approach

### Strategy
1. Read start time and finish time as integers
2. Calculate duration based on three cases:
   - Start < Finish: game ends same day
   - Start > Finish: game ends next day
   - Start = Finish: game lasts 24 hours
3. Print message in Portuguese with duration

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse()` | Converts string to integer |
| `startTime < finishTime` | Game ends same day |
| `finishTime - startTime` | Duration for same day |
| `startTime > finishTime` | Game ends next day |
| `(24 - startTime) + finishTime` | Duration crossing midnight |
| `startTime == finishTime` | Game lasts exactly 24 hours |
