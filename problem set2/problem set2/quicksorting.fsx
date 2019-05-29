

//create sort function rec
let rec split pivot = function
    | []    -> ([],[])
    | x::xs -> let (left,right) = split pivot xs
               if x < pivot then (x::left, right)
                            else (left, x::right);;
let rec qsort = function 
   |[] -> []
   |[x] -> [x]
   |x::xs -> let (left,right) = split x xs
             left @ x :: right;;

//create  
