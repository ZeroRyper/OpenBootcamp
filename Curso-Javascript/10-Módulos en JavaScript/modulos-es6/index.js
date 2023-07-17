//import { suma, eleva, nombre } from './modulos/matematicas.js'
import * as modulosMatematicas from './modulos/matematicas.js'
import getaAutor, { libro } from './modulos/literatura.js'//Importacion por defecto[getaAutor],Importacion por nomenclatura { libro }

const sum=modulosMatematicas.suma(4,12)
console.log(sum)

const potencia=modulosMatematicas.eleva(2,21)
console.log(potencia)

console.log(modulosMatematicas.eleva(2,21))

console.log(getaAutor())
console.log(libro)