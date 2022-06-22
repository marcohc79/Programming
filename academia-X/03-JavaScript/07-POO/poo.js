let auto1 = {
  modelo: 'Modelo 3',
  anio: 2021,
  marca: 'Tesla'
};

let auto2 = {
  modelo: 'Hummer EV',
  anio: 2022,
  marca: 'GMC'
};

function Car(model, year, brand) {
  this.model = model;
  this.year = year;
  this.brand = brand;
}

let car = new Car('Brand 3', 2021, 'Tesla');
console.log(car)
