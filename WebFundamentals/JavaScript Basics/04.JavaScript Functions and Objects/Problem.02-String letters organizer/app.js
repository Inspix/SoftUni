function sortLetters(string, bool){
  var arr = [];
  for (var i = 0; i < string.length; i++) {
    arr.push(string[i]);
  }
  console.log(arr);
  arr.sort(function(a,b){
    var al = a.toLowerCase();
    var bl = b.toLowerCase();

    return al == bl ? 0 : al < bl ? bool ? -1 : 1 : bool ? 1 : -1;
  });
  return arr.join('');
}


var sorted1 = sortLetters('HelloWorld', true);
var sorted2 = sortLetters('HelloWorld', false);

console.log(sorted1);
console.log(sorted2);
