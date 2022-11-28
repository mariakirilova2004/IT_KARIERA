import Data.Char
countingUpper x =
 length (filter (isUpper) x)
countingLower x =
 length (filter (isLower) x)
countingAll x =
 length x


main = do
    str <- getLine
    let u = countingUpper str
    let l = countingLower str
    let a = (countingAll str) - (u + l) 
    putStrLn(show(l) ++ " "++ show(u) ++ " " ++ show(a))