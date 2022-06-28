import {students, developers, points} from "./data/sampleData.js";

let sortedStudents = students.sort(function (first, second) {
  if (first.age > second.age) {
    return 1
  }
  return -1
})

let sortedStudentsV2 = students.sort((first, second) => first.age > second.age ? 1 : -1)
let sortedStudentsV3 = students.sort((first, second) => first.age - second.age)

console.log(sortedStudentsV3);

let sortNumber = points.sort((a, b) => a - b)
let sortNumber2 = points.sort((a, b) => b - a)
console.log(sortNumber);
console.log(sortNumber2);

