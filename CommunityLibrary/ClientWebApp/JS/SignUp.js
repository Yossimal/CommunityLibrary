
$("#signUp").click(() => {
    data = $("form").serialize()

    alert(data);
    //POST(
    //    "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/AddUser",
    //    data,
    //    (data) => { alert('success: ' + data) },
    //    () => { alert('error') }
    //)
})