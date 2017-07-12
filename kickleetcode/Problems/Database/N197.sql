SELECT w1.Id from weather w1, weather w2
where w2.Date = DATE_ADD(w1.Date,INTERVAL -1 DAY)
and w1.Temperature > w2.Temperature
