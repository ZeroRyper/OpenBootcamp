//Casos muy especificos - break, continue
let lista =[1,2,3,4,5,6,7,8];

for (var i=0;i<lista.length;i++){
    
    if(lista[i]===3){
        continue;
    }
    var j=5;
    console.log(lista[i]);
    if(lista[i]>5){
        break;
    }
   
}