reverseList list = 
    if null list 
        then []
        else reverseList (tail list) ++ [head list]

main = do
    let list = [1, 2, 3, 4, 5]
    putStrLn(show (reverseList list))
    