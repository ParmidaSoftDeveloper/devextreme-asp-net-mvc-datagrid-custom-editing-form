var currentKey;
function editButtonClick(data) {
    $('#customPopup').dxPopup('instance').option('visible', true);
    var textBox = $('#textBox').dxTextBox('instance');
    textBox.option('value', data.CustomerName);
    currentKey = data.OrderID;
}
function deleteButtonClick(data) {
    var grid = $('#gridContainer').dxDataGrid('instance');
    var rowIndex = grid.getRowIndexByKey(data.OrderID);
    grid.deleteRow(rowIndex)
}
function saveButtonClick() {
    var grid = $('#gridContainer').dxDataGrid('instance');

    var textBox = $('#textBox').dxTextBox('instance');
    var value = textBox.option('value');

    var rowIndex = grid.getRowIndexByKey(currentKey);
    grid.cellValue(rowIndex, "CustomerName", value);

    grid.saveEditData()
    $('#customPopup').dxPopup('instance').option('visible', false);
    currentKey = -1;
}
function canselButtonClick() {
    $('#customPopup').dxPopup('instance').option('visible', false);
    currentKey = -1;
}
