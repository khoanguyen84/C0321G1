var category = {};

category.showCategory = function(){
    $.ajax({
        url:"https://localhost:44341/api/Category",
        method:"GET",
        success: function(data){
            $('#tbCategory tbody').empty();
            $.each(data, function(index, item){
                $('#tbCategory tbody').append(`
                    <tr>
                        <td>${item.categoryId}</td>
                        <td>${item.categoryName}</td>
                        <td>${item.status}<d>
                        <td></td>
                    </tr>
                `);
            });
        }
    });
}


category.initCategoryDDL = function(){
    $.ajax({
        url:"https://localhost:44341/api/Category",
        method:"GET",
        success: function(data){
            $('#ddlCategory').empty();
            $.each(data, function(index, item){
                $('#ddlCategory').append(`
                    <option value=${item.categoryId}>${item.categoryName}</option>
                `);
            });
        }
    });
}

$(document).ready(function(){
    category.showCategory();
    category.initCategoryDDL();
});