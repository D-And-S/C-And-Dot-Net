function confirmDelete(uniqeId, isDeletClicked) {
    var deleteSpan = 'deleteSpan_' + uniqeId;
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqeId;

    if (isDeletClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}