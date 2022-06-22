class Rocola {
  musics = [
    'cancion01',
    'cancion02',
    'cancion03',
    'cancion04',
    'cancion05',
    'cancion06'
  ];
  queue = [];

  play(k) {
    if (this.queue.length >= k) {
      let first = this.queue.shift();
      this.musics.push(first);
    }
    let indexRandom = Math.floor(Math.random() * this.musics.length);
    let music = this.musics.splice(indexRandom, 1)[0];
    this.queue.push(music);
    return music;
  }
}

let rocola = new Rocola();

for (let i = 0; i < 10; i++) {
  console.log(rocola.play(4), rocola.queue);
};
