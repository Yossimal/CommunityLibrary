var CommunityLibraryPrivateURL = "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/Test"

function POST(url,data,success,fail) {
    $.ajax({
        url: CommunityLibraryPrivateURL,
        type: "POST",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: success,
        error:fail
    });
}