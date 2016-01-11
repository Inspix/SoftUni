function evalResult(){
  var input = document.getElementById('input').value;

  var result = eval(input);
  var p = document.getElementById("result");
  p.innerHTML = result;
}
