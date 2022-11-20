repeatStringLoop string result n =
    if n == 0
    then result
    else repeatStringLoop string (result ++ string) (n - 1)

repeatString string n = 
    repeatStringLoop string " " n

main = do
    print(repeatString "pate" 5)