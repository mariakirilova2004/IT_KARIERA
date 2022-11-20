sumof10 index = 
    if index > 10
    then 0
    else (index) + (sumof10 (index + 1))

main = do
    let sumNumbers = sumof10 1
    print(sumNumbers)