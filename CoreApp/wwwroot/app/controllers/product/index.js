$(window).on('load', function (e) {
    e.preventDefault();
    loadData(true);
    dropdown();
    create();
    edit();
});

function create() {
    $("#btnCreate").on('click', function () {
        GetCategoryId();
        $('#modal-add-edit').modal('show');
    })
}

$('body').on('click', '.btn-edit', function (e) {
    e.preventDefault();
    var that = $(this).data('id');
    edit(that);
});


function edit(that) {
    
        $.ajax({
            type: "GET", 
            url: "/admin/product/getbyid",
            data: { id: that },
            success: function (response) {
                var data = response;
                $('#hidIdM').val(data.Id);
                $('#txtNameM').val(data.name);

                $('#txtDescM').val(data.description);
                $('#txtUnitM').val(data.unit);

                $('#txtPriceM').val(data.price);
                $('#txtOriginalPriceM').val(data.originalPrice);
                $('#txtPromotionPriceM').val(data.promotionPrice);

                $('#txtTagM').val(data.tags);
                $('#txtMetakeywordM').val(data.seoKeywords);
                $('#txtMetaDescriptionM').val(data.seoDescription);
                $('#txtSeoPageTitleM').val(data.seoPageTitle);
                $('#txtSeoAliasM').val(data.seoAlias);
                $('#modal-add-edit').modal('show');
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
        url: '/admin/product/getallpage',
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
                    Image: item.image == null ? '<img src="/admin-side/images/user.png" width=25' : '<img src="' + item.Image + '" width=25 />',
                    //CategoryName: item.ProductCategory.Name,
                    Price: func.formatNumber(item.price, 0),
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

//Get CategoryId
function GetCategoryId(categoryId) {
    var template = $("#category-template").html();
    var render = "";
    $.ajax({
        url: "/admin/productcategory/getlist",
        type: "GET", 
        dataType: "json",
        success: function (res) {
            $.each(res.sources, function (i, item) {
                var selected = '';
                if (categoryId != undefined && categoryId.indexOf(item.name) !== -1)
                    selected = 'selected';
                render += Mustache.render(template, {
                    Id: item.id,
                    Category: item.name,
                    Selected: selected
                });
            });
            if (render != "")
                $("#ddlCategoryIdM").html(render);
        }
    })
}