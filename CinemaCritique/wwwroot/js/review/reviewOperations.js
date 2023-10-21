function showConfirmationModal() {
    $(document).ready(function () {
        $("#removeButton").click(function () {
            $("#confirmationModal").show();
        });

        $("#confirmDelete").click(function () {
            // Execute your delete logic here
            // For instance, make an AJAX call to delete the review

            $("#confirmationModal").hide();
        });

        $("#cancelDelete").click(function () {
            $("#confirmationModal").hide();
        });
    });

    document.getElementById("confirmationModal").style.display = "block";
}
