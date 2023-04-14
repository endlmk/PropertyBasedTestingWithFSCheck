#r "nuget:FsCheck"

open FsCheck

let revRevIsOrg (xs:list<int>) = List.rev(List.rev xs) = xs
Check.Quick revRevIsOrg

//wrong version
let revRevIsOrgWrong (xs:list<int>) = List.rev xs = xs
Check.Verbose revRevIsOrgWrong

let revRevIsOrigFloat (xs:list<float>) = List.rev(List.rev xs) = xs
Check.Quick revRevIsOrigFloat