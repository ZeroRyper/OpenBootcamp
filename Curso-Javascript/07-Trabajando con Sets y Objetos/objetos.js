//Trabajando con Objetos
const obj={
    id:4,
    nombre:"Juan",
    apellido:"Gonzalez",
    isDeveloper:false,
    libros_favoritos:["El metodo","El codigo de la manifestacion"],
    "4-juegos":[1,2,3,4]
}
console.log(obj.id)
console.log(obj["4-juegos"])

const prop="isDeveloper"
console.log(obj[prop])

///Se modifica tambien el valor origina del objeto copiado
const obj2=obj
console.log(obj2)

obj2.nombre="Erick"
console.log(obj2.nombre)
console.log(obj.nombre)

let val1=4
let val2=val1

val2=6
console.log(val1)
console.log(val2)

///Forma de poder modificar la copia de un objeto 
const obj3={ ...obj}
console.log(obj.nombre)
console.log(obj3.nombre)

obj3.nombre="Padilla"

console.log(obj.nombre)
console.log(obj3.nombre)

///////
// Como ordenar listas de objetos en funcion de una propiedad 

const listaPeliculas=[
    {titulo:"Lo que el viento",anyo:1939},
    {titulo:"Titanic",anyo:1997},
    {titulo:"Moana",anyo:2016},
    {titulo:"TED",anyo:2012},
]

console.log(listaPeliculas)
// .sort()-> MUT EL VALOR DE LA LISTA ORIGINAL  

//Ordenar el anyo de menor a mayo 
listaPeliculas.sort((a,b)=>a.anyo-b.anyo)
console.log(listaPeliculas)




