$(document).ready(function () {
    $('#crela-slide1').bxSlider({ auto: 0, minSlides: 1, maxSlides: 3, slideWidth: 322, slideMargin: 20, speed: 1000, pager: false, controls: true, prevText: '<', nextText: '>' });
    $('#crela-slide2').bxSlider({ auto: 0, minSlides: 1, maxSlides: 3, slideWidth: 322, slideMargin: 20, speed: 1000, pager: false, controls: true, prevText: '<', nextText: '>' });


    $('.button_menu').click(function () {
        $('#menu1').toggleClass('menu1');
        $('#menu2').toggleClass('menu2');
        $('#menu3').toggleClass('menu3');
        $('.list_menu').slideToggle();
    });

    $('.menu-nganh>li').click(function () {
        var id = $(this).attr('data-id');
        $(this).parent().parent().find('.list-news-tab').hide();
        $(this).parent().parent().find('#' + id).fadeIn();

        $(this).parent().find('>li').removeClass('active');
        $(this).addClass('active');
    });


    $('#sl_linh_vuc').change(function () {

        var id = $(this).val();
        if (id.length !== 0) {
            $(this).parent().parent().find('.list-data').hide();
            $(this).parent().parent().find('#' + id).fadeIn();
            $(this).parent().parent().find('#' + id).find('.left_box_title_2').fadeIn();
        }
        else {
            $(this).parent().parent().find('.list-data').show();
            $(this).parent().parent().find('.left_box_title_2').hide();
        }

    });

    $('#sl_oder').change(function () {

        var order = $(this).val();
        if (order.length !== 0) {
            if (order == 1) {
                $(this).parent().parent().find('.list-group').each(function () {
                    $(this).find('a').sort(asc_sort).appendTo(this);
                })
            }
            else {
                $(this).parent().parent().find('.list-group').each(function () {
                    $(this).find('a').sort(dec_sort).appendTo(this);
                })
            }
        }

    });


});

function asc_sort(a, b) {
    return ($(b).text()) < ($(a).text()) ? 1 : -1;
}

// decending sort
function dec_sort(a, b) {
    return ($(b).text()) > ($(a).text()) ? 1 : -1;
}