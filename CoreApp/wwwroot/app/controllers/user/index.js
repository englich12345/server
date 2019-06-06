$(window).on('load', function (e) {
    e.preventDefault();
    loadData(true);
    dropdown();
    create();
    edit();
});

function create() {
    $("#btn-create").on('click', function () {
        resetForm();
        initRoleList();
        $('#modal-add').modal('show');
    })
}

$('body').on('click', '.btn-edit', function (e) {
    e.preventDefault(); 
    var that = $(this).data('id');
    edit(that);
});

$('#btnSaveAdd').on('click', function (e) {
    addUser(e);
})

function addUser(e) {
    e.preventDefault();
    var fullName = $('#txtFullName').val();
    var userName = $('#txtUserName').val();
    var password = $('#txtPassword').val();
    var confirmpassword = $('#txtConfirmPassword').val();
    var email = $('#txtEmail').val();
    var phoneNumber = $('#txtPhoneNumber').val();
    var status = $('#ckStatus').prop('checked') === true ? 1 : 0;
    var userInRole = [];
    if (password == confirmpassword) {
        $.each($('input[name="ckRoles"]'), function (i, item) {
            if ($(item).prop('checked') === true)
                userInRole.push($(item).prop('value'));
        });
        $.ajax({
            type: "POST",
            url: "/admin/user/adduser",
            data: {
                FullName: fullName,
                UserName: userName,
                Password: password,
                Email: email,
                PhoneNumber: phoneNumber,
                Status: status,
                Roles: roles
            },
            dataType: "json",
            success: function () {
                $('#modal-add').modal('hide');
                resetForm();
                loadData(true);
            },
        });
    }
    else {
        $('#checkPass').append("<span>Password isn't same</span>");
    }
    return false;
}

$('#btnSaveUpdate').on('click', function (e) {
    e.preventDefault();
    updateUser();
})

function updateUser() {
    var id = $('#hidId').val();
    var userName = $('#txtUserNameE').val();
    var password = $('#txtPasswordE').val();
    var fullName = $('#txtFullNameE').val();
    var userName = $('#txtUserNameE').val();
    var email = $('#txtEmailE').val();
    var phoneNumber = $('#txtPhoneNumberE').val();
    var status = $('#ckStatusE').prop('checked') === true ? 1 : 0;
    var roles = [];
    $.each($('input[name="ckRoles"]'), function (i, item) {
        if ($(item).prop('checked') === true)
            roles.push($(item).prop('value'));
    });
    $.ajax({
        type: "PUT",
        url: "/admin/user/updateuser",
        contentType: "application/json",
        data: JSON.stringify({
            Id: id,
            Password: password,
            FullName: fullName,
            UserName: userName,
            Email: email,
            PhoneNumber: phoneNumber,
            Status: status,
            Roles: roles
        }),
        dataType: "json",
        success: function () {
            $('#modal-edit').modal('hide');
            resetForm();
            loadData(true);
        },
    });
    return false;
}

function edit(that) {
    $.ajax({
        type: "GET",
        url: "/admin/user/getbyid",
        data: { id: that },
        success: function (response) {
            var data = response;
            $('#hidId').val(data.id);
            $('#txtFullNameE').val(data.fullName);
            $('#txtUserNameE').val(data.userName);
            $('#txtPasswordE').val(data.password);
            $('#txtConfirmPasswordE').val(data.password);
            $('#txtEmailE').val(data.email);
            $('#txtPhoneNumberE').val(data.phoneNumber);
            $('#ckStatusE').prop('checked', data.status === 1);
            initRoleList(data.Roles);
            disableFieldEdit(true);
            $('#modal-edit').modal('show');
        },
        fail: function (err) {
            console.log(err);
        }
    })
}


//popup create user
function dropdown() {
    $('#ddlShowPage').on('change', function () {
        func.configs.pageSize = $(this).val();
        func.configs.pageIndex = 1;
        loadData(true);
    });
    $('#btn-search').on('click', function () {
        loadData();
    })
}


//Load data
function loadData(isChangePageSize) {
    var template = $('#table-template').html();
    var render = "";
    $.ajax({
        type: 'GET',
        url: '/admin/user/getlist',
        data: {
            keyword: $('#txt-search-keyword').val(),
            offset: func.configs.pageIndex,
            limit: func.configs.pageSize
        },
        success: function (res) {
            $.each(res.sources, function (i, item) {
                render += Mustache.render(template, {
                    Id: item.id,
                    UserName: item.userName,
                    FullName: item.fullName,
                    Avatar: item.avatar,
                    Email: item.email,
                    PhoneNumber: item.phoneNumber,
                    Status: func.getStatus(item.status)
                });
            });
            $('#lbl-total-records').text(res.totalCount);
            if (render != "")
                $('#tbl-content').html(render);
            wrapPaging(res.totalCount, function () { loadData(); }, isChangePageSize);
        }
    })
}

$('body').on('click', '.btn-delete', function (e) {
    e.preventDefault();
    var that = $(this).data('id');
    deleteUser(that);
});

function deleteUser(that) {
    func.confirm('Are you sure to Delete?', function () {
        $.ajax({
            type: "DELETE",
            url: '/admin/user/deleteuser',
            data: { id: that },
            dataType: "json",
            success: function (res) {
                console.log("success");
                loadData(true);
            }
        });
    });
}

//Init Role
function initRoleList(selectedRoles) {
    $.ajax({
        url: "/admin/role/getlist",
        type: 'GET',
        dataType: 'json',
        success: function (response) {
            var template = $('#role-template').html();
            var data = response.sources;
            var render = '';
            $.each(data, function (i, item) {
                var checked = '';
                if (selectedRoles !== undefined && selectedRoles.indexOf(item.name) !== -1)
                    checked = 'checked';
                render += Mustache.render(template,
                    {
                        Checked: checked,
                        Name: item.name
                    });
            });
            $('#list-roles').html(render);
        }
    });
}

//Disable Fields
function disableFieldEdit(disabled) {
    $('#txtUserNameE').prop('disabled', disabled);
    $('#txtPasswordE').prop('disabled', disabled);
    $('#txtConfirmPasswordE').prop('disabled', disabled);

}

//Reset Form
function resetForm() {
    disableFieldEdit(false);
    $('#hidId').val('');
    initRoleList();
    $('#txtFullName').val('');
    $('#txtUserName').val('');
    $('#txtPassword').val('');
    $('#txtConfirmPassword').val('');
    $('input[name="ckRoles"]').removeAttr('checked');
    $('#txtEmail').val('');
    $('#txtPhoneNumber').val('');
    $('#ckStatus').prop('checked', false);
}

//Pagination
function wrapPaging(recordCount, callBack, isChangePageSize) {
    var totalPages = Math.ceil(recordCount / func.configs.pageSize);
    //Unbind pagination if it existed or click change pagesize
    if ($('#paginationUL a').length === 0 || isChangePageSize === true) {
        $('#paginationUL').empty();
        $('#paginationUL').removeData("twbs-pagination");
        $('#paginationUL').unbind("page");
    }
    //Bind Pagination Event
    $('#paginationUL').twbsPagination({
        totalPages: totalPages,
        visiblePages: 7,
        first: 'First',
        prev: 'Previous',
        next: 'Next',
        last: 'Last',
        onPageClick: function (event, p) {
            func.configs.pageIndex = p;
            setTimeout(callBack(), 200);
        }
    });
}
