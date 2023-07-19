class Estudiante{
constructor(nombre,asignaturas){
            this.nombre=nombre
            this.asignaturas=asignaturas
        }    
        obtenDatos(){
            console.log(`Hola, mi nombre es ${this.nombre}, mis asignaturas son ${this.asignaturas}.`)
        }
}
class GradoEst extends Estudiante{
    constructor(nombre,asignaturas,grado){
        super(nombre,asignaturas)
        this.grado=grado
    }
    obtenDatos(){// Override
        super.saludo()
        console.log(`Grado ${this.grado}`)
    }
}
const Alumno=new GradoEst("Gorka",["Espanol","Matematicas","Etica"],"2A")
console.log(Alumno)