@Imports DevExtremeMvcAppGridTest.Models

    @Code
        ViewBag.Title = "Index"
    End Code

    <h2>Home</h2>

    @Code
        Html.DevExtreme().DataGrid(Of Order).ID("gridContainer").ShowBorders(True).DataSource(Function(d) d.WebApi().Controller("Orders").LoadAction("Get").Key("OrderID").UpdateAction("Put")) _
        .Columns(Sub(columns)
            columns.AddFor(Function(p) p.CustomerName)
            columns.AddFor(Function(p) p.OrderDate)
            columns.Add().Width(160).Alignment(HorizontalAlignment.Center) _
.CellTemplate(Sub()
                @<text>
                    @Html.DevExtreme().Button().Text("Edit").OnClick("function (e) { editButtonClick(data) }")
                    @Html.DevExtreme().Button().Text("Delete").OnClick("function (e) { deleteButtonClick(data) }")
                </text>
                       End Sub)
                     End Sub) _
            .RemoteOperations(True).Render()
        End Code


    @Code 
        Html.DevExtreme().Popup().ID("customPopup").Title("Custom popup edit").Visible(False).ContentTemplate(Sub()
            @<text>
                @Html.Label("CustomText")
                @Html.DevExtreme().TextBox().ID("textBox")
                @Html.DevExtreme().Button().Text("Save").OnClick("function (e) { saveButtonClick() }")
                @Html.DevExtreme().Button().Text("Cansel").OnClick("function (e) { canselButtonClick() }")
            </text>
                                                                                                              End Sub).Render()

    End Code