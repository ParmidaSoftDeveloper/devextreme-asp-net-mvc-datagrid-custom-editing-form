<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128583394/17.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T591034)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DataGrid for DevExtreme - How to implement a custom editing form in ASP.NET MVC

This example demonstrates how to create a custom pop-up editing form for a DataGrid. The implementation includes the [Popup](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxPopup/) component and uses its [contentTemplate](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxPopup/Configuration/#contentTemplate) field to add an editing form. To create edit buttons in the DataGrid, use the [cellTemplate](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/columns/#cellTemplate) property.

## Files to Look At

* [OrdersController.cs](./CS/DevExtremeMvcApp1/Controllers/OrdersController.cs)
* [Order.cs](./CS/DevExtremeMvcApp1/Models/Order.cs)
* [SampleData.cs](./CS/DevExtremeMvcApp1/Models/SampleData.cs)
* [customPopup.js](./CS/DevExtremeMvcApp1/Scripts/customPopup/customPopup.js)
* [Index.cshtml](./CS/DevExtremeMvcApp1/Views/Home/Index.cshtml)

## Documentation

- [Getting Started with DataGrid](https://js.devexpress.com/Documentation/Guide/UI_Components/DataGrid/Getting_Started_with_DataGrid/)

- [DataGrid - API Reference](https://js.devexpress.com/Documentation/ApiReference/UI_Components/dxDataGrid/)

## More Examples

- [DataGrid for DevExtreme - How to implement a custom editing form using the Popup and Form components](https://github.com/DevExpress-Examples/devextreme-datagrid-custom-editing-form)

- [DataGrid for DevExtreme - How to show/hide or enable/disable Edit Form items based on another item's value](https://github.com/DevExpress-Examples/DataGrid-How-to-hide-disable-Edit-Form-items-based-on-another-item-s-value)