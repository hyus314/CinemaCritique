$(document).ready(function () {
    // Show modal on clicking logout button
    $('#logoutButton').on('click', function () {
        $('#logoutModal').modal('show');
    });

    // Close modal on clicking cancel or close button
    $('#logoutModal button[data-dismiss="modal"]').on('click', function () {
        $('#logoutModal').modal('hide');
    });

    // Handle logout confirmation
    $('#confirmLogout').on('click', function () {
        // Submit the form when confirmed
        $('#logoutForm').submit();
    });
});