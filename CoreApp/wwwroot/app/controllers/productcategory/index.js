$(window).on('load', function (e) {
    e.preventDefault();
    loadData(true);
    dropdown();
    create();
    edit();
});

function create() {
    $("#btnCreate").on('click', function () {
        $('#modal-add').modal('show');
    })
}

$('body').on('click', '.btn-edit', function (e) {
    e.preventDefault();
    var that = $(this).data('id');
    edit(that);
});

$('#btnSaveAdd').on('click', function (e) {
    addProductCategory(e);
})

function addProductCategory(e) {
    var name = $('#name').val();
    var description = $('#desc').val();
    var parentId = $('#parent').val();
    var homeOrder = $('#homeOrder').val();
    var sortOrder = $('#sortOrder').val();
    var seoAlias = $('#seoas').val();
    var seoPageTitle = $('#seopt').val();
    var seoKeyWords = $('#seoKW').val();
    var seoDescription = $('#seoDes').val();
    var status = $('#status').prop('checked') == true ? 1 : 0;
    e.preventDefault();
    $.ajax({
        type: "POST",
        url: '/admin/productcategory/addproductcategory',
        data: {
            Name: name,
            Description: description,
            ParentId: parentId,
            HomeOrder: homeOrder,
            SortOrder: sortOrder,
            SeoAlias: seoAlias,
            SeoPageTitle: seoPageTitle,
            SeoKeyWords: seoKeyWords,
            SeoDescription: seoDescription,
            Status: status
        },
        dataType: "json",
        success: function (res) {
            $('#txtName').val('');
            $('#txtDesc').val('');
            $('#txtParent').val('');
            $('#txtHomeOrder').val('');
            $('#txtSortOrder').val('');
            $('#txtSeoAlias').val('');
            $('#txtSeoPageTitle').val('');
            $('#txtSeoKeywords').val('');
            $('#txtSeoDescription').val('');
            $('#modal-add').modal('hide');
            loadData(true);
        }
    });
    return false;
}

$('#btnSaveUpdate').on('click', function (e) {
    updateProductCategory(e);
})

function updateProductCategory(e) {
    e.preventDefault();
    $.ajax({
        type: "PUT",
        url: '/admin/productcategory/updateproductcategory',
        contentType: "application/json",
        dataType: "json",
        data: JSON.stringify({
            id: $('#hidIdM').val(),
            Name: $('#txtNameM').val(),
            Description: $('#txtDescM').val(),
            ParentId: $('#txtParentM').val(),
            HomeOrder: $('#txtHomeOrderM').val(),
            SortOrder: $('#txtSortOrderM').val(),
            SeoAlias: $('#txtSeoAliasM').val(),
            SeoPageTitle: $('#txtSeoPageTitleM').val(),
            SeoKeyWords: $('#txtSeoKeywordsM').val(),
            SeoDescription: $('#txtSeoDescriptionM').val(),
            Status: $('#ckStatusM').prop('checked') == true ? 1 : 0
        }),
        success: function (res) {
            $('#modal-edit').modal('hide');
            loadData(true);
        }
    });
    return false;
}

function edit(that) {
    $.ajax({
        type: "GET", 
        url: "/admin/productcategory/getbyid",
        data: { id: that },
        success: function (response) {
            var data = response;
            $('#hidIdM').val(data.id);
            $('#txtNameM').val(data.name);
            $('#txtDescM').val(data.description);
            $('#txtParentM').val(data.parentId);
            $('#txtHomeOrderM').val(data.homeOrder);
            $('#txtSortOrderM').val(data.sortOrder);
            $('#txtSeoAliasM').val(data.seoAlias);
            $('#txtSeoKeywordsM').val(data.seoKeywords);
            $('#txtSeoDescriptionM').val(data.seoDescription);
            $('#ckStatusM').prop('checked', data.status == 1);
            $('#modal-edit').modal('show');
        },
        fail: function (err) {
            console.log(err);
        }
    })
}


//popup create-edit product
function dropdown() {
    $('#ddlShowPage').on('change', function () {
        func.configs.pageSize = $(this).val();
        func.configs.pageIndex = 1;
        loadData(true);
    });
    $('#search').on('click', function () {
        loadData();
    })
}


//Load data
function loadData(isChangePageSize) {
    var template = $('#table-template').html();
    var render = "";
    $.ajax({
        type: 'GET',
        url: '/admin/productcategory/getlist',
        data: {
            keyword: $('#txtsearchkeyword').val(),
            offset: func.configs.pageIndex,
            limit: func.configs.pageSize
        },
        success: function (res) {
            $.each(res.sources, function (i, item) {
                render += Mustache.render(template, {
                    Id: item.id,
                    Name: item.name,
                    Description: item.description,
                    Image: item.image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                    CreatedDate: func.dateTimeFormatJson(item.dateCreated),
                    Status: func.getStatus(item.status)
                });    
            });
            $('#lblTotalRecords').text(res.totalCount);
            if (render != "")
                $('#tbl-content').html(render);
            wrapPaging(res.totalCount, function () { loadData(); }, isChangePageSize);
        }
    })
}

$('body').on('click', '.btn-delete', function (e) {
    e.preventDefault();
    var that = $(this).data('id');
    deletePC(that);
});

function deletePC (that){
    func.confirm('Are you sure to Delete?', function () {
        $.ajax({
            type: "DELETE",
            url: '/admin/productcategory/deleteproductcategory',
            data: { id: that },
            dataType: "json",
            success: function (res) {
                console.log("success");
                loadData(true);
            }
        });
    });
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
