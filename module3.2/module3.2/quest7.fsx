type 'a Stream = Cons of 'a * (unit -> 'a Stream)

 let p n =
  (n % 2 = 0) && (n % 3 = 0) && (n % 21 = 0) && (n % 10 = 0)

 let rec filter p (Cons (x, xsf)) =
  if (p x) then Cons (x, fun () -> filter p (xsf()))
  else filter p (xsf())

 let rec nextCons n = Cons (n, fun () -> filter p (nextCons (n+1)))

 let rec findFirst n =
  if (n % 2 = 0) && (n % 3 = 0) && (n % 21 = 0) && (n % 10 = 0) then n
  else findFirst (n+1)
 let sequence = nextCons (findFirst 1)

 let rec take n (Cons (x, xsf)) =
  if n = 0 then []
  else x :: take (n-1) (xsf())

 let rec skip n (Cons (x,xsf)) =
  if n = 0 then Cons (x,xsf)
  else skip (n-1) (xsf())