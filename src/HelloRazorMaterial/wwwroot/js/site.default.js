/* 
    This file contains the default site-wide scripts  
*/
const activeCharts = [];

function hookup_chart(element) {
    var config = JSON.parse(document.getElementById(`${element.id}-chart-script`).textContent);
    activeCharts.push(new Chart(element, config));
}

function hookup_charts() {
    const charts = document.querySelectorAll('.chartjs-chart');
    for (const chart of charts) {
        hookup_chart(chart);
    }
}

function unhookup_charts() {
    for (const chart of activeCharts) {
        chart.destroy();
    }
    activeCharts.clear
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

function hookup_mdc_tables() {
    const buttons = document.querySelectorAll('.mdc-data-table');
    for (const button of buttons) {
        mdc.dataTable.MDCDataTable.attachTo(button);
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
    hookup_mdc_tables();
    hookup_mdc_text_fields();
    hookup_mdc_selects();
}

function unhookup() {
    unhookup_charts();
}

function hookup_htmx_events() {
    document.addEventListener('htmx:afterSettle', function (evt) {
        hookup();
    });

    document.addEventListener('htmx:beforeRequest', function (evt) {
        unhookup();
    });
}

hookup_htmx_events();
hookup();