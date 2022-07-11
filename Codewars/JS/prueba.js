function findOutlier(int) {
  var even = int.filter(a => a % 2 == 0);
  var odd = int.filter(a => a % 2 !== 0);
  console.log(even)
  console.log(odd)
  return even.length == 1 ? even[0] : odd[0];
}
// console.log(findOutlier([1, 2, 3]))

let oracion = 'hola-como-estas-todo-bien'
let guion_bajo = 'Hola_como_estas_todo_bien'
let palabara = 'the_stealth_warrior'

function aux(str) {
  if (str.includes('_')) {
    return str.split('_')
  } else {
    return str.split('-')
  }
}

function camelCaase(str) {
  str = aux(str);
  for (let i = 1; i < str.length; i++) {
    str[i] = str[i][0].toUpperCase() + str[i].slice(1, str[i].length);
  }
  str = str.join('')
  console.log(str)
}

camelCaase(palabara)
