var dataTable

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable(){
    dataTable = $('#tblData').DataTable({
        "ajax": {url:'/admin/product/getall'},
        "columns": [
        {data:'name', "width": "25%" },
        {data:'price', "width": "10%" },
        {data:'modelCode',"width": "25%"}, 
        {data:'category.name',"width": "15%"},
        {
            data:'id',
            "render": function (data) {
                return `<div class="w-100 btn-group" role="group">
                            <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2">
                                <i class="bi bi-pencil-square"></i> Edit
                            </a>
                            <a onclick=Delete("/admin/product/delete/${data}") class="btn btn-danger mx-2">
                                <i class="bi bi-trash3-fill"></i> Delete
                            </a>
                        </div>`
            },
            "width": "25%"
        }
        ]
    });
}

function Delete(url){
    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: "btn btn-danger mx-2",
            cancelButton: "btn btn-primary mx-2"
        },
        buttonsStyling: false
    });
    swalWithBootstrapButtons.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: "Yes, delete it!",
        cancelButtonText: "No, cancel!",
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: "DELETE",
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}