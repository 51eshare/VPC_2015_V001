jQuery.validator.addMethod("district", function (value, element) {
    var _flag = true;
    if ($("#sCity").children().length > 1)
    {
        if (!$("#sCity").val())
            _flag = false;
    }
    else if ($("#sProvince").children().length > 1) {
        if (!$("#sProvince").val())
            _flag = false;
    }
    else {
        if ($("#sDistrict").val())
            _flag = true;
        else
            _flag = false;
    }
    return this.optional(element) || _flag;
}, "请选择最后一级");