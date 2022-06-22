// function Car(model, year, brand) {
//   this.brand = brand;
//   this.year = year;
//   this.model = model;
// };

// Car.prototype.info = function () {
//   return this.model + ' - ' + this.brand + ' - ' + this.year;
// }

class Car {
  constructor(model, year, brand) {
    this.brand = brand;
    this.year = year;
    this.model = model;
  }
  info() {
    return this.model + ' - ' + this.brand + ' - ' + this.year;
  }
};

const car01 = new Car('Model 3', 2021, 'Tesla');
const car02 = new Car('Hummer EV', 2022, 'GMC')

console.log(car01.info());
console.log(car02.info());
