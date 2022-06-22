// Version 01
// let auto = {
//   modelo: 'Modelo 3',
//   anio: 2021,
//   marca: 'Tesla',
//   info: function () {
//     return 'Este es un auto' + this.marca
//   }
// }

// Version 02

let auto = {
  modelo: 'Modelo 3',
  anio: 2021,
  marca: 'Tesla',
  info: info
}

function info() {
  return 'Este es un auto ' + this.marca
}

console.log(auto.info())
