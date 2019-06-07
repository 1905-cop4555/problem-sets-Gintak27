

type 'a Coordinate = 
     |Touple of 'a * 'a
     |Throuple of 'a * 'a * 'a
     |Fourple of 'a * 'a * 'a * 'a;;

 Touple (2,4);;
 Throuple (2.25, 5.5, 7.98);;
 Fourple ("2", "3", "4", "5");;

 let rec c = function
        |Touple(n,r) -> n + r
            




   