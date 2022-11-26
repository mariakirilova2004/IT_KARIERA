getLength list br =
    if null list
        then br
        else getLength (tail list) (br + 1)

main = do
    let input = "Hello, world!"
    putStrLn (show(getLength input 0))