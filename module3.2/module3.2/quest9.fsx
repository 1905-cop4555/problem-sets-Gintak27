 let twice f = f << f
 let successor n = n+1;;


 twice twice twice (twice successor) 0;;