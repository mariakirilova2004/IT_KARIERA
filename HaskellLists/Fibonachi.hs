fibonachi n = fibonachiLoop n 1 1 1 []

fibonachiLoop n prev curr i list = 
    if i <= n
        then fibonachiLoop n curr (prev + curr) (i + 1) (list ++ [prev])
        else list

main = do
    str <- getLine
    let n = read str :: Integer
    putStrLn(show(fibonachi n)) 