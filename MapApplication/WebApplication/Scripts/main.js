/*
Mock console functions. console dose not exits on win form WebBrowser.
*/
(function (win, $) {
    if (!win.console) {
        console = {
            log: function (mesg) { },
            error: function (err) {
                alert(err);
            }
        };
    }
})(window, jQuery);

$(function () {
    // 百度地图API功能
    var map = new BMap.Map("baiduMap");    // 创建Map实例
    map.centerAndZoom(new BMap.Point(121.315538, 31.278899), 5);  // 初始化地图,设置中心点坐标和地图级别
    map.addControl(new BMap.MapTypeControl());   //添加地图类型控件
    map.centerAndZoom("上海", 12);          // 设置地图显示的城市 此项是必须设置的
    map.enableScrollWheelZoom(true);     //开启鼠标滚轮缩放

    WebApplication.WebService.GetDevices(function (devices) {
        var markers = [];
        $.each(devices, function (index, point) {
            markers.push(new BMap.Marker(
                new BMap.Point(point.longitude, point.latitude)
            ));
        });
        var markerClusterer = new BMapLib.MarkerClusterer(map, { markers: markers }); //点聚合
    }, function (err) {
        console.error(err);
    });
});

/*

*/
function GenerateTestData()
{
    var shanghai = [{ "latitude": 31.319522486841038, "longitude": 121.25753237201508 }, { "latitude": 31.294247596015893, "longitude": 121.37798305482751 }, { "latitude": 31.29311201758615, "longitude": 121.58201879406553 }, { "latitude": 31.20036189781444, "longitude": 121.66282636997012 }, { "latitude": 31.353984634617408, "longitude": 121.12511420142471 }, { "latitude": 31.1588936670341, "longitude": 121.08602726839467 }, { "latitude": 31.298799913380847, "longitude": 120.9709639212388 }, { "latitude": 31.167031912005903, "longitude": 121.75978850706726 }, { "latitude": 31.18175956191998, "longitude": 121.35256023926092 }, { "latitude": 31.194899119723758, "longitude": 121.55660031211725 }, { "latitude": 31.328480325548426, "longitude": 121.10144230779252 }, { "latitude": 31.32669410453945, "longitude": 121.74137267537355 }, { "latitude": 31.220914901474583, "longitude": 121.67491644161832 }, { "latitude": 31.283714331569843, "longitude": 121.04148388449764 }, { "latitude": 31.18502936282528, "longitude": 121.77410813918718 }, { "latitude": 31.285604729508208, "longitude": 121.76306290937951 }, { "latitude": 31.23387622237097, "longitude": 121.13650217960297 }, { "latitude": 31.277179695929576, "longitude": 120.91493150421928 }, { "latitude": 31.169204989090556, "longitude": 121.04398125417089 }, { "latitude": 31.259890641707454, "longitude": 121.67197233563769 }, { "latitude": 31.367979833602334, "longitude": 121.1658513413076 }, { "latitude": 31.330424241498797, "longitude": 121.13529272249464 }, { "latitude": 31.234130672123047, "longitude": 121.25446465733252 }, { "latitude": 31.29370921236423, "longitude": 121.1977854562822 }, { "latitude": 31.345899777966515, "longitude": 121.02980105559367 }, { "latitude": 31.24445272589403, "longitude": 121.8350599686385 }, { "latitude": 31.223659319614438, "longitude": 121.09128674810874 }, { "latitude": 31.21355326473199, "longitude": 121.52101176408527 }, { "latitude": 31.381858059607747, "longitude": 121.15805744189176 }, { "latitude": 31.320754206609866, "longitude": 121.78804011164931 }, { "latitude": 31.17469539720513, "longitude": 121.47712169042325 }, { "latitude": 31.31101786102738, "longitude": 121.53774934632364 }, { "latitude": 31.354022052156147, "longitude": 120.97560576481015 }, { "latitude": 31.15245197604672, "longitude": 121.75521872636112 }, { "latitude": 31.206644348271503, "longitude": 121.59575645053283 }, { "latitude": 31.151312883620868, "longitude": 121.57659986783939 }, { "latitude": 31.253728292578273, "longitude": 121.09262290688692 }, { "latitude": 31.240431769340894, "longitude": 121.77906130977482 }, { "latitude": 31.36435805765115, "longitude": 121.22349004379825 }, { "latitude": 31.242660392148622, "longitude": 121.04669187392105 }, { "latitude": 31.194031571962164, "longitude": 120.93171482117005 }, { "latitude": 31.189533941268923, "longitude": 121.20716196857083 }, { "latitude": 31.338538171932907, "longitude": 120.91920806864881 }, { "latitude": 31.333047815552753, "longitude": 121.24090213701376 }, { "latitude": 31.228420006985516, "longitude": 121.05421724525239 }, { "latitude": 31.30066541870708, "longitude": 121.80328868650798 }, { "latitude": 31.371544739851938, "longitude": 120.9419230437433 }, { "latitude": 31.367507284184352, "longitude": 121.12030063929568 }, { "latitude": 31.235259708648943, "longitude": 120.94982199282137 }, { "latitude": 31.220674485725475, "longitude": 121.32174221253314 }, { "latitude": 31.250821627731067, "longitude": 121.37112070837898 }, { "latitude": 31.313329843113394, "longitude": 121.62710871816564 }, { "latitude": 31.37981641601593, "longitude": 121.16811022585375 }, { "latitude": 31.19959104094263, "longitude": 120.9340020540059 }, { "latitude": 31.167422798369206, "longitude": 121.14124941552348 }, { "latitude": 31.164087347327722, "longitude": 121.50358610568779 }, { "latitude": 31.3136706218446, "longitude": 121.07378243804592 }, { "latitude": 31.25648222606467, "longitude": 121.79418188211602 }, { "latitude": 31.222551074227972, "longitude": 121.46130625182647 }, { "latitude": 31.341511321795405, "longitude": 121.74016483734975 }, { "latitude": 31.159571946324814, "longitude": 120.96387176145586 }, { "latitude": 31.34281607354565, "longitude": 121.80512903221488 }, { "latitude": 31.15950088118876, "longitude": 121.74197010910338 }, { "latitude": 31.178747838746798, "longitude": 121.16096234537959 }, { "latitude": 31.353766650837212, "longitude": 121.65495321825988 }, { "latitude": 31.260796999955545, "longitude": 121.71962954274223 }, { "latitude": 31.155175729356387, "longitude": 121.45731980895778 }, { "latitude": 31.20845875564053, "longitude": 121.59312389668814 }, { "latitude": 31.32732675469185, "longitude": 121.03191828635426 }, { "latitude": 31.171290714654813, "longitude": 121.56040267348837 }, { "latitude": 31.19916883770142, "longitude": 120.92515255697386 }, { "latitude": 31.244440159875857, "longitude": 121.70273216783986 }, { "latitude": 31.1799033691819, "longitude": 121.82559469571045 }, { "latitude": 31.278933000985255, "longitude": 120.98688287776805 }, { "latitude": 31.151606482109205, "longitude": 120.93468724983508 }, { "latitude": 31.257334941511836, "longitude": 121.37535233331808 }, { "latitude": 31.154276888457048, "longitude": 121.60413044504143 }, { "latitude": 31.208547704262877, "longitude": 121.05653039447186 }, { "latitude": 31.198719737587798, "longitude": 121.2417275526634 }, { "latitude": 31.20618517668093, "longitude": 121.7111190054071 }, { "latitude": 31.301602831118466, "longitude": 121.20330309245784 }, { "latitude": 31.2464907220884, "longitude": 121.7081397697163 }, { "latitude": 31.232230314530295, "longitude": 121.28163917792328 }, { "latitude": 31.223066423821578, "longitude": 121.54327254393961 }, { "latitude": 31.291982979293984, "longitude": 120.98866030227947 }, { "latitude": 31.163205087949525, "longitude": 121.52421969167582 }, { "latitude": 31.298693692778116, "longitude": 121.74506108069308 }, { "latitude": 31.240730681251698, "longitude": 121.80793852611265 }, { "latitude": 31.157424317776183, "longitude": 120.91754707839853 }, { "latitude": 31.27995765252477, "longitude": 121.17678579354308 }, { "latitude": 31.25341217294536, "longitude": 121.40222561320975 }, { "latitude": 31.37275021966173, "longitude": 120.94116523744535 }, { "latitude": 31.176113082903054, "longitude": 121.18456833697496 }, { "latitude": 31.347844068988255, "longitude": 121.78947936557755 }, { "latitude": 31.36652356689063, "longitude": 121.77906770460096 }, { "latitude": 31.360063180401887, "longitude": 121.01002929507571 }, { "latitude": 31.18532925096521, "longitude": 121.62208300969752 }, { "latitude": 31.30905733345599, "longitude": 121.63128017347343 }, { "latitude": 31.31736540185196, "longitude": 120.9471256076197 }, { "latitude": 31.263201366316167, "longitude": 121.23275025857403 }];

    (function fn(i, data, loc, zoom) {
        var point = data[i++];
        if (point) {
            WebApplication.WebService.AddDevice("D" + i * 100, point.longitude, point.latitude, loc, zoom, function (ret) {
                console.log(i, ret);
                fn(i, data);
            }, function (err) {
                console.error(err);
            });
        }
        return fn;
    })(0, shanghai, "上海", "12");
}