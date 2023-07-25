const boton=document.querySelector("#btn")

// console.log(boton)

boton.addEventListener("click",()=>{
// alert("Se ha hecho click")
// confirm("Estas de acuerdo?") && console.log("Ok")
// confirm("Estas de acuerdo?")
//      console.log("Ok")
//      console.log("No!!")

const respuesta=confirm("Seguro?")
if(respuesta){
    console.log("Esta de acuerdo")
}else{
    console.log("No estas de acuerdo")
}
})

const botonInfo=document.querySelector("#info")
botonInfo.addEventListener("click",()=>{
    const nombre=prompt("Cual es tu nombre?")
    if(nombre){
        console.log("Tu nombre es "+nombre)
    }
    else{
        console.log("No has introducion nada")
    }
})

const lista=[{
    nombre:"Erick",
    edad:23
},{
    nombre:"Julen",
    edad:321
},{
    nombre:"Amala",
    edad:30
}
]

//console.log(lista)
console.log(lista)