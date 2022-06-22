let promesa1 = new Promise((reciboDatos, noReciboDatos) => {
  setTimeout(() => {reciboDatos('datos');}, 5000);
});
let promesa2 = new Promise((reciboDatos, noReciboDatos) => {
  setTimeout(() => {
    reciboDatos('datos2');
  }, 2000);
})

// Metodo estatido porque no lo tengo que instanciar.
// Promise.all([promesa1, promesa2])
//   .then((lista) => {
//     console.log(lista);
//   })

Promise.all([promesa1, promesa2])
  .then(([resultado1, resultado2]) => {
    console.log(resultado1);
    return resultado2
  })
  .then(resultado2 => {
    console.log(resultado2.toUpperCase());
  });
