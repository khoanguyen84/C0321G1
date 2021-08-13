var category = {};

category.showData = function () {
    $.ajax({
        url: "https://localhost:44317/Home/Get",
        method: "GET",
        success: function (data) {
            $('#tbCategory tbody').empty();
            $.each(data, function (index, item) {
                $('#tbCategory tbody').append(
                    `
                        <tr>
                            <td>${item.categoryId}</td>
                            <td>${item.categoryName}</td>
                            <td class='text-right'><span class="btn btn-sm ${item.status ? 'btn-success': 'btn-warning'}">${item.status ? 'Active' : 'Inactive'}</span></td>
                            <td class='text-right'>
                                <a href='javascript:;' class='btn btn-sm btn-secondary' title="Modify category">
                                    <i class='fa fa-pencil-alt'></i>
                                </a>
                                <a href='javascript:;' class='btn btn-sm ${item.status ? 'btn-warning' : 'btn-success'}'
                                   title='${item.status ? 'Inactive' : 'Active'}'>
                                    <i class='fa ${item.status ? 'fa-lock':'fa-lock-open'}'></i>
                                </a>
                                <a href='javascript:;' class='btn btn-sm btn-danger' title="Remove category">
                                    <i class='fa fa-trash'></i>
                                </a>
                            </td>
                        </tr>
                    `
                );
            });
        }
    });
}

category.openModel = function () {
    $('#categoryModel').modal('show');
}

category.save = function () {
    if ($('#frmCategory').valid()) {
        var createCategoryObj = {};
        createCategoryObj.CategoryName = $('input[name="CategoryName"]').val();
        createCategoryObj.Status = $('input[name="Status"]').is(":checked");
        $.ajax({
            url: "https://localhost:44317/Home/Create",
            method: "POST",
            dataType: "json",
            contentType: "application/json",
            data: JSON.stringify(createCategoryObj),
            success: function (data) {
                if (data.success) {
                    $('#categoryModel').modal('hide');
                    category.showData();
                    $.notify(data.message, "success");
                }
                else {
                    $.notify(data.message, "error");
                }
            }
        });
    }
}

$(document).ready(function () {
    category.showData();
});