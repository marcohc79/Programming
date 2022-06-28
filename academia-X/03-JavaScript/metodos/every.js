import {students} from './data/sampleData.js';

let result = students.every(student => student.age == 20)
let result2 = students.every(student => student.name.includes('J'))
console.log(result)
console.log(result2)
