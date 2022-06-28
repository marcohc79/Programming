import { students } from "./data/sampleData.js";

let studentsM = students.some(function (student) {
    if (student.age > 24) {
        return true
    }
})

let result = students.some(student => student.lastname === 'Doe');

console.log(result)



    
