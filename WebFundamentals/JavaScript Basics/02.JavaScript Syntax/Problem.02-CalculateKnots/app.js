function kmToKnots(kms) {
  if (typeof kms == 'number') {
    return kms * 0.539956803;
  } else {
    return NaN;
  }
}

function startTests() {
  var inputs = [
    20,
    112,
    400
  ];
  for (var i = 0; i < inputs.length; i++) {
    var result = kmToKnots(inputs[i]);
    console.log("Km/h : " + inputs[i] + " = Knots : " + result.toFixed(2));
  }
}

startTests();
