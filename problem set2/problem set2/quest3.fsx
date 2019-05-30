type TERMINAL = IF|THEN|ELSE|BEGIN|END|PRINT|SEMICOLON|ID|EOF

 type ParseTree =
  | Leaf of TERMINAL
  | BranchIF of ParseTree * ParseTree * ParseTree * ParseTree * ParseTree * ParseTree
  | BranchBEGIN of ParseTree * ParseTree * ParseTree
  | BranchPRINT of ParseTree * ParseTree
  | BranchEND of ParseTree
  | BranchSEMICOLON of ParseTree * ParseTree * ParseTree
  | BranchID of ParseTree

 let useToken token = function
  | [] -> failwith "Missing Token. Early termination."
  | x::xs -> if x = token then xs, Leaf(x) else failwith (sprintf "Incorrect token; expecting %A not %A" token x)

 let E = function            
  | [] -> failwith "Missing Token. Early termination."
  | x::xs -> if x = ID then xs, BranchID(Leaf ID) else failwith (sprintf "Missing token; expecting %A not %A" ID x);;

