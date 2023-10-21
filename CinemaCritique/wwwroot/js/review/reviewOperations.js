function showDeleteModal() {
       $(document).ready(function () {
        $("#removeButton").click(function () {
            $("#deleteModal").show();
        });

        $("#confirmDelete").click(function () {
            // Execute your delete logic here
            // For instance, make an AJAX call to delete the review

            $("#deleteModal").hide();
        });

        $("#cancelDelete").click(function () {
            $("#deleteModal").hide();
        });
    });

    document.getElementById("deleteModal").style.display = "block";
}
