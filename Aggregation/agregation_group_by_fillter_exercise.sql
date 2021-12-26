SELECT * FROM gringotts.wizzard_deposits;

SELECT deposit_group, magic_wand_creator, MIN(deposit_charge) AS 'min_deposit_charge'
FROM wizzard_deposits w
group by  deposit_group, magic_wand_creator
ORDER BY magic_wand_creator, deposit_group;

SELECT
IF(age between 0 AND  10, '[0-10]', IF(age between 11 AND  20, '[11-20]', IF(age between 21 AND  30, '[21-30]', IF(age between 31 AND  40, '[31-40]', IF(age between 41 AND  50, '[41-50]', IF(age between 51 AND  60, '[51-60]', '[61+]')))))) AS age_group,
COUNT(*) AS wizard_count
FROM gringotts.wizzard_deposits
GROUP BY age_group
ORDER BY wizard_count ASC;

SELECT LEFT(first_name, 1) AS first_letter
FROM gringotts.wizzard_deposits
WHERE deposit_group = 'Troll Chest'
GROUP BY first_letter
ORDER BY first_letter;

SELECT deposit_group,
is_deposit_expired,
AVG(deposit_interest) AS average_interest
FROM gringotts.wizzard_deposits
WHERE deposit_start_date > '1985-1-1'
GROUP BY deposit_group, is_deposit_expired
ORDER BY deposit_group DESC, is_deposit_expired ASC;