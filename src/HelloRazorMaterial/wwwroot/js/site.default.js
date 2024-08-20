/* 
    This file contains the default site-wide scripts  
*/

function hookup_chart(element) {
    var config = JSON.parse(document.getElementById(`${element.id}-chart-script`).textContent);
    new Chart(element, config);
}

function hookup_charts() {
    const charts = document.querySelectorAll('.chartjs-chart');
    for (const chart of charts) {
        hookup_chart(chart);
    }
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

function hookup_mdc_selects() {
    const selects = document.querySelectorAll('.mdc-select');
    for (const select of selects) {
        mdc.select.MDCSelect.attachTo(select);
    }
}

function hookup_mdc_text_fields() {
    const textFields = document.querySelectorAll('.mdc-text-field');
    for (const textField of textFields) {
        mdc.textField.MDCTextField.attachTo(textField);
    }
}

function hookup() {
    hookup_charts();
    hookup_mdc_appbar_drawer();
    hookup_mdc_buttons();
    hookup_mdc_text_fields();
    hookup_mdc_selects();
}

function hookup_after_htmx_request() {
    document.addEventListener('htmx:afterRequest', function (evt) {
        hookup();
    });
}

hookup_after_htmx_request();
hookup();