///- Una función sin parámetros que devuelva siempre "true"
function devuelveTrue() {
    return true
}




async function damePromesa() {
    return setTimeout(() => console.log("Hola soy una promesa"), 5000)
}

////- Una función generadora de índices pares automáticos
function* generaId(){
    let id=0;
    while(true){
        id+=2
        if(id===12){
            return id
        }
        yield id // Esperando hasta que se vuelva a llamar
    }
}
const gen=generaId();

console.log(gen.next().value)
console.log(gen.next().value)
console.log(gen.next().value)
console.log(gen.next().value)
console.log(gen.next().value)
console.log(gen.next().value)