// Formas de importar/exportar modulos
// 1. CommonJS - require
// 2. Import ES6 - import
 
// const modulosMatematicas=require("./modulos/matematicas.js")
// const  factorial=modulosMatematicas.factorial;
// const { factorial,suma }=modulosMatematicas;
// const suma=modulosMatematicas.suma;
// console.log(modulosMatematicas.suma)

const { factorial }=require("./modulos/matematicas.js")

const fact=factorial(5)
console.log(fact)

// const sum=modulosMatematicas.suma(12,90)
// console.log(module)