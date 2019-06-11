 let twoToThe nth =
  let rec twoToTheAux acc nth = if nth = 0I then acc
                                else let result = acc * 2I
                                     twoToTheAux result (nth - 1I)
  twoToTheAux 1I ;;