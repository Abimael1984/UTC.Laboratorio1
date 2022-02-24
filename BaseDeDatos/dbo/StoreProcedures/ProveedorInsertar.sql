CREATE PROCEDURE [dbo].[ProveedorInsertar]
	@Identificacion VARCHAR(250),
	@Nombre VARCHAR(250),
	@PrimerApellido VARCHAR(250),
	@SegundoApellido VARCHAR(250),
	@Edad INT,
	@FechaNacimiento DATETIME

AS
BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA
		
		BEGIN TRY 
			
			INSERT INTO dbo.Proveedor
			(Identificacion
			,Nombre
			,PrimerApellido
			,SegundoApellido
			,Edad
			,FechaNacimiento		
			)
			VALUES(
			@Identificacion
			,@Nombre
			,@PrimerApellido
			,@SegundoApellido
			,@Edad
			,@FechaNacimiento	
			)

			COMMIT TRANSACTION TRASA
			SELECT 0 AS CodeError, '' AS MsgError

		END TRY

		BEGIN CATCH
		SELECT
			ERROR_NUMBER () AS CodeError,
			ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA

		END CATCH

	END
	