let texto1 = "Me encanta la música de Charly"
let texto2 = "lala"
let texto3 = "lele"
let texto4 = "lili"
let texto5 = "lolo"
let texto6 = "lulu"
let texto7 = "tutu"


// Esto es para buscar una string dentro de otro, de esta forma diferencia entre mayuscula y minuscula
// let regex = /Me/;

// De esta formano no
// let regex = /Me/i;

// Buscar al inicio del texto:
let regex = /^Me/i;

// Para el final del texto es $

console.log(regex.test(texto1))
console.log(regex.test(texto2))
console.log(regex.test(texto3))
console.log(regex.test(texto4))
console.log(regex.test(texto5))
console.log(regex.test(texto6))
console.log(regex.test(texto7))
