﻿# Write your MySQL query statement below
SELECT
  Score,
  @rank := @rank + (@prev <> (@prev := Score)) Rank
FROM
  Scores ,
  (SELECT @rank := 0, @prev := -1) ff
ORDER BY Score desc
