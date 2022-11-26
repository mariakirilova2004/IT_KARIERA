import Data.Char

sumList list = foldr (+) 0 list

toNumber list = map (digitToInt) list

main = do
    line <- getLine
    let average = div (sumList (toNumber line)) (length line)
    putStrLn (show(average))