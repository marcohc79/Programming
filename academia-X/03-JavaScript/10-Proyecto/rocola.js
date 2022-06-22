const musics = [
  'cancion01',
  'cancion02',
  'cancion03',
  'cancion04',
  'cancion05',
  'cancion06'
];

let randomSong = (copyMusics) => {
  return Math.floor(Math.random() * copyMusics.length);
};

let rocola = (randomSong, copyMusics, songsPlayed, counter) => {
  deleteMusic = copyMusics.splice(randomSong, 1);
  songsPlayed.push(deleteMusic);
  if (!(counter % 4)) {
    console.log(counter + ' entre')
    let music = songsPlayed.splice(0, 1);
    copyMusics.push(music);
  }
  return copyMusics, songsPlayed;
};

let menu = () => {
  let copyMusics = JSON.parse(JSON.stringify(musics));
  let songsPlayed = new Array;
  let flag = true;
  let counter = 1;
  let info = 0;

  while (flag) {
    randomMusic = randomSong(copyMusics);
    console.log('Playing: ' + copyMusics[randomMusic]);
    copyMusics, songsPlayed = rocola(randomMusic, copyMusics, songsPlayed, counter);
    counter++;
    info++;
    if (info == 5) {
      flag = false;
    };
  };
};

menu();
