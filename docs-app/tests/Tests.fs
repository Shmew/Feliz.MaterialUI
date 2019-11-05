module Tests

open Fable.Mocha
open App

let appTests = testList "App tests" [
  testCase "addition works" <| fun _ ->
    Expect.equal (1 + 2) 3 "Expected 1 + 2 to be 3"
]

let allTests = testList "All" [
  appTests
]

[<EntryPoint>]
let main (args: string[]) = Mocha.runTests allTests
