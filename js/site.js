$(function() {
    $('#jcarousel')
       .jcarousel({
           wrap: 'circular'
       })
       .jcarouselAutoscroll({
           interval: 2000,
           target: '+=1',
           autostart: true
       });
});