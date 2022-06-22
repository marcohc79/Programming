class Father {
  constructor(name, surname, iam) {
    this.name = name;
    this.surname = surname;
    this.iam = iam;
  }
  greeting() {
    console.log(`I am ${this.name} ${this.surname} and I am ${this.iam}`);
  }
};

class Child extends Father {
  constructor(name, surname, iam, old) {
    super(name, surname, iam);
    this.old = old;
  }
  greetingChild() {
    console.log(`I am ${this.name} ${this.surname} and I am ${this.iam} and I am ${this.old}`);
  }
}

const father = new Father('Marco', 'Huamani', 'el padre');
const child = new Child('miniMarco', father.surname, 'el hijo', 13);
father.greeting();
child.greetingChild();
