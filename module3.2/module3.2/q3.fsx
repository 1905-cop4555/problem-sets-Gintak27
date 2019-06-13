type Terminal = A|B|MIDDLE|EOF

 let rec parseChar (str:string) lastChar =
  if lastChar >= (String.length str) then [EOF]
  else
   if str.[lastChar] = 'a' then A :: (parseChar str (lastChar + 1))
   else if str.[lastChar] = 'b' then B :: (parseChar str (lastChar + 1))
   else if str.[lastChar] = '|' then MIDDLE :: (parseChar str (lastChar + 1))
   else failwith (sprintf "Expecting an %A, %A, or %A, but got a(n) %c" A B MIDDLE (str.[lastChar]))
  
 let parseStr str = parseChar str 0

 let str = "abbabba|abbabba"