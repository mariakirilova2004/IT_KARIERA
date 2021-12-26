SELECT * FROM gringotts.wizzard_deposits;

SELECT deposit_group, SUM(deposit_amount) AS 'total_sum'
FROM gringotts.wizzard_deposits w
WHERE w.deposit_amount =
(
	SELECT deposit_amount
    FROM gringotts.wizzard_deposits sw
	WHERE sw.magic_wand_creator = 'Ollivander family' AND w.id = sw.id
)
GROUP BY deposit_group
ORDER BY deposit_group ASC;

SELECT deposit_group, SUM(deposit_amount) AS 'total_sum'
FROM gringotts.wizzard_deposits w
WHERE w.deposit_amount =
(
	SELECT deposit_amount
    FROM gringotts.wizzard_deposits sw
	WHERE sw.magic_wand_creator = 'Ollivander family' AND w.id = sw.id
)
GROUP BY deposit_group
HAVING 
(
	total_sum < 150000 
)
ORDER BY total_sum DESC;