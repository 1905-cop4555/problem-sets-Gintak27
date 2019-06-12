type 'a Stream = Cons of 'a * (unit -> 'a Stream)

 let p n =
  (n % 2 = 0) && (n % 3 = 0) && (n % 21 = 0) && (n % 10 = 0)

 let rec filter p (Cons (x, xsf)) =
  if (p x) then Cons (x, fun () -> filter p (xsf()))
  else filter p (xsf())

 let rec nextCons n = Cons (n, fun () -> filter p (nextCons (n+1)))
