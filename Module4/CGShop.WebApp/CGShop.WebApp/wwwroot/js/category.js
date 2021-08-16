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
                                <a href='javascript:;' class='btn btn-sm btn-secondary' title="Modify category" onclick="category.get(${item.categoryId})">
                                    <i class='fa fa-pencil-alt'></i>
                                </a>
                                <a href='javascript:;' class='btn btn-sm ${item.status ? 'btn-warning' : 'btn-success'}'
                                   title='${item.status ? 'Inactive' : 'Active'}' onclick='category.changeStatus(${item.categoryId}, ${item.status})'>
                                    <i class='fa ${item.status ? 'fa-lock':'fa-lock-open'}'></i>
                                </a>
                                <a href='javascript:;' class='btn btn-sm btn-danger' title="Remove category" onclick='category.remove(${item.categoryId})'>
                                    <i class='fa fa-trash'></i>
                                </a>
                            </td>
                        </tr>
                    `
                );
            });
            $('#tbCategory').DataTable({
                columnDefs: [
                    { orderable: false, targets: 3 },
                    { "searchable": false, "targets": 2 }
                ],
                order: [[0, 'desc']]
            });
            $('#tbCategory_wrapper').addClass('w-100');
        }
    });
}

category.openModel = function () {
    category.reset();
    $('#categoryModel').modal('show');
}

category.save = function () {
    if ($('#frmCategory').valid()) {
        let categoryId = parseInt($('input[name="CategoryId"]').val());
        //create new category
        if (categoryId == 0) {
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
        //update category
        else {
            var updateCategoryObj = {};
            updateCategoryObj.CategoryId = categoryId;
            updateCategoryObj.CategoryName = $('input[name="CategoryName"]').val();
            updateCategoryObj.Status = $('input[name="Status"]').is(":checked");
            $.ajax({
                url: "https://localhost:44317/Home/Update",
                method: "PUT",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(updateCategoryObj),
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
}

category.reset = function () {
    //reset error messages
    $('#frmCategory').validate().resetForm();
    //reset input values
    $('#frmCategory')[0].reset();
    //reset input color
    var inputs = $('#frmCategory input');
    for (let i = 0; i < inputs.length; i++) {
        inputs[i].classList.remove('error');
    }
    //Reset category Id = 0
    $('input[name="CategoryId"]').val(0);
}

category.changeStatus = function (id, status) {
    bootbox.confirm({
        title: `${status ? "Inactive" : "Active"} category?`,
        message: `Do you want to ${status ? "inactive" : "active"} the category now?`,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if (result) {
                var changeStatusCategoryObj = {};
                changeStatusCategoryObj.CategoryId = id;
                changeStatusCategoryObj.Status = status;
                $.ajax({
                    url: "https://localhost:44317/Home/ChangeStatus",
                    method: "PUT",
                    dataType: "json",
                    contentType: "application/json",
                    data: JSON.stringify(changeStatusCategoryObj),
                    success: function (data) {
                        if (data.success) {
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
    });
}

category.remove = function (id) {
    bootbox.confirm({
        title: `Remove category?`,
        message: `Do you want to remove the category now?`,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `https://localhost:44317/Home/Remove/${id}`,
                    method: "DELETE",
                    success: function (data) {
                        if (data.success) {
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
    });
}

category.get = function (id) {
    $.ajax({
        url: `https://localhost:44317/Home/Get/${id}`,
        method: "GET",
        success: function (data) {
            $('#categoryModel').modal('show');
            $('input[name="CategoryName"]').val(data.categoryName);
            $('input[name="CategoryId"]').val(data.categoryId);
            $('input[name="Status"]').prop('checked', data.status);
        }
    });
}

$(document).ready(function () {
    category.showData();
});
