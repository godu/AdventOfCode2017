namespace AdventOfCode

module Day2 =
    let split (separator: string) (s: string): string array = s.Split(separator)
    let parseInt: string -> int = (int)

    let answer (puzzle: string): int =
        puzzle
        |> (split "\n" >> Array.map (split "\t" >> Array.map parseInt))
        |> Array.sumBy ((fun v -> (Array.min v, Array.max v)) >> (fun (min, max) -> max - min))