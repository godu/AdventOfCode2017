namespace AdventOfCode

module Day1 =
    open System
    
    let foo char1 char2 =
        if (char1 = char2)
        then (int (char1.ToString()))
        else 0

    let run (captcha:string): int =
        let first = captcha.ToCharArray()
        let second = Array.concat [ (Array.tail first); [| Array.head first |] ]
            
        Array.map2 foo first second
        |> Array.fold (+) 0