/* JS */


/* Navigation */

$(document).ready(function(){

  $(window).resize(function()
  {
    if($(window).width() >= 765){
      $(".sidebar #nav").slideDown(350);
    }
    else{
      $(".sidebar #nav").slideUp(350); 
    }
  });
  
   $(".has_sub > a").click(function(e){
    e.preventDefault();
    var menu_li = $(this).parent("li");
    var menu_ul = $(this).next("ul");

    if(menu_li.hasClass("open")){
      menu_ul.slideUp(350);
      menu_li.removeClass("open")
    }
    else{
      $("#nav > li > ul").slideUp(350);
      $("#nav > li").removeClass("open");
      menu_ul.slideDown(350);
      menu_li.addClass("open");
    }
  });
});

$(document).ready(function(){
  $(".sidebar-dropdown a").on('click',function(e){
      e.preventDefault();

      if(!$(this).hasClass("open")) {
        // hide any open menus and remove all other classes
        $(".sidebar #nav").slideUp(350);
        $(".sidebar-dropdown a").removeClass("open");
        
        // open our new menu and add the open class
        $(".sidebar #nav").slideDown(350);
        $(this).addClass("open");
      }
      
      else if($(this).hasClass("open")) {
        $(this).removeClass("open");
        $(".sidebar #nav").slideUp(350);
      }
  });

});

/* Widget close */

$('.wclose').click(function(e){
  e.preventDefault();
  var $wbox = $(this).parent().parent().parent();
  $wbox.hide(100);
});

/* Widget minimize */

$('.wminimize').click(function(e){
	e.preventDefault();
	var $wcontent = $(this).parent().parent().next('.widget-content');
	if($wcontent.is(':visible')) 
	{
	  $(this).children('i').removeClass('fa fa-chevron-up');
	  $(this).children('i').addClass('fa fa-chevron-down');
	}
	else 
	{
	  $(this).children('i').removeClass('fa fa-chevron-down');
	  $(this).children('i').addClass('fa fa-chevron-up');
	}            
	$wcontent.toggle(500);
});

/* Progressbar animation */

setTimeout(function(){

	$('.progress-animated .progress-bar').each(function() {
		var me = $(this);
		var perc = me.attr("data-percentage");

		//TODO: left and right text handling

		var current_perc = 0;

		var progress = setInterval(function() {
			if (current_perc>=perc) {
				clearInterval(progress);
			} else {
				current_perc +=1;
				me.css('width', (current_perc)+'%');
			}

			me.text((current_perc)+'%');

		}, 200);

	});

},1200);

/* Slider */

$(function() {
	// Horizontal slider
	// Vertical slider 
	$( "#eq > span" ).each(function() {
		// read initial values from markup and remove that
		var value = parseInt( $( this ).text(), 10 );
		$( this ).empty().slider({
			value: value,
			range: "min",
			animate: true,
			orientation: "vertical"
		});
	});
});

$('.flex-image').flexslider({
    direction: "vertical",
    slideshow:true,
    controlNav: false,
    directionNav: true,
    pauseOnHover: true,
    animationDuration:600,
    slideshowSpeed: 7000
});

/* Support */

$(document).ready(function(){
  $("#slist a").click(function(e){
     e.preventDefault();
     $(this).next('p').toggle(200);
  });
});

/* Scroll to Top */


$(".totop").hide();

$(function(){
	$(window).scroll(function(){
	  if ($(this).scrollTop()>300)
	  {
		$('.totop').fadeIn();
	  } 
	  else
	  {
		$('.totop').fadeOut();
	  }
	});

	$('.totop a').click(function (e) {
	  e.preventDefault();
	  $('body,html').animate({scrollTop: 0}, 500);
	});

});

/* jQuery Notification */
$(document).ready(function() {

  $('.noty-alert').click(function (e) {
      e.preventDefault();
      noty({text: 'Some notifications goes here...',layout:'topRight',type:'alert',timeout:2000});
  });

  $('.noty-success').click(function (e) {
      e.preventDefault();
      noty({text: 'Some notifications goes here...',layout:'top',type:'success',timeout:2000});
  });

  $('.noty-error').click(function (e) {
      e.preventDefault();
      noty({text: 'Some notifications goes here...',layout:'topRight',type:'error',timeout:2000});
  });

  $('.noty-warning').click(function (e) {
      e.preventDefault();
      noty({text: 'Some notifications goes here...',layout:'bottom',type:'warning',timeout:2000});
  });

  $('.noty-information').click(function (e) {
      e.preventDefault();
      noty({text: 'Some notifications goes here...',layout:'topRight',type:'information',timeout:2000});
  });

});


/* On Off pllugin */  

/* Modal fix */

$('.modal').appendTo($('body'));

/* Pretty Photo for Gallery*/

jQuery("a[class^='prettyPhoto']").prettyPhoto({
overlay_gallery: false, social_tools: false
});
/*判断是否为微信浏览器 开始*/
function isWeiXin() {
    var ua = window.navigator.userAgent.toLowerCase();
    if (ua.match(/MicroMessenger/i) == 'micromessenger') {
        return true;
    } else {
        return false;
    }
};
/*判断是否为微信浏览器 结束*/