// Que son las funciones, como se declaran y como se utilizan
const nom="Gorka"

// saludar("Miguel")
saludar(nom)

function saludar(nombre){
    console.log(`Hola ${nombre}`)
}

/////

let nombre_2="Juan"
console.log(nombre_2)

despedir(nombre_2)
console.log(nombre_2)

function despedir(nombre){
    nombre="Diego"
    console.log(`Adios ${nombre}`)
}

////
let persona ={ nombre:"Juan",apellido:"Gonzales"}
console.log(persona)

saludarPersona(persona)

console.log(persona)

function saludarPersona(objeto){
    objeto.apellido="Villar"
    console.log(`Hola ${objeto.nombre} ${objeto.apellido}`)
}
// saludarPersona() //No se puede ascerder a un valor dentro de la funcion
saludar()

///////

function imprimeNumero(numero=7){///Valor predeterminado 7
    console.log(numero)

}
imprimeNumero()

////////////

function imprimir(...parametro){
    console.log(parametro)
}
imprimir(1,3,9,2,"hola",{id:9})

////
function suma(...nums){
    return nums.reduce((a,b)=>a+b)
}

const s= suma(1,2,3,4,9,15,16)

console.log(s)

//////
let variable="hola"

function multiplicar(a=0,b=0){
    console.log(variable)
    let variable_interna="adios"//No podemos usar esta variable de fuera de la funcion
    console.log(variable_interna)
    return a*b
}

console.log(multiplicar(4,9))