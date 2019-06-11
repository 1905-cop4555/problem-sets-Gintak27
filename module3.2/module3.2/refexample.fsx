let r = ref 17;;

let s = ref 18
s := 8

!s;;

s := !s + 1;;

!s;;

let factorial n =
    let ans = ref 1
    let cnt = ref 1
    while !cnt <= n do
      ans := !ans * !cnt;
      cnt := !cnt + 1
    !ans

factorial 5;;


type Account = {balance: unit -> int ; deposit: int -> unit}

let acc = 
       let bal = ref 200
       {balance = !deposit + balance ;
        deposit = ref }//dont get why deposit needs to be int -> unit 