import Data.Char

minFromList list = foldl min (head list) list

toNumber list = map (digitToInt) list

main = do
    line <- getLine -- 6798154
    putStrLn(show(minFromList(toNumber line))) -- 1