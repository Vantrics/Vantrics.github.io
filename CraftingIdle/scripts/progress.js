var prevScrollpos = window.pageYOffset;
window.onscroll = function() {
var currentScrollPos = window.pageYOffset;
  if (prevScrollpos > currentScrollPos) {
    document.getElementById("bottombar").style.bottom = "0";

  } else {
    document.getElementById("bottombar").style.bottom = "-50px";

  }
  prevScrollpos = currentScrollPos;
}