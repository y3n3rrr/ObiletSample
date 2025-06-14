let fp;
document.addEventListener('DOMContentLoaded', function () {
    // Get the date from the input value (from Model)
    const input = document.getElementById('obus-datepicker');
    let defaultDate = input.value && input.value.trim() !== "" ? input.value : "today";

    fp = flatpickr("#obus-datepicker", {
        dateFormat: "d F Y l",
        locale: "tr",
        minDate: "today",
        defaultDate: defaultDate,
        allowInput: true,
        onReady: highlightTodayTomorrow,
        onChange: highlightTodayTomorrow
    });

    document.getElementById('obus-btn-today').addEventListener('click', function (e) {
        e.preventDefault();
        setToday();
    });
    document.getElementById('obus-btn-tomorrow').addEventListener('click', function (e) {
        e.preventDefault();
        setTomorrow();
    });

    highlightTodayTomorrow();

    // Swap button functionality
    document.querySelector('.obus-swap-btn').addEventListener('click', function () {
        var originSelect = document.querySelector('select[name="OriginId"]');
        var destinationSelect = document.querySelector('select[name="DestinationId"]');
        var temp = originSelect.value;
        originSelect.value = destinationSelect.value;
        destinationSelect.value = temp;
    });

    // Spinner and submit button toggle
    var form = document.getElementById('obusForm');
    var spinner = document.getElementById('obus-spinner');
    var submitBtn = document.getElementById('obus-search-btn');
    form.addEventListener('submit', function (e) {
        spinner.style.display = "inline-block";
        submitBtn.style.display = "none";
    });
});

function setToday() {
    const today = new Date();
    today.setHours(0, 0, 0, 0);
    fp.setDate(today, true);
    highlightTodayTomorrow();
}

function setTomorrow() {
    const tomorrow = new Date();
    tomorrow.setDate(tomorrow.getDate() + 1);
    tomorrow.setHours(0, 0, 0, 0);
    fp.setDate(tomorrow, true);
    highlightTodayTomorrow();
}

function highlightTodayTomorrow() {
    const todayBtn = document.getElementById('obus-btn-today');
    const tomorrowBtn = document.getElementById('obus-btn-tomorrow');
    todayBtn.classList.remove('active');
    tomorrowBtn.classList.remove('active');

    if (!fp || !fp.selectedDates || !fp.selectedDates[0]) return;

    const selectedDate = new Date(fp.selectedDates[0]);
    selectedDate.setHours(0, 0, 0, 0);
    const today = new Date();
    today.setHours(0, 0, 0, 0);
    const tomorrow = new Date(today);
    tomorrow.setDate(today.getDate() + 1);

    if (selectedDate.getTime() === today.getTime()) {
        todayBtn.classList.add('active');
    } else if (selectedDate.getTime() === tomorrow.getTime()) {
        tomorrowBtn.classList.add('active');
    }
}