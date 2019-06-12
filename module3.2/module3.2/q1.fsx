type linkedlist  = 
     |Node of int
     |Pointer of int * linkedlist 
    

let rec tun link = function
        |Node -> []
 