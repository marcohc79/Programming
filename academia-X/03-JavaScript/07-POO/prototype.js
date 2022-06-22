function Car(model, year, brand) {
  this.model = model;
  this.year = year;
  this.brand = brand;
  // this.info = function () {
  //   return this.model + ' - ' + this.brand + ' - ' + this.year;
  // }
}

Car.prototype.info = function () {
  return this.model + ' - ' + this.brand + ' - ' + this.year;
}

let car = new Car('Brand 3', 2021, 'Tesla');
let car2 = new Car('Cupe', 2022, 'Toyota')

console.log(car.info());
console.log(car2.info())
