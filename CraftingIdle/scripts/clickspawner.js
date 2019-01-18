function clickCounter() {
  if (typeof(Storage) !== "undefined") {
    if (sessionStorage.clickcount) {
      sessionStorage.clickcount = Number(sessionStorage.clickcount)+1;
    } else {
      sessionStorage.clickcount = 1;
    }
    document.getElementById("result").innerHTML = "你目前擁有 " + sessionStorage.clickcount + " 個小麥。";
  } else {
    document.getElementById("result").innerHTML = "你的瀏覽器不支援.";
    }
}


/*初始化偵錯*/
function clickReset() {

  if (typeof(Storage) !== "undefined") {
    if (sessionStorage.clickcount) {
      sessionStorage.clickcount = 0;
    } else {
      sessionStorage.clickcount = 0;
    }
    document.getElementById("result").innerHTML = "你目前擁有 " + sessionStorage.clickcount + " 個小麥。";
  } else {
    document.getElementById("result").innerHTML = "你的瀏覽器不支援.";
    }
}