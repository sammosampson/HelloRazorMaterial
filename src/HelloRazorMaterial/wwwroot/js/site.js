

function hookup_mdc() {
    const buttons = document.querySelectorAll('.mdc-button');
    for (const button of buttons) {
        mdc.ripple.MDCRipple.attachTo(button);
    }

    const textFields = document.querySelectorAll('.mdc-text-field');
    for (const textField of textFields) {
        mdc.textField.MDCTextField.attachTo(textField);
    }

    const drawer = mdc.drawer.MDCDrawer.attachTo(document.querySelector('.mdc-drawer'));
    const topAppBar = mdc.topAppBar.MDCTopAppBar.attachTo(document.querySelector('.mdc-top-app-bar'));
    topAppBar.listen('MDCTopAppBar:nav', () => {
        drawer.open = !drawer.open;
    });

function hookup_mdc_after_htmx_request() {
    document.addEventListener('htmx:afterRequest', function (evt) {
        hookup_mdc();
    });
}

function doughnut_chart(canvasId) {
    const ctx = document.getElementById(canvasId);

    const data = {
        labels: [
            'Red',
            'Blue',
            'Yellow'
        ],
        datasets: [{
            label: 'My First Dataset',
            data: [300, 50, 100],
            backgroundColor: [
                'rgb(255, 99, 132)',
                'rgb(54, 162, 235)',
                'rgb(255, 205, 86)'
            ],
            hoverOffset: 4
        }]
    };

    new Chart(ctx, {
        type: 'doughnut',
        data: data,
    });
}

hookup_mdc_after_htmx_request();
hookup_mdc();