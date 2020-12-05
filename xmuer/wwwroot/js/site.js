// XMUer 全局 JS

// 导航栏自动选中
$(function () {
    $(".han-navbar-list").find("li").each(function () {
        var a = $(this).find("a:first")[0];
        if ($(a).attr("href") === location.pathname) {
            $(this).addClass("active");
        } else {
            $(this).removeClass("active");
        }
    });
})

// 左侧导航栏 active