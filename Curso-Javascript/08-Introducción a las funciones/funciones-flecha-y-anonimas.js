// Funciones tipo flecha - funciones anonimas

const array=[1,5,6,2,7,12,8,92]

const array2=array.map((valor)=>valor*2)

console.log(array2)

//const dobleDelValor=valor=>{
//    return valor*2
//}
const dobleDelValor=valor=>valor*2

console.log(double(6))// Cuando utilizamos una funcion normal pude ser llamada o utilizada de cualquier parte del codigo
console.log(dobleDelValor(6))//Cuando utilizamos la funciones de tipo flecha deben ser declaradas antes de ser utilizadas

const array3=array.map(dobleDelValor)

console.log(array3)

function double(valor){
    return valor*2
}