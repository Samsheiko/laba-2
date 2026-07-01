open System

let romanToDecimal roman =
    match roman with
    | "I" -> 1
    | "II" -> 2
    | "III" -> 3
    | "IV" -> 4
    | "V" -> 5
    | "VI" -> 6
    | "VII" -> 7
    | "VIII" -> 8
    | "IX" -> 9
    | _ -> 0

[<EntryPoint>]
let main _ =
    printf "Сколько римских чисел вводим? "
    let n = int (Console.ReadLine())

    let romanList =
        [ for i in 1 .. n do
            printf "Введите римское число %d (I-IX): " i
            Console.ReadLine().Trim().ToUpper() ]

    let totalSum = List.fold (fun acc roman -> acc + romanToDecimal roman) 0 romanList

    printfn "Сумма в десятичной системе: %d" totalSum
    0
