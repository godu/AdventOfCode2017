namespace AdventOfCode.Test

open Microsoft.VisualStudio.TestTools.UnitTesting;
open AdventOfCode;

[<TestClass>]
type Day12 () =
    [<DataTestMethod>]
    [<DataRow("FOO", "FOO")>]
    member this.Day12 (input: string, expect: string) =
        Assert.AreEqual(Day12.answer input, expect);
