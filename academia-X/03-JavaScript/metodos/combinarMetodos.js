import {students} from './data/sampleData.js';

let onlyStudents = students.map(student => ({
  student: `${student.name} ${student.lastname}`,
  age: student.age
}))

let onlyStudentsV2 = students.map(({name, lastname, age}) => ({
  student: `${name} ${lastname}`,
  age
}))
  .filter(student => student.age > 20)
  .sort((first, second) => first.age - second.age)
  .reduce((total, student) => total + student.age, 0)

console.log(onlyStudentsV2)
