showPlus s x =
    if null s
        then show x
        else "(" ++ s ++ "+" ++ (show x) ++ ")"

generateMathExpression list = foldl showPlus "" list

main = do
    let input = [1, 2, 3, 4]
    putStrLn(show (generateMathExpression input))