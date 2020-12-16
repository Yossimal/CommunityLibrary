function POST(method,data,success,fail) {
    $.ajax({
        url: "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/"+method,
        type: "POST",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: success,
        error:fail
    });
}