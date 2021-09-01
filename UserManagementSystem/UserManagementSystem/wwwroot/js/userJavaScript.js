$(document).ready(function () {
    $(".Delete").on("click", function (e) {

        var id = $(e.currentTarget).data("id");
        $.ajax({
            url: "/user/DeleteForm/" + id,
            method: "Get",
            success: function (data) {
                $("#body").append(data);
                $("#DeleteModal").on("click", "#DeleteButton", function () {
                    var data = $("#DeleteForm").serialize();
                        
                        $.ajax({
                            url: "/user/Delete",
                            type: "POST",
                            data: data,
                            success: function (succesData) {
                                $('#DeleteModal').modal('hide');
                                window.location.reload();
                            },
                            error: function (errorData) {
                                alert('Please try again!');
                                $('#DeleteModal').modal('hide');
                            }
                        });
                });
                console.log($("#DeleteButton"));
                
            },
            error: function (error) {

            }
        });
        $('#DeleteModal').modal('show');
    });
});