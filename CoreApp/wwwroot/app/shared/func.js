﻿var func = {
    configs: {
        pageSize: 10,
        pageIndex:1
    },
    notify: function (message, type) {
        $.notify(message, {
            // whether to hide the notification on click
            clickToHide: true,
            // whether to auto-hide the notification
            autoHide: true,
            // if autoHide, hide after milliseconds
            autoHideDelay: 5000,
            // show the arrow pointing at the element
            arrowShow: true,
            // arrow size in pixels
            arrowSize: 5,
            // position defines the notification position though uses the defaults below
            position: '...',
            // default positions
            elementPosition: 'top left',
            globalPosition: 'top right',
            // default style
            style: 'bootstrap',
            // default class (string or [string])
            className: type,
            // show animation
            showAnimation: 'slideDown',
            // show animation duration
            showDuration: 400,
            // hide animation
            hideAnimation: 'slideUp',
            // hide animation duration
            hideDuration: 200,
            // padding between element and notification
            gap: 2
        })
    },
    confirm: function (message,callFunc) {
        bootbox.confirm({
            title: message,
            message: "Are you sure to do this action?",
            buttons: {
                cancel: {
                    label: '<i class="fa fa-times"></i> Cancel'
                },
                confirm: {
                    label: '<i class="fa fa-check"></i> Confirm'
                }
            },
            callback: function (result) {
                if (result == true) {
                    callFunc();
                }
            }
        });
    },
    dateFormatJson: function (datetime) {
        if (datetime == null || datetime == '') {
            return '';
        }
        var newdate = new Date(parseInt(datetime.substr(6)));
        var month = newdate.getMonth() - 1;
        var day = newdate.getDay();
        var year = newdate.getFullYear();
        var hh = newdate.getHours();
        var mm = newdate.getMinutes();
        if (month < 10)
            month = "0" + month;
        if (day < 10) {
            day = "0" + day;
        }
        if (hh < 10)
            hh = "0" + hh;
        if (mm < 19) {
            mm = "0" + mm;
        }
        return day + "/" + month + "/" + year;

    },
    dateTimeFormatJson: function (datetime) {
        if (datetime == null || datetime == '') {
            return '';
        }
        var newdate = new Date(parseInt(datetime.substr(6)));
        var month = newdate.getMonth() - 1;
        var day = newdate.getDay();
        var year = newdate.getFullYear();
        var hh = newdate.getHours();
        var mm = newdate.getMinutes();
        var ss = newdate.getSeconds();
        if (month < 10)
            month = "0" + month;
        if (day < 10) {
            day = "0" + day;
        }
        if (hh < 10)
            hh = "0" + hh;
        if (mm < 19) {
            mm = "0" + mm;
        }
        if (ss < 19) {
            ss = "0" + ss;
        }
        return day + "/" + month + "/" + year + "-" + hh + ":" + mm + ":" + ss;
    },
    //startLoading: function () {
    //    if ($('.dv-loading').length > 0
    //        $('.dv-loading').removeClass('hide');
    //},
    //stopLoading: function () {
    //    if ($('.dv-loading').length > 0
    //        $('.dv-loading').addClass('show');
    //},
    getStatus: function (status) {
        if (status == 1)
            return '<span class="badge bg-green">Active</span>';
        else return '<span class="badge bg-red">Inactive</span>';
    },
    formatNumber: function (number,precision) {
        if (!isFinite(number)) {
            return number.toString(); 
        }

        var a = number.toFixed(precision).split('.');
        a[0] = a[0].replace(/\d(?=(\d{3})+$)/g, '$&,');
        return a.join('.');
    },
    unflattern: function (array) {
        var map = {};
        var roots = [];
        for (var i = 0; i < arr.length; i += 1) {
            var node = arr[i];
            node.children = [];
            map[node.id] = i; // use map to look-up the parents
            if (node.parentId !== null) {
                arr[map[node.parentId]].children.push(node);
            } else {
                roots.push(node);
            }
        }
        return roots;
    }
}
//$(document).ajaxSend(function (e, xhr, options) {
//    if (options.type.toUpperCase() == "POST" || options.type.toUpperCase() == "PUT") {
//        var token = $('form').find('input[name="__RequestVerificationToken"]').val();
//        xhr.setRequestheader("RequestVerificationToken", token);
//    }
//});