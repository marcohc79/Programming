let concatener = (...ars) => {
  // var args = Array.prototype.slice.call(...ars);
  return ars.join('')
}

let strings = concatener('Esto', ' ', 'tendría que', ' ', 'usar join')

// console.log(concatener(strings))

// let invocarFunciones = (...ars) => {
//   let texto = '';
//   for (let i = 0; i < ars.length; i++) {
//     texto += ars[i]()
//   }
//   return texto;
// };


var otraFuncion = function () {
  return ' y después a otra!';
};

var funcionParaInvocar = function () {
  return 'Me llamaron!';
};

// console.log(invocarFunciones(otraFuncion))
// console.log(invocarFunciones(funcionParaInvocar, otraFuncion));

let invocarFunciones = function (...ars) {
  return ars;
}(console.log(funcionParaInvocar(), otraFuncion()))

invocarFunciones
// console.log(invocarFunciones(funcionParaInvocar, otraFuncion));


