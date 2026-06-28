
open System

// 1. Функция обработки 
let checkEven numbers =
    numbers |> List.map (fun x -> x % 2 = 0) //проверка тру или фолс

// 2. Ввод и вывод (интерфейс)
printf "Введите числа через пробел: "
let input = Console.ReadLine()

let result = 
    input.Split(' ')               // Разрезаем строку по пробелам

    |> Array.toList                // Превращаем в список
    |> List.map int                // Превращаем текст в числа
    |> checkEven                   // Вызываем нашу функцию

printfn "%A" result
