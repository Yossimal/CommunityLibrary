$("#signUp").click(() => {
    $(location).attr('href', '/HTML/SignUp.html')
});

$("#discover").click(() => {
    $(location).attr('href', '/HTML/BooksMap.html')
});

$("#signIn").click(() => {
    let data = {
        userName: $("#UserName").val(),
        password: $("#Password").val(),
    }

    if (!data.userName.trim() || !data.password.trim()) {
        alert ("please enter username and password")
        return;
    }

    POST(
        "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/CheckLogin",
        data,
        (s) => { alert("success " + s) },
        () => { alert("error signing in") }
    )
});