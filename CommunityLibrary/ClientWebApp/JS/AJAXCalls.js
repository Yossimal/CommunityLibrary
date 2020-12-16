function POST(method,data,success,fail) {
    $.ajax({
        url: "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/" + method,
        type: "POST",
        data: data,
        contentType: "application/x-www-form-urlencoded",
        dataType: "json",
        headers: {
            'Access-Control-Allow-Origin': "*",
            'accept':'text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9'
        },
        success: success,
        error:fail
    });
}