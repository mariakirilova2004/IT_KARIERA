findFibonacci n initialValue prevValue prevprevValue index =
    if n == index
    then  initialValue
    else findFibonacci n (initialValue + prevValue + prevprevValue) initialValue prevValue  (index+1)

fibonacci n = findFibonacci n 0 0 1 1

main = do
    num <- getLine
    let val = read num::Int
    putStrLn(show(fibonacci val))