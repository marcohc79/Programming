import {students} from "./data/sampleData.js";

let fullname = students.map(function (student) {
  return student.name + ' ' + student.lastname
})


let names = students.map(student => student.name + ' ' + student.lastname)


const fullnameV2 = students.map(student => {
  return {
    fullname: student.name + ' ' + student.lastname,
    age: student.age,
    course: student.course
  }
})

const fullNamesV3 = students.map(student => {
  return {
    ...student,
    title: `${student.name} - ${student.course}`
  }
})

const fullNamesV4 = students.map(student => ({
  ...student,
  title: `${student.name} - ${student.course}`
}))

let newCourses = students.map(student => ({
  ...student,
  course: 'Programming'
}))

let double = newCourses.map(student => ({
  ...student,
  age: student.age * 2
}))

let newCoursesV2 = students.map(student => ({...student, course: 'Programming'})).map(student => ({
  ...student, age: student.age * 2
}))


console.log(newCoursesV2)
