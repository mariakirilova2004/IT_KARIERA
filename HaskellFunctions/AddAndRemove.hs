add1 n = n + 1
remove1 n = n - 1
compose f n = f n

main = do
    func <- getLine
    number <- getLine
    let value = read number :: Int
    if func == "add1"
    then putStrLn(show(compose add1 value))
    else putStrLn (show(compose remove1 value))
