//Sesion 4- Strings (cadenas de caracteres)
let str_sng='Hola soy un texto con comillas simples';
let str_dbl="Hola soy un texto con comillas dobles";

console.log(str_sng);
console.log(str_dbl);

let str_comilla="El otro dia me dijo literalmente \"ve a sacar la basura\""
let str_comilla_simples='El otro dia me dijo literalmente \"ve a sacar la basura\"'
let str_comilla_dobles='El otro dia me dijo literalmente \"ve a sacar la basura\"'
let str_comilla_simples_2='El otro dia me dijo literalmente \"ve a sacar la basura\"'

console.log(str_comilla);
console.log(str_comilla_simples);
console.log(str_comilla_dobles);
console.log(str_comilla_simples_2);

//Comillas invertidas (backticks)
let str_backticks=`Hola esto es un string con backticks`

console.log(str_backticks)

let nombre="Inigo"
let saludo=`Hola, ${nombre} bienvenido`
console.log(saludo)

//Plantillas HTML
let plantilla=
`<html> 
<h1>Pagina web de ${nombre}</h1>
<p>Este es un parrafo</p>
</html>`;
console.log(plantilla)
