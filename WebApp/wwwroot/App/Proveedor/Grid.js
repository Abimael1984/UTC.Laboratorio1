"use strict";
var ProveedorGrid;
(function (ProveedorGrid) {
    if (MensajeApp != "") {
        Toast.fire({ icon: "success", title: MensajeApp });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro seleccionado?", "Eliminar", "warning", '#3085d6', '#d33')
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Proveedor / Grid?handler = Eliminar&id=" + id;
            }
        });
    }
    ProveedorGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(ProveedorGrid || (ProveedorGrid = {}));
//# sourceMappingURL=Grid.js.map