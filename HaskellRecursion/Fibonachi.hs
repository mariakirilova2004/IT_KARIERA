findFibonacci n initialValue prevValue index =
    if n == index
    then  initialValue
    else findFibonacci n (initialValue+prevValue) initialValue (index+1)

fibonacci n = findFibonacci n 1 0 1

main = do
    num <- getLine
    let val = read num::Int
    putStrLn(show(fibonacci val))