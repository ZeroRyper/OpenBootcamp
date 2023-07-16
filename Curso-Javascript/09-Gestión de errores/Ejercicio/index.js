const winston = require("winston");

const logger = winston.createLogger({
  level: "error",
  format: winston.format.json(),
  defaultMeta: { service: "user-service" },
  transports: [
    new winston.transports.File({ filename: "error.log", level: "error" }),
  ],
});


funcion_personal=x=>{
    if(x==1){
        console.log("x es igual a 1")
        return
    }
    throw new Error("x debe ser igual a 1")
}
const x=Math.floor(Math.random()*2)
try{
    // Codigo que puede fallar 
    funcion_personal(x)
    console.log("Esta ejecutandose de manera correcta")
    
}
catch(e){
    // En caso de fallar. quiero que ejecutes
    logger.error("ERROR!")
}


