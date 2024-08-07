document.addEventListener('htmx:afterRequest', function (evt) {
    // Put the JS code that you want to execute here
    hookup_mdc();
});

function hookup_mdc() {
    const buttons = document.querySelectorAll('.mdc-button');
    for (const button of buttons) {
        mdc.ripple.MDCRipple.attachTo(button);
    }

    const textFields = document.querySelectorAll('.mdc-text-field');
    for (const textField of textFields) {
        mdc.textField.MDCTextField.attachTo(textField);
    }

    const drawers = document.querySelectorAll('.mdl-drawer .mdc-list');
    for (const drawer of drawers) {
        mdc.drawer.MDCDrawer.attachTo(drawer);
    }
    
}

hookup_mdc();