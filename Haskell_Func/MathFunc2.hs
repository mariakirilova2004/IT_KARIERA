showPlus x s =
    if null s
        then show x
        else "(" ++ (show x) ++ "+" ++ s ++ ")"

generateMathExpression list = foldr showPlus "" list

main = do
    let input = [1, 2, 3, 4, 5]
    putStrLn(show (generateMathExpression input))