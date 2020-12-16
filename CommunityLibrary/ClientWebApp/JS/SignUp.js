﻿
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
        phone: $("#phoneNumber").val(),
        apartmentNumber: $("#apartmentNumber").val(),
        enterance: $("#enterance").val(),
        houseNumber: $("#houseNumber").val(),
        city: $("#city").val(),
        state: $("#state").val(),
        zip: $("#zip").val(),
        country: $("#country").val(),
        street: $("#streetAddress").val(),
    }

    if (data.password != $("#password2").val()) return;
    POST(
        'AddUser',
        data,
        (data) => { alert('success: ' + data) },
        () => { alert('error') }
    )
})