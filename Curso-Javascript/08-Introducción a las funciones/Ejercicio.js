///- Una función sin parámetros que devuelva siempre "true"
const array2=((x)=>x)
console.log(array2(true))
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