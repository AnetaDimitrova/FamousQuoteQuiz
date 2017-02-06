$(document).ready(function () {
    $(".authors").click(function () {
        

        var quoteAuthorId = $(".content").attr("id");
        var authorId = $(this).attr("id");
        

        $.ajax({
            url: "/Main/ChoiseCorrect",
            method: "POST",
            data: { quoteAuthorId: quoteAuthorId, authorId: authorId },
            success: function (data) {
                $("#result").html(data);
                $("#authors_container").hide();
                $("#result").show();
                $(".hidden_el").show();
            }
        });

    });

    $('.rb_mode').change(function () {
        var isBinaryMode = false;
        if ($(this).attr('id') == 'binary_mode') {
            isBinaryMode = true;
        }
        $.ajax({
            url: "/Main/ChangeMode",
            method: "POST",
            data: { isBinaryMode: isBinaryMode }
        });
    });
})