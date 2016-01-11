var input = [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1];

input = input.filter(function(obj){
  return obj >= 0 && obj <= 400;
});

input = input.map(function(obj){
  var result = obj - (obj * 0.2);
  return result;
});

console.log(input.sort(function(a,b){
  return a == b ? 0 : a < b ? -1 : 1;
}));
