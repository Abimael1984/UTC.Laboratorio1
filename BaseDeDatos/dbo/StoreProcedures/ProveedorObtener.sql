CREATE PROCEDURE [dbo].[ProveedorObtener]
	@IdProveedor INT = NULL

AS
BEGIN
	SET NOCOUNT ON

	SELECT
		IdProveedor
		,Identificacion
		,Nombre
		,PrimerApellido
		,SegundoApellido
		,Edad
		,FechaNacimiento

	FROM dbo.Proveedor
	WHERE 
		(@IdProveedor IS NULL OR IdProveedor = @IdProveedor)


END

