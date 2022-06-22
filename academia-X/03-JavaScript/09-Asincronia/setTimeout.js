// console.log('antes');
// setTimeout(() => {
//   console.log('Cualquier codigo');
// }, 4000);
// console.log('despues');


// En este caso el setTimeout no va correr.
console.log('antes');
let timeout = setTimeout(() => {
  console.log('Cualquier codigo');
}, 4000);
console.log('despues');
clearTimeout(timeout);
