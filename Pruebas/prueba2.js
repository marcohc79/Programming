function multiplica(a, b) {
  return a * b;
}
var multiplicaPorDos = multiplica.bind(this, 2);

// console.log(multiplicaPorDos(9))



let hola = function (name) {
  return 'Hola ' + name;
}('Javier')

console.log(hola);

(function (name) {
  console.log(name);
}('Marco'));

(function (global, name) {
  console.log(name);
}(window, 'Brian'));
