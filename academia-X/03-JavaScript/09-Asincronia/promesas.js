let promesa = new Promise((reciboDatos, noReciboDatos) => {
  setTimeout(() => {
    reciboDatos('Datos');
  }, 5000)
});

promesa
  .then(texto => texto.toUpperCase())
  .then(texto => texto + '!!!!')
  .then(texto => console.log(texto))
  .catch(problema => console.log('Error: ' + problema))
  .finally(() => console.log('Todo Ok!!'))

console.log('Quiero ejecutar lo mas repido posible!')
