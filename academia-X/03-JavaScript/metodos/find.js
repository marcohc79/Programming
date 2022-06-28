import {students} from './data/sampleData.js'

let result = students.find(function (student) {
  if (student.name === "Ryan") {
    return 1
  }
})

let resultV2 = students.find(student => student.name === 'Ryan')

console.log(result)
console.log(resultV2)
