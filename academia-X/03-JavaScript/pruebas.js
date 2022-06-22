let lista = ['cero', 'uno', 'dos', 'tres'];
let copyMusics = JSON.parse(JSON.stringify(lista));
numberRandom = Math.floor(Math.random() * copyMusics.length);
console.log(numberRandom)
let eliminado = lista.splice(0, 1);
