
function chart(type, labels, colours, dataItems) {
    const ctx = document.getElementById(type);

    const data = {
        labels: labels,
        datasets: [{
            label: 'Best colours',
            data: dataItems,
            backgroundColor: colours,
            hoverOffset: 4
        }]
    };

    new Chart(ctx, {
        type: type,
        data: data,
    });
}

function hookup_mdc_appbar_drawer() {
    const drawerElement = document.querySelector('.mdc-drawer');
    if (drawerElement === null) {
        return;
    }
    const drawer = mdc.drawer.MDCDrawer.attachTo(drawerElement);
    const topAppBar = mdc.topAppBar.MDCTopAppBar.attachTo(document.querySelector('.mdc-top-app-bar'));
    topAppBar.listen('MDCTopAppBar:nav', () => {
        drawer.open = !drawer.open;
    });
}

function hookup_mdc_buttons() {
    const buttons = document.querySelectorAll('.mdc-button');
    for (const button of buttons) {
        mdc.ripple.MDCRipple.attachTo(button);
    }
}

function hookup_mdc_text_fields() {
    const textFields = document.querySelectorAll('.mdc-text-field');
    for (const textField of textFields) {
        mdc.textField.MDCTextField.attachTo(textField);
    }
}

function hookup_mdc() {
    hookup_mdc_appbar_drawer();
    hookup_mdc_buttons();
    hookup_mdc_text_fields();
}

function hookup_mdc_after_htmx_request() {
    document.addEventListener('htmx:afterRequest', function (evt) {
        hookup_mdc();
    });
}

hookup_mdc_after_htmx_request();
hookup_mdc();