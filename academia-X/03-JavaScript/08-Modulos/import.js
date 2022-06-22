import Servicio, {PI, sumar} from './export.js';
// import cualquierNomber form './import';

// import * as todo from './import'
// console.log(todo.sumar(5,4))

let resultado = sumar(1, 2);
console.log(resultado)
console.log(PI)
const servicio = new Servicio()
console.log(servicio.restaTres(PI))
