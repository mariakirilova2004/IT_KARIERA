makeRow n index str = 
    if index > n
    then str
    else makeRow n (index+1) (str++"*")

printRow n = makeRow n 1 ""

makeTriangle n index str= 
    if n < index
    then str
    else makeTriangle n (index+1) (printRow index ++ "\n" ++ str)

printTriangle n = makeTriangle n 1 ""

main = do
    num <- getLine
    let val = read num::Int
    putStr(printTriangle val)
