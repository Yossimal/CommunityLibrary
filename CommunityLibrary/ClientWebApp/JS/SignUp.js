
$("#signUp").click(() => {
    let timestamp = Date.parse($("#birthDate").val());
    if (isNaN(timestamp)) return;

    let birthDate = new Date(timestamp);

    let data = {
        userName: $("#userName").val(),
        password: $("#password1").val(),
        firstName: $("#firstName").val(),
        lastName: $("#lastName").val(),
        dayBirth: birthDate.getDate(),
        monthBirth: birthDate.getMonth() + 1,
        yearBirth: birthDate.getFullYear(),
        emailAddress: $("#email").val(),
        phoneNumber: $("#phoneNumber").val(),
        apartment: $("#apartmentNumber").val(),
        enterance: $("#enterance").val(),
        houseNumber: $("#houseNumber").val(),
        city: $("#city").val(),
        state: $("#state").val(),
        zipCode: $("#zip").val(),
        country: $("#country").val(),
        streetAddress: $("#streetAddress").val(),
    }

    if (data.password != $("#password2").val()) return;

    let jsonData = JSON.stringify(data);

    POST(
        "https://localhost:44333/HttpAPI/CommunityLibraryPrivate.asmx/AddUser",
        jsonData,
        (data) => { alert('success: ' + data) },
        () => { alert('error') }
    )
})