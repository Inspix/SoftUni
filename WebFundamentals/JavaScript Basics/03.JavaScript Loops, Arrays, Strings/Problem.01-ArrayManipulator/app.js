function isNumber(n){
  return !Array.isArray(n) && !isNaN(parseFloat(n) && isFinite(n));
}

var input = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]];

function sortFunc(a,b){
  return a == b ? 0 : a < b ? -1 : 1;
}

function maxOccurences(arr){
  var map = {};
  var max = 0;
  for (var i = 0; i < arr.length; i++) {
      map[arr[i]] = ++map[arr[i]] || 1;
      if (map[arr[i]] > max) {
        max = map[arr[i]];
      }
  }
  return max;
}

function startTests(arr){
  var filtered = arr.filter(isNumber);
  console.log(filtered);
  filtered.sort(sortFunc);
  console.log("Min number: " + filtered[0]);
  console.log("Max number: " + filtered[filtered.length-1]);
  console.log("Most occurences: "  + maxOccurences(filtered));
  console.log(filtered.reverse());
}

startTests(input);
