// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function deleteItem(id, title) {
  if (confirm(title + " isimli blog postunu silmek istediğinize emin misiniz?")) {
    var form = document.getElementById("deleteForm");
    form.querySelector("input[name='id']").value = id;
    form.submit();
  }
  return false;
}