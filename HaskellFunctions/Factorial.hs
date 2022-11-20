factorial n = 
    if n == 1
    then 1
    else n * (factorial (n - 1))

main = do
    num <- getLine
    let a = read num::Int
    putStrLn(show(factorial a))