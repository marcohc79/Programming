import {students} from './data/sampleData.js'

let result = students.filter(function (student) {
  if (student.course === 'Web Development') {
    return true
  };
});

let resultV2 = students.filter(student => student.age > 20);

