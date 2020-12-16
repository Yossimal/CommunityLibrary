$('#check').click(() => {
    let url = "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/CheckLogin";
    let data = '{name: "' + $("#name")[0].value + '" }';
  
    $.ajax({
        type:"POST",
        url: "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/Test",
        data: "{name: 'name' }",
        crossDomain: true,
        dataType: 'jsonp',
        success: function () { alert("Success"); },
        error: function () { alert('Failed!'); },
       
    });

});
$(document).ready(() => {
    $.ajax({
        type: "POST",
        url: "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/Test",
        cache: false,
        contentType: "application/json; charset=utf-8",
        data: "{name:'name'}",
        dataType: "json",
        async: true,
        crossDomain: true,
        success: r=>alert(r),
        error: e=>alert('e')
    });
});