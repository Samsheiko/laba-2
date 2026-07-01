open System

let trfs x = x % 2 = 0

[<EntryPoint>]
let main args =
    printf "Введите количество чисел:"
    let n = int (Console.ReadLine())

    let a =
        [ for i in 1 .. n do
            printf "Введите число %d: " i
            let num = int (Console.ReadLine())
            yield num ]

    let res = List.map trfs a
    printfn "Результат: %A" res
    0
