USE [VIOLIN_SUZUKI_LEILA]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CONTACTO]    Script Date: 17/11/2023 13:00:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_INSERTAR_CONTACTO]
@id_alumno int = null,
@id_responsable int = null,
@id_tipo_contacto int,
@contacto varchar(100)
AS
BEGIN
	INSERT INTO Contactos (id_alumno, id_responsable, id_tipo_contacto, contacto)
VALUES (@id_alumno, @id_responsable, @id_tipo_contacto, @contacto)

end

select * from Contactos
select * from Responsables
select * from Dias_Semana
insert into