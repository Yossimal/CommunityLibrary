$('#check').click(() => {
    let url = "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/CheckLogin";
    let data = '{name: "' + $("#name")[0].value + '" }';
  

});
$(document).ready(() => {
    let url = "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/CheckLogin";
    let data = "{name:'aaa'  }";
    $.ajax({
        url: "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/Test",
        type: "POST",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            console.log(data);
        }
    });

});