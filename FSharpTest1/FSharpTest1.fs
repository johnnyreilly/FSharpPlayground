namespace UnitTestProject1

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type UnitTest() =
    [<TestMethod>]
    member x.TestMethod1 () =
        let testVal = 1
        Assert.AreEqual(1, testVal)

    [<TestMethod>]
    member x.``Test Is Prime``() =
        let expected = [2;3;5;7;11;13;17;19]
        let actual = [2..20] |> List.filter PrimesLib.isPrime
        Assert.AreEqual(expected, actual)