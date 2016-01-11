function getRoots(a, b, c) {

  c = Math.sqrt((b * b) - (4 * a * c));
  a = 2 * a;

  return {
    'first': (-b - c) / a,
    'second': (-b + c) / a
  };
}

function start() {
  var firstTest = getRoots(2, 5, -3);
  var secondTest = getRoots(2, -4, 2);
  var thirdTest = getRoots(4, 2, 1);

  printResult(firstTest);
  printResult(secondTest);
  printResult(thirdTest);
}

function printResult(tuple) {
  if (isNaN(tuple.first) && isNaN(tuple.second)) {
    console.log("no real root");
  } else {
    if (tuple.first == tuple.second) {
      console.log("X1 = " + tuple.first);
      return;
    }
    if (!isNaN(tuple.first)) {
      console.log("X1 = " + tuple.first);
    }
    if (!isNaN(tuple.second)) {
      console.log("X2 = " + tuple.second);
    }
  }
}

start();
