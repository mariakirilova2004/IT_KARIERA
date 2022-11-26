duplicateList list =
    if null list || (list == [])
        then []
        else head list : head list : duplicateList (tail list)

main = do
    let input = []
    putStrLn(show(duplicateList input))