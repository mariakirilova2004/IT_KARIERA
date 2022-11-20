log2 n = 
    if n == 1
    then 0
    else 1 + log2 (div n 2)

main = do
    line <- getLine
    let n = read line :: Int
    putStrLn(show(log2 n))