﻿var width = 0;
var speed = 0.025;
move();
function move() {
    var elem = document.getElementById("sireBar"); 
    var id = setInterval(frame, 0.1);
    function frame() {
        if (width >= 100) {
            clearInterval(id);
            width=0; 
            elem.style.width = width + '%';
            move();
        } else {
            width=width+speed;
	    elem.style.width = width + '%';
            
             
        }
    }
}