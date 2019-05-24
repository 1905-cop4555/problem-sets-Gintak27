type Person = {Name:string; Age: int};;

let p = {Age = 15; Name = "John"};;

p.Name;;
p.Age =23;;// this returns boolean

let p = {Age = 23};;// this is not valid 

let p = {Age = 23; Name = "Cat"};; // this works