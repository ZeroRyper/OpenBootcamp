var resultado=[1]
var num=6
var valor=1
for(i=0;i<num-1;i++){
    resultado.push(valor)
    valor=resultado[i]+resultado[i+1]
}
console.log(resultado)

