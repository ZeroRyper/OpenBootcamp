const obj={
    nombre:"Erick",
    apellido:"Padilla",
    edad:23,
    altura:1.75,
    eresDesarrollador:"Si"
}
const mEdad=obj.edad

const info=[
    {nombre:"Erick",
    apellido:"Padilla",
    edad:23,
    altura:1.73,
    eresDesarrollador:"Si"},
    {nombre:"Santy",
    apellido:"Cruz",
    edad:22,
    altura:1.75,
    eresDesarrollador:"No"},
    {nombre:"Jairo",
    apellido:"Marquez",
    edad:21,
    altura:1.65,
    eresDesarrollador:"No"}
    
]
const orden=info.sort((a,b)=>b.edad-a.edad)
