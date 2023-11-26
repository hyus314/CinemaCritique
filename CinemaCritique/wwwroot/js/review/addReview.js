$(document).ready(function () {
    let selectedRating = 0;
    $('.star').hover(
        function () {
            let index = $(this).index();
            $('.star').each(function (i) {
                if (i <= index) {
                    $(this).addClass('hover');
                }
            });
        },
        function () {
            $('.star').removeClass('hover');
        }
    );

    $('.star').on('click', function () {
        let index = $(this).index();
        selectedRating = index + 1;
        updateStars(selectedRating);
    });

    function updateStars(rating) {
        $('.star').each(function (i) {
            if (i < rating) {
                $(this).removeClass('hover').addClass('selected');
            } else {
                $(this).removeClass('hover selected');
            }
        });
    }
});

$(document).ready(function () {
    $('#review-text').on('input', function () {
        let maxLength = 300;
        let text = $(this).val();

        if (text.length > maxLength) {
            $(this).val(text.slice(0, maxLength));
        }

        let length = $(this).val().length;
        let charactersRemaining = maxLength - length;

        $('#char-counter').text(charactersRemaining + ' characters remaining');
    });
});


function updateCharacterCount() {
    let maxLength = 300;
    let length = $('#review-text').val().length;
    let charactersRemaining = maxLength - length;
    $('#char-counter').text(charactersRemaining + ' characters remaining');
}

$(document).ready(function () {
    $('#review-text').on('input', updateCharacterCount);
});

$(document).ready(async function () {
    $("#submit-review").on('click', async function () {
        try {
            let reviewText = $("#review-text").val();
            let movieId = $("#movie-id").data("value");
            let ratingValue = $('.star.selected').last().data('value') || 0;
            

            $("#submit-review").prop("disabled", true);

            // Form a JSON object
            let reviewData = {
                movieId: movieId,
                content: reviewText,
                rating: ratingValue
            };

            let response = await $.ajax({
                type: 'POST',
                url: '/Review/AddReview',
                contentType: 'application/json;charset=utf-8',
                headers: {
                    "X-CSRF-VERIFICATION-TOKEN-C-Critique": $('#__RequestVerificationReviewToken').val()
                },
                data: JSON.stringify(reviewData)
            });

            let messageBox = $("#message-box");
            if (response.success) {
                messageBox.text('Review submitted successfully').removeClass('error').addClass('success').fadeIn();
                $("#review-text").val('');
                updateCharacterCount();
                $(".star").removeClass('selected');
                 getPagesAfterAdd();
            } else {
                messageBox.text(response.message).removeClass('success').addClass('error').fadeIn();
            }
            setTimeout(function () {
                messageBox.fadeOut();
            }, 3000);

        } catch (error) {
            if (error.status === 401) { // if unauthorized
                let reviewText = $("#review-text").val();
                let ratingValue = $('.star.selected').last().data('value') || 0;
                let currentPath = window.location.pathname; // gets the path of the current URL.
                let currentQueryString = window.location.search; // gets the query string of the current URL.
                let newQueryString = currentQueryString
                    ? currentQueryString + "&reviewText=" + encodeURIComponent(reviewText) + "&ratingValue=" + ratingValue
                    : "?reviewText=" + encodeURIComponent(reviewText) + "&ratingValue=" + ratingValue;
                let returnUrl = currentPath + newQueryString + "&fromReview=true"; // This will be a local URL.
                let url = "/Identity/Account/Login?fromReview=true&returnUrl=" + encodeURIComponent(returnUrl);
                window.location.href = url;
            } else {
                $("#message-box").text('An unexpected error occurred.').removeClass('success').addClass('error').fadeIn();
                setTimeout(function () {
                    $("#message-box").fadeOut();
                }, 3000);
            }
        } finally {
            $("#submit-review").prop("disabled", false);
        }
        await fetchUpdatedReviews(movieId);
        
    });
});

$(document).ready(function () {
    $(".star").on('click', function () {
        let value = $(this).data('value');
        $(".star").each(function () {
            let $star = $(this);
            $star.removeClass('selected');
            if ($star.data('value') <= value) {
                $star.addClass('selected');
            }
        });
    });
});

async function fetchUpdatedReviews(movieId) {
    $.ajax({
        type: 'GET',
        url: '/Review/GetUpdatedReviews',
        data: { movieId: movieId },
        success: function (response) {
            $('#reviewsContainer').html(response); // Inject the updated reviews into the container
        },
        error: function (error) {
            console.error("Error fetching updated reviews:", error);
        }
    });
}

 function getPagesAfterAdd() {
    $.ajax({
        url: '/Review/GetTotalPages',
        type: 'GET',
        data: { movieId: movieId },
        success: async function (response) {
            await createPagination(response);
            let selectedPage = document.querySelector('.pagination-pages .selected');
            await updatePaginationButtons(selectedPage);
        },
        error: function (error) {
            console.error("Error fetching total pages:", error);
        }
    });
}

async function createPagination(totalPages) {

    paginationContainer.empty();

    for (let i = 1; i <= totalPages; i++) {
        let pageButton;
        if (i == 1) {
            pageButton = $('<button class="page-number selected">' + i + '</button>');
        }
        else {
            pageButton = $('<button class="page-number">' + i + '</button>');
        }
        paginationContainer.append(pageButton);
    }

}

async function updatePaginationButtons(selectedPage) {
    let previousButton = document.getElementById('previousPage');
    let nextButton = document.getElementById('nextPage');
    let previousPage = selectedPage ? selectedPage.previousElementSibling : null;
    let nextPage = selectedPage ? selectedPage.nextElementSibling : null;

    if (!previousPage) {
        previousButton.classList.add('hidden');
    } else {
        previousButton.classList.remove('hidden');
    }

    if (!nextPage || nextPage.classList.contains('disabled')) {
        nextButton.classList.add('hidden');
    } else {
        nextButton.classList.remove('hidden');
    }
}
