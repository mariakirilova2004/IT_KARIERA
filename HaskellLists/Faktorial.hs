faktorial n = faktorialLoop n 1 1 []

faktorialLoop n i curr list = 
    if i <= n
        then faktorialLoop n (i + 1) (i * curr) (list ++ [curr])
        else list

main = do
    str <- getLine
    let n = read str :: Integer
    putStrLn(show(faktorial n))
