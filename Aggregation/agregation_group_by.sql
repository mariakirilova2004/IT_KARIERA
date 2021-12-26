SELECT * FROM gringotts.wizzard_deposits;
SELECT deposit_group, MAX(magic_wand_size) AS 'longest_magic_wand'
FROM gringotts.wizzard_deposits
GROUP BY deposit_group
ORDER BY deposit_group ASC;

SELECT w.deposit_group
FROM gringotts.wizzard_deposits w
GROUP BY w.deposit_group
HAVING AVG(magic_wand_size) = 
(
	SELECT AVG(sw.magic_wand_size) AS 'avg_size'
    FROM gringotts.wizzard_deposits sw
    GROUP BY sw.deposit_group
    ORDER BY avg_size ASC LIMIT 1
);

SELECT deposit_group, SUM(deposit_amount) AS 'deposit_sum'
FROM gringotts.wizzard_deposits w
GROUP BY deposit_group
ORDER BY deposit_sum;