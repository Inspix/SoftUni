document.addEventListener("DOMContentLoaded", update);

String.prototype.pad= function(len, character){
    var s = '';
    var character = character || '0';
    var len = (len || 2)-this.length;
    return Array(len).join(character)+this;
}

Number.prototype.pad = function(len, character){
  return String(this).pad(len,character);
}

function update(){
  var textArea = document.getElementById('text');
  textArea.innerHTML = getTime();
  setTimeout(update,500);
}

function getTime(){
  var time = new Date();
  var hours = time.getHours();
  var minutes = time.getMinutes();
  var seconds = time.getSeconds();

  return hours.pad(2,'0') + ':' + minutes.pad(2,'0') + ':' +seconds.pad(2,'0');
}
