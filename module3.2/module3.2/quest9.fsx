 let twice f = f << f
 let succ n = n+1;;


 twice twice twice (twice succ) 0;;

 let thrice g = g << g << g

 thrice succ 0;;