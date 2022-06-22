function Father(name, surname, iam) {
  this.name = name;
  this.surname = surname;
  this.iam = iam;
};

Father.prototype.greeting = function () {
  console.log(`I am ${this.name} ${this.surname} and I am ${this.iam}`);
}

function Child(name, surname, iam, have) {
  Father.call(this, name, surname, iam);
  this.have = have;
}

Child.prototype = Father.prototype;
Child.prototype.greetingChild = function () {
  console.log(`I am ${this.name} ${this.surname} and I am ${this.iam} and I am ${this.have}`);
}

const father = new Father('Marco', 'Huamani', 'el padre');
const child = new Child('miniMarco', father.surname, 'el hijo', 13);

// console.log(father);
// console.log(child);
father.greeting();
child.greetingChild();

