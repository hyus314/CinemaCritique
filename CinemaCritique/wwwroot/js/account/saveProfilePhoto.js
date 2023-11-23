$(document).ready(function () {
    $('#saveButton').on('click', function () {
        let photoData = $('#pictureUploadInput')[0].files[0];
        let userId = $('#userIdField').val();
        if (photoData) {
            let formData = new FormData();
            formData.append('photoData', photoData); // Use 'photoData' as the key
            formData.append('profileUserId', userId);

            $.ajax({
                url: '/Account/UploadPhoto',
                type: 'POST',
                data: formData,
                processData: false,
                contentType: false,
                headers: {
                    "X-CSRF-VERIFICATION-TOKEN-C-Critique": $('#__RequestVerificationReviewTokenEditProfilePicture').val()
                },
                success: function (response) {
                    if (response.status === true) {
                        // Show success message and redirect on success
                        $('#editPhotoModal .modal-body').append('<div class="alert alert-success" role="alert">Upload successful!</div>');
                        window.location.reload(); // Reload the page to see the updated image
                    } else {
                        // Show error message on failure
                        $('#editPhotoModal .modal-body').append('<div class="alert alert-danger" role="alert">Error: ' + response.error + '</div>');
                    }
                },
                error: function (error) {
                    console.error('Error uploading file:', error);
                    // Show error message on AJAX error
                    $('#editPhotoModal .modal-body').append('<div class="alert alert-danger" role="alert">Error uploading file. Please try again.</div>');
                }
            });
        } else {
            console.log('No file selected');
        }
    });

});
