const fecha_hoy=new Date()

const nacimineto=new Date(2000,4,10)

const comparacion=fecha_hoy>nacimineto

const dia_nacimiento=nacimineto.getDate()

const fecha_nacimiento=nacimineto.getMonth()

const fecha_short=nacimineto.toLocaleDateString("es-US")
