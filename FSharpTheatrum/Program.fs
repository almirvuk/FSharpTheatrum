// Learn more about F# at http://fsharp.org

open System

type Person(name: string, birthDay: DateTime) = 

    member private this.Name = name
    member private this.BirthDay = birthDay
    member this.IntroduceMe() = "I am " + this.Name + ", and I am " + (DateTime.Now.Year - this.BirthDay.Year).ToString() + " years old." 

let hello() =

    printf "What is your name? "
    let name = Console.ReadLine()

    printf "The year I was born? "
    let year = Console.ReadLine()

    let person = new Person(name, new DateTime(Int32.Parse(year), 1, 1))
    person

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let person = hello();

    printfn "%s" (person.IntroduceMe())

    0 // return an integer exit code
