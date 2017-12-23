namespace AdventOfCode.Test

open Microsoft.VisualStudio.TestTools.UnitTesting;
open AdventOfCode;

[<TestClass>]
type Day10 () =
    [<DataTestMethod>]
    [<DataRow(5, "3,4,1,5", 12)>]
    [<DataRow(256, "97,167,54,178,2,11,209,174,119,248,254,0,255,1,64,190", 8536)>]
    member this.Day10 (size: int, input: string, expect: int) =
        let rope = List.init size id
        Assert.AreEqual(Day10.answer rope input, expect);
