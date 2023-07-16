const miFunction=val=>{
    if(typeof val==="number"){
        return 2*val
    }
    throw new Error("El valor debe ser de tipo numero")
}

// const elDoble=miFunction("ala")
const numero="8"

try{
    // Codigo que puede fallar 
    console.log("Esta ejecutandose de manera correcta")
    const doble=miFunction(numero)
}
catch(e){
    // En caso de fallar. quiero que ejecutes
    console.error(`El valor`)
    console.error("ERROR!")
}finally{
    console.log("Esto se va a ejecutar tanto si se produce algun error como si no existe ninguno")
}

//InternalError, SyntaxError, TypeError, RangeError y ReferenceError
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/ReferenceError