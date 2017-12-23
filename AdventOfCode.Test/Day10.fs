namespace AdventOfCode.Test

open Microsoft.VisualStudio.TestTools.UnitTesting;
open AdventOfCode;

[<TestClass>]
type Day10 () =
    [<DataTestMethod>]
    [<DataRow("FOO", "FOO")>]
    member this.Day10 (input: string, expect: string) =
        Assert.AreEqual(Day10.answer input, expect);
