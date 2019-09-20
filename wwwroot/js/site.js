// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var checkk = function () {
    if (document.getElementById('pass1').value == document.getElementById('confirmpass1').value) {

        document.getElementById("check").disabled = false;
        document.getElementById('message').style.color = "blue";
        document.getElementById('message').innerHTML = '<div style="margin-bottom:12px">Mật khẩu khớp</div>';
    } else {
        document.getElementById("check").disabled = true;
        document.getElementById('message').style.color = "red";
        document.getElementById('message').innerHTML = '<div style="margin-bottom:12px">Mật khẩu không khớp</div>';
    }
    if (document.getElementById('pass1').value == "") {
        document.getElementById("check").disabled = false;
        document.getElementById('message').innerHTML = '';
    }
}
function displayDetailSend(re_name, mail_title, mail_content) {
    document.getElementById("title-detail").innerHTML = mail_title;
    document.getElementById("receiver-detail").innerHTML = re_name;
    document.getElementById("content-detail").innerHTML = mail_content;
    document.getElementById("hihi").style.display = "none";
    document.getElementById("maildetailSend").style.display = "block";
}
function displayDetailRecive(send_name, mail_title, mail_content) {
    document.getElementById("title-detail1").innerHTML = mail_title;
    document.getElementById("receiver-detail1").innerHTML = send_name;
    document.getElementById("content-detail1").innerHTML = mail_content;
    document.getElementById("haha").style.display = "none";
    document.getElementById("maildetailRecive").style.display = "block";
}
function displayListDetailSend() {
    document.getElementById("hihi").style.display = "block";
    document.getElementById("maildetailSend").style.display = "none";
}