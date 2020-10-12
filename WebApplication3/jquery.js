$(document).ready(function(){ 
    $('.aspNetHidden').hide();
    var a = 0;
    $('.hide').hide();
    $('.menu1').click(function () {
        a = a + 1;
        if (a % 2 == 0) {
            $('.hide').fadeOut("fast");
        }
        else {
            $('.hide').fadeIn("slow");
        }
    });


    $('.hide1').mouseover(function () {
        $('.menu1').css("border-bottom-color", "white");
        $('.menu1').css("color", "white");
    });
    $('.hide2').mouseover(function () {
        $('.menu1').css("border-bottom-color", "white");
        $('.menu1').css("color", "white");
    });
    $('.hide1').mouseout(function () {
        $('.menu1').css("border-bottom-color", " #353b48");
        $('.menu1').css("color", "silver");
    });
    $('.hide2').mouseout(function () {
        $('.menu1').css("border-bottom-color", " #353b48");
        $('.menu1').css("color", "silver");
    });

    $('.menu1').mouseover(function () {
        $('.menu1').css("border-bottom-color", "white");
        $('.menu1').css("color", "white");
    });
    $('.menu1').mouseout(function () {
        $('.menu1').css("border-bottom-color", " #353b48");
        $('.menu1').css("color", "silver");
    });
})