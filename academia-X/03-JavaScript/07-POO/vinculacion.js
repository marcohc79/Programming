// Vinculacion implicita, porque sucedio naturalmente.
// function info() {
//   console.log(this)
// }

// let auto = {
//   modelo: 'Modelo 3',
//   anio: 2021,
//   marca: 'Tesla',
//   info: info
// }

// auto.info();


// Con las funciones flechas necesitamos hacer una vinculacion explicitada
// Hay que utilizar bind, call, apply (metodo de funciones)
function info(a) {
  console.log(this, a)
};

let auto = {
  modelo: 'Modelo 3',
  anio: 2021,
  marca: 'Tesla',
  info: info
};

// info.bind(auto)();
// info.call(auto, 10);
info.apply(auto, [10])
