// The marketing team is spending way too much time typing in hashtags.
// Let's help them with our own Hashtag Generator!

// Here's the deal:

//     It must start with a hashtag (#).
//     All words must have their first letter capitalized.
//     If the final result is longer than 140 chars it must return false.
//     If the input or the result is an empty string it must return false.
//
// Example
// " Hello there thanks for trying my Kata"  =>  "#HelloThereThanksForTryingMyKata"
// "    Hello     World   "                  =>  "#HelloWorld"
// ""                                        =>  false

function generateHashtag(str) {
  return str.length > 140 || str === '' ? false :
    '#' + str.split(' ').map(capitalize).join('');
}

function capitalize(str) {
  return str.charAt(0).toUpperCase() + str.slice(1);
}

let str = " Hello there thanks for trying my Kata";
let str2 = "    Hello     World   ";
let str3 = '          ';
let str4 = 'DO We have A Hashtag'
console.log(generateHashtag(str));
console.log(generateHashtag(str2));
console.log(generateHashtag(str3));
console.log(generateHashtag(str4));
