//https://github.com/CodeSeven/toastr adresindeki toastr mesajlariin gostermek icin boyle
// bir js dosyasi olusturdum.

//******* toastr kullanımı icin *******
window.ShowToastr = (type, message) => {

    if (type === "success") {
        // Display a success toast, with a title
        toastr.success(message, 'Operation Succesful', {timeOut: 3000});
    }

    if (type === "error") {
        // Display a success toast, with a title
        toastr.error(message, 'Operation failed', { timeOut:3000 });

    }
}

//******* sweetalert kullanımı icin *******
window.ShowSwal = (type, message) => {

    if (type === "success") {        
        Swal.fire(
            'Success Notification',
            message,
            'success' //succes icon
        )
    }

    if (type === "error") {
        Swal.fire(
            'Error Notification',
            message,
            'error' //error icon
        )

    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}

function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}