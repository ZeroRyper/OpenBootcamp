class Estudiante{
    nombre="Erick"
    asignaturas=["Espanol","Matematicas","Etica"]
    obtenDatos(){
        return{
            nombre:this.nombre,
            asignaturas:this.asignaturas
        }
    }
}

const Alumno=new Estudiante()
console.log(Alumno.obtenDatos())