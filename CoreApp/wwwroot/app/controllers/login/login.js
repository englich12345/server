
$(window).on('load', function () {
    $('#loginButton').click(function (e) {
        e.preventDefault();
        var user = $("#txtusername").val();
        var pass = $("#txtpassword").val();
        $.ajax({
            type: "POST",
            data: JSON.stringify({
                Username: user,
                Password: pass
            }),
            contentType: "application/json",
            dataType: "json",
            url: '/admin/login/authen',
            success: function (res) {
                if (res.statusCode == 200) {
                    window.location.href = 'Admin/Home/Index';
                }
                else {
                    alert("Your Account is wrong");
                }
            }
        });
    })
});