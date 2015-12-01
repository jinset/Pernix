
$('#myCarousel').carousel({
    interval: 6000
});

$('#video1').click(function () {
    var src = 'http://www.youtube.com/v/FSi2fJALDyQ&amp;autoplay=1';
    $('#inversionistaModal iframe').attr('src', src);
});

$('#inversionistaModal .close').click(function () {
    $('#inversionistaModal iframe').removeAttr('src');
});

$('#video2').click(function () {
    var src = 'http://www.youtube.com/v/FSi2fJALDyQ&amp;autoplay=1';
    $('#agenteModal iframe').attr('src', src);
});

$('#inversionistaModal .close').click(function () {
    $('#agenteModal iframe').removeAttr('src');
});

$('#video3').click(function () {
    var src = 'http://www.youtube.com/v/FSi2fJALDyQ&amp;autoplay=1';
    $('#clienteModal iframe').attr('src', src);
});

$('#inversionistaModal .close').click(function () {
    $('#clienteModal iframe').removeAttr('src');
});