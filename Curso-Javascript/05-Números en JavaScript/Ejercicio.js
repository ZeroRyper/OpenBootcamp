// Una variable que contenga tu altura en centímetros (entero)
alturaint=178
console.log(parseInt (alturaint))
// Una variable que contenga tu altura en metros (número de coma flotante)
alturafloat=1.78
console.log(parseFloat (alturafloat))
// Una variable que contenga tu peso en kilogramos (número de coma flotante)
pesofloat=66.5
console.log(parseFloat (pesofloat))
// Una variable que contenga tu altura en metros redondeada hacia arriba
alturafloat=1.78
console.log(alturafloat.toFixed(1))
// Una variable que contenga tu peso en kilogramos redondeado hacia abajo
pesofloat=66.5
console.log( (Math.floor(pesofloat) ))
// Una variable que contenga si "el máximo valor que se puede obtener en Javascript + 1" es igual al máximo valor que se puede obtener en Javascript 
let max_valor_JS=Number.MAX_VALUE;
if(max_valor_JS==max_valor_JS+1){
    console.log("Es igual")
}
else{
    console.log("Es diferente")
}
