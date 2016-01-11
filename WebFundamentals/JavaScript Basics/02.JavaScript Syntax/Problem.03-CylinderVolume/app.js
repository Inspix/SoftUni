function calcCylinderVol(arr){
  if (arr.length != 2 || isNaN(arr[0]) || isNaN(arr[1])) {
    console.error("invalid input");
    return NaN;
  }else {
    var area = Math.PI * arr[0] * arr[0];
    return area * arr[1];
  }
}

function startTests(){
  var values = [
    [2,4],
    [5,8],
    [12,3]
  ];

  for (var i = 0; i < values.length; i++) {
    var result = calcCylinderVol(values[i]);
    console.log(values[i] + " : " + result.toFixed(3));
  }
}

startTests();
