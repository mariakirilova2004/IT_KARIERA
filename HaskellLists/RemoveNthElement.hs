removeNthElements list n = removeNthElement list n 1

removeNthElement list n i = 
    if null list
        then []
        else
            if (mod i n) /= 0
                then (head list) : removeNthElement (tail list) n (i + 1)
                else removeNthElement (tail list) n (i + 1)

main = do
    let input = [1, 2, 3, 4, 5, 6, 7, 8, 9]
    n <- getLine
    let number = read n :: Int
    putStrLn(show(removeNthElements input number))