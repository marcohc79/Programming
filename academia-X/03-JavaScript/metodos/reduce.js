import { students, developers } from "./data/sampleData.js";

let sumaTotal = students.reduce(function (total, student) {
    return total + student.age;
}, 0)

let sumaTotalV2 = students.reduce((total, student) => total + student.age, 0)

let skills = developers.reduce(function (allSkills, student) {
    return [...allSkills, student.skills]
}, [])

let skillsV2 = developers.reduce(function (allSkills, student) {
    return Array.from(new Set([...allSkills, ...student.skills]))
}, [])
console.log(skillsV2)
