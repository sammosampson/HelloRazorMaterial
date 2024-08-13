function hookup_mdc_appbar_drawer() {
    const drawer = mdc.drawer.MDCDrawer.attachTo(document.querySelector('.mdc-drawer'));
    const topAppBar = mdc.topAppBar.MDCTopAppBar.attachTo(document.querySelector('.mdc-top-app-bar'));
    topAppBar.listen('MDCTopAppBar:nav', () => {
        drawer.open = !drawer.open;
    });
}

function hookup_mdc() {
   hookup_mdc_appbar_drawer();
}

function hookup_mdc_after_htmx_request() {
    document.addEventListener('htmx:afterRequest', function (evt) {
        hookup_mdc();
    });
}

hookup_mdc_after_htmx_request();
hookup_mdc();