lista_compra=["manzana","huevos","platanos","leche","tortillas"]
lista_compra.push("Aguacate")
lista_compra.pop()
peliculas=[
    {titulo:"El planeta del tesoro",director:"John Musker",fecha:2002},
    {titulo:"Inception ",director:"Christopher Nolan",fecha:2010},
    {titulo:"Pacific Rim",director:"Guillermo del Toro",fecha:2013}

]
const fechapeli=peliculas.filter(f=>f.fecha<2010)

const directores=peliculas.map(pelicula => pelicula.director)

const titulos=peliculas.map(pelicula => pelicula.titulo)

const concattlista=[directores.concat(titulos)]

const propagatlistas=[...directores,...titulos]

