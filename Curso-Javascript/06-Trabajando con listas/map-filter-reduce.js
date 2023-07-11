// Trabajar con metodos mas avanzados
// .map() .filtrer() .reduce()

const array=["San Sebastian","Madrid","Barcelona","Alicante","Bilbao"]

const val=array.forEach(v=>{
    console.log(v)
    return 4
})
console.log(val)

const newArray=array.map((valor,indice)=> `${indice+1}-${valor}`)
console.log(newArray)

const listaObjetos=[
    {nombre:"Leire",edad:35},
    {nombre:"Gorka",edad:34},
    {nombre:"Miguel",edad:28},
    {nombre:"Lucia",edad:3},
    {nombre:"Amaia",edad:29},
]
// const personasMayores=listaObjetos.filter(obj=>{
//     if(obj.edad>30){
//         return true
//     }
//     else{
//         return false
//     }
// })

 const personasMayores=listaObjetos.filter(obj=>obj.edad>30)
 console.log(personasMayores)

 const nuevalista=listaObjetos.filter(obj=>obj.nombre!="Miguel")
 console.log(nuevalista)

 const valores=[3,56,23,5,90,100]

 const suma=valores.reduce((acumulado,cur,i,arrayOriginal)=>{
    console.log(acumulado)
    console.log(cur)
    console.log(i)
    console.log(arrayOriginal)
    return acumulado+cur
 })
 console.log(suma)

