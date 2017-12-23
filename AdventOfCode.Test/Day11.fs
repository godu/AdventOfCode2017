namespace AdventOfCode.Test

open Microsoft.VisualStudio.TestTools.UnitTesting;
open AdventOfCode;

[<TestClass>]
type Day11 () =
    [<DataTestMethod>]
    [<DataRow("FOO", "FOO")>]
    member this.Day11 (input: string, expect: string) =
        Assert.AreEqual(Day11.answer input, expect);
