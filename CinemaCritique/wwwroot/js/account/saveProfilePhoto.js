$(document).ready(function () {
    $('#saveButton').on('click', function () {
        let photoData = $('#pictureUploadInput')[0].files[0];

        if (photoData) {
            let formData = new FormData();
            formData.append('photoData', photoData); // Use 'photoData' as the key

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
                    console.log('File uploaded successfully');
                    // Handle success response
                },
                error: function (error) {
                    console.error('Error uploading file:', error);
                    // Handle error response
                }
            });
        } else {
            console.log('No file selected');
        }
    });

});
