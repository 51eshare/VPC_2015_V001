function pass_all() {
    var _array = new Array();
    $("input[check_all='1']").each(function () {
        if ($(this).prop("checked"))
            _array.push($(this).val());
    });
    if (_array.length > 0) {
        $("#check_all_value").val(_array.toString());
        return true;
    }
    else {
        alert("没有选择项");
        return false;
    }
};
$(function () {
    $("#check_all").change(function(){
        var _bool = $(this).prop("checked");
        $("input[check_all='1']").each(function () {
            $(this).prop("checked", _bool);
        });})
});