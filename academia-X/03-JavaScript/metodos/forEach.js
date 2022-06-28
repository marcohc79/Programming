import {students} from "./data/sampleData.js";

students.forEach(function (student, index, students) {
  console.log(student);
  console.log(index);
  console.log(students)
});

students.forEach((student, index) => {
  console.log(student)
  console.log(index)
})
