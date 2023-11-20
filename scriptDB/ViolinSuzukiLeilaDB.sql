CREATE DATABASE VIOLIN_SUZUKI_LEILA
GO
USE VIOLIN_SUZUKI_LEILA

create table Formas_Pago
(
id_forma_pago int identity (1,1),
forma_pago varchar(30),
CONSTRAINT PK_FORMAS_PAGO PRIMARY KEY (id_forma_pago)
)

create table Tipos_Contacto
(
id_tipo_contacto int identity(1,1),
tipo_contacto varchar(20),
CONSTRAINT PK_TIPOS_CONTACTO PRIMARY KEY (id_tipo_contacto)
)

create table Medidas
(
id_medida int identity(1,1),
medida varchar(10),
CONSTRAINT PK_MEDIDAS PRIMARY KEY (id_medida)
)

create table Marcas
(
id_marca int identity (1,1),
marca varchar(20),
CONSTRAINT PK_MARCAS PRIMARY KEY (id_marca)
)

create table Libros_Suzuki
(
id_libro int identity(1,1),
libro varchar(20),
CONSTRAINT PK_LIBROS_SUZUKI PRIMARY KEY (id_libro)
)

create table Provincias
(
id_provincia int identity (1,1),
provincia varchar(15),
CONSTRAINT PK_PROVINCIAS PRIMARY KEY (id_provincia)
)

create table Ciudades
(
id_ciudad int identity (1,1),
ciudad varchar(40),
id_provincia int,
CONSTRAINT PK_CIUDADES PRIMARY KEY (id_ciudad),
CONSTRAINT FK_CIUDADES_PROVINCIAS FOREIGN KEY (id_provincia) REFERENCES Provincias (id_provincia)
)

create table Canciones
(
id_cancion int identity (1,1),
cancion varchar(60),
id_libro int,
CONSTRAINT PK_CANCIONES PRIMARY KEY (id_cancion),
CONSTRAINT FK_CANCIONES_LIBROS FOREIGN KEY (id_libro) REFERENCES Libros_Suzuki (id_libro)
)

create table Dias_Semana
(
id_dia int identity (1,1),
dia varchar (20),
CONSTRAINT PK_DIAS_SEMANA PRIMARY KEY (id_dia)
)

create table Tipo_Responsable
(
id_tipo_responsable int identity (1,1),
tipo_responsable varchar (20),
CONSTRAINT PK_TIPO_RESPONSABLE PRIMARY KEY (id_tipo_responsable)
)

create table Alumnos
(
id_alumno int identity (1,1),
nombre varchar(40),
apellido varchar(40),
dni int,
calle varchar (50),
altura varchar(10),
id_ciudad int,
fec_alta date,
fec_nac date,
colegio varchar(50),
observaciones varchar(200),
CONSTRAINT PK_ALUMNOS PRIMARY KEY (id_alumno),
CONSTRAINT FK_ALUMNOS_CIUDAD FOREIGN KEY (id_ciudad) REFERENCES Ciudades (id_ciudad)
)

create table Horarios_Clases
(
id_horario int identity (1,1),
id_dia int,
hora_inicio time,
hora_fin time,
id_alumno int,
CONSTRAINT PK_HORARIOS_CLASES PRIMARY KEY (id_horario),
CONSTRAINT FK_HORARIOS_CLASES_DIAS FOREIGN KEY (id_dia) REFERENCES Dias_Semana (id_dia),
CONSTRAINT FK_HORARIOS_CLASES_ALUMNOS FOREIGN KEY (id_alumno) REFERENCES Alumnos (id_alumno)
)

create table Ausencias
(
id_ausencia int identity (1,1),
id_horario int,
motivo varchar (40),
CONSTRAINT PK_AUSENCIAS PRIMARY KEY (id_ausencia),
CONSTRAINT FK_AUSENCIAS_HORARIOS_CLASES FOREIGN KEY (id_horario) REFERENCES Horarios_Clases (id_horario)
)

create table Responsables
(
id_responsable int identity (1,1),
id_tipo_responsable int,
nombre varchar(40),
apellido varchar (40),
dni int,
calle varchar (50),
altura varchar(10),
id_ciudad int,
fec_alta date,
observaciones varchar (200),
CONSTRAINT PK_RESPONSABLES PRIMARY KEY (id_responsable),
CONSTRAINT FK_RESPONSABLES_TIPO_RESPONSABLES FOREIGN KEY (id_tipo_responsable) REFERENCES Tipo_Responsable (id_tipo_responsable),
CONSTRAINT FK_RESPONSABLES_CIUDAD FOREIGN KEY (id_ciudad) REFERENCES Ciudades (id_ciudad)
)

create table Contactos
(
id_contacto int identity (1,1),
contacto varchar (40),
id_tipo_contacto int,
id_alumno int,
id_responsable int,
CONSTRAINT PK_CONTACTOS PRIMARY KEY (id_contacto),
CONSTRAINT FK_CONTACTOS_TIPO_CONTACTO FOREIGN KEY (id_tipo_contacto) REFERENCES Tipos_Contacto (id_tipo_contacto),
CONSTRAINT FK_CONTACTOS_ALUMNOS FOREIGN KEY (id_alumno) REFERENCES Alumnos (id_alumno),
CONSTRAINT FK_CONTACTOS_RESPONSABLES FOREIGN KEY (id_responsable) REFERENCES Responsables (id_responsable)
)

create table Pagos
(
id_pago int identity (1,1),
monto money,
fecha_pago date,
id_alumno int,
id_responsable int,
id_forma_pago int,
concepto varchar (20),
CONSTRAINT PK_PAGOS PRIMARY KEY (id_pago),
CONSTRAINT FK_PAGOS_ALUMNOS FOREIGN KEY (id_alumno) REFERENCES Alumnos (id_alumno),
CONSTRAINT FK_PAGOS_RESPONSABLES FOREIGN KEY (id_responsable) REFERENCES Responsables (id_responsable),
CONSTRAINT FK_PAGOS_FORMA_PAGO FOREIGN KEY (id_forma_pago) REFERENCES Formas_Pago (id_forma_pago)
)

create table Violines
(
id_violin int identity (1,1),
modelo varchar (50),
id_medida int,
id_marca int,
precio money,
id_alumno int,
CONSTRAINT PK_VIOLINES PRIMARY KEY (id_violin),
CONSTRAINT FK_VIOLINES_MEDIDAS FOREIGN KEY (id_medida) REFERENCES Medidas (id_medida),
CONSTRAINT FK_VIOLINES_MARCHAS FOREIGN KEY (id_marca) REFERENCES Marcas (id_marca),
CONSTRAINT FK_VIOLINES_ALUMNOS FOREIGN KEY (id_alumno) REFERENCES Alumnos (id_alumno)
)

create table Progresos
(
id_progreso int identity,
fecha datetime,
id_alumno int,
id_responsable int,
CONSTRAINT PK_PROGRESOS PRIMARY KEY (id_progreso),
CONSTRAINT FK_PROGRESOS_ALUMNOS FOREIGN KEY (id_alumno) REFERENCES Alumnos (id_alumno),
CONSTRAINT FK_PROGRESOS_RESPONSABLES FOREIGN KEY (id_responsable) REFERENCES Responsables (id_responsable)
)

create table Detalles_Progreso
(
id_detalle_progreso int,
id_progreso int,
id_cancion int,
observaciones varchar (230),
CONSTRAINT PK_DETALLES_PROGRESO PRIMARY KEY (id_detalle_progreso, id_progreso),
CONSTRAINT FK_DETALLES_PROGRESO_PROGRESO FOREIGN KEY (id_progreso) REFERENCES Progresos (id_progreso),
CONSTRAINT FK_DETALLES_PROGRESO_CANCIONES FOREIGN KEY (id_cancion) REFERENCES Canciones (id_cancion)
)


/*INSERTS*/

/*Formas_Pago*/
INSERT INTO Formas_Pago(forma_pago) VALUES('Contado/Efectivo')
INSERT INTO Formas_Pago(forma_pago) VALUES('Transferencia')
INSERT INTO Formas_Pago(forma_pago) VALUES('Pago Parcial')
INSERT INTO Formas_Pago(forma_pago) VALUES('Dolares')

/*Tipos_Contacto*/
INSERT INTO Tipos_Contacto VALUES('Telefono')
INSERT INTO Tipos_Contacto VALUES('Mail')

/*Medidas*/
INSERT INTO Medidas VALUES('1/10')
INSERT INTO Medidas VALUES('1/8')
INSERT INTO Medidas VALUES('1/4')
INSERT INTO Medidas VALUES('1/2')
INSERT INTO Medidas VALUES('3/4')
INSERT INTO Medidas VALUES('4/4')

/*Marcas*/
INSERT INTO Marcas VALUES('Parquer')
INSERT INTO Marcas VALUES('Ancona')
INSERT INTO Marcas VALUES('Stradella')
INSERT INTO Marcas VALUES('Cervini')
INSERT INTO Marcas VALUES('Cremona')
INSERT INTO Marcas VALUES('Yamaha')
INSERT INTO Marcas VALUES('OnMonich')
INSERT INTO Marcas VALUES('Franchuli')
INSERT INTO Marcas VALUES('SantaCruz')

/*Libros_Suzuki*/
INSERT INTO Libros_Suzuki VALUES('1')
INSERT INTO Libros_Suzuki VALUES('2')
INSERT INTO Libros_Suzuki VALUES('3')
INSERT INTO Libros_Suzuki VALUES('4')
INSERT INTO Libros_Suzuki VALUES('5')
INSERT INTO Libros_Suzuki VALUES('6')
INSERT INTO Libros_Suzuki VALUES('7')
INSERT INTO Libros_Suzuki VALUES('8')
INSERT INTO Libros_Suzuki VALUES('9')
INSERT INTO Libros_Suzuki VALUES('10')

select * from Marcas

/*Canciones*/

/*LIBRO 1*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Brilla brilla, estrellita',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Remando Suavemente',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Cancion del viento',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Tia Rhody',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Pequeños Niños',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Cancion de Mayo',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('7.Long, long ago',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('8.Allegro',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('9.Moto Perpetuo',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('10.Allegretto',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('11.Andantino',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('12.Etude',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('13.Minuet 1',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('14.Minuet 2',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('15.Minuet 3',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('16.El granjero feliz',1)
INSERT INTO Canciones (cancion,id_libro) VALUES('17.Gavotte',1)

/*LIBRO 2*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Chorus de Handel',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Mussette',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Hunters Chorus',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Long, long ago II',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Vals de Brahms',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Bourree',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('7.Los 2 granaderos',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('8.Danza de las Brujas',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('9.Gavotte de Mignon',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('10.Gavotte de Lully',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('11.Minuet en Sol de Beethoven',2)
INSERT INTO Canciones (cancion,id_libro) VALUES('12.Minuet de Boccherini',2)

/*LIBRO 3*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Gavotte de Martini',3)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Minuet de Bach',3)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Gavotte en Sol Menor de Bach',3)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Humoresque',3)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Gavotte de Becker',3)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Gavotte en Re Mayor de Bach',3)
INSERT INTO Canciones (cancion,id_libro) VALUES('7.Bourree de Bach',3)

/*Libro 4*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Conc N°2 en Sol Mayor, Op.13 3erMov, Seitz',4)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Conc N°5 en Re Mayor, Op.22 1erMov, Seitz',4)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Conc N°5 en Re Mayor, Op.22 3erMov, Seitz',4)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Conc en La Menor, Op.3 1erMov, Vivaldi',4)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Conc en La Menor, Op.3 3erMov, Vivaldi',4)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Moto perpetuo, "Pequeña Suite N°6", Bohm',4)
INSERT INTO Canciones (cancion,id_libro) VALUES('7.Conc para 2 Violines Re Menor, VII 1erMov, Bach',4)

/*LIBRO 5*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Gavotte, Bach',5)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Conc en La Menor, Op.3 2erMov, Vivaldi',5)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Conc en Sol Menor, Vivaldi',5)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Country Dance, Weber',5)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Danza Alemana, Dittersdorf',5)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Giga, Veracini',5)
INSERT INTO Canciones (cancion,id_libro) VALUES('7.Conc para 2 Violines Re Menor, VI 1erMov, Bach',5)

/*LIBRO 6*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.La Folia, Corelli/Suzuki',6)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Sonata N°3 en Fa Mayor, Handel',6)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Allegro, Fiocco',6)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Gavotte, Rameau',6)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Escalas y Arpeggios en Si Menor',6)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Sonata N°4 en Re Mayor, Handel',6)

/*LIBRO 7*/

INSERT INTO Canciones (cancion,id_libro) VALUES('1.Minuet, Mozart',7)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Courante, Corelli',7)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Sonata N°1, Handel',7)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Concierto N°1, Bach',7)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Giga, Bach',7)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Couurante, Bach',7)
INSERT INTO Canciones (cancion,id_libro) VALUES('7.Allegro, Corelli',7)

/*LIBRO 8*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Sonata N°11 en Sol Menor, Eccles',8)
INSERT INTO Canciones (cancion,id_libro) VALUES('2.Tambourin, Gretry',8)
INSERT INTO Canciones (cancion,id_libro) VALUES('3.Largo, Sonata N°3 en Do Mayor, Bach',8)
INSERT INTO Canciones (cancion,id_libro) VALUES('4.Preludio, Sonata en Mi Menor, Bach',8)
INSERT INTO Canciones (cancion,id_libro) VALUES('5.Allegro, Sonata en Mi Menor, Bach',8)
INSERT INTO Canciones (cancion,id_libro) VALUES('6.Largo Espressivo, Pugnani',8)
INSERT INTO Canciones (cancion,id_libro) VALUES('7.Sonata en Mi Menor, Veracini',8)

/*LIBRO 9*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Conc en La Mayor, K.219, Mozart',9)

/*LIBRO 10*/
INSERT INTO Canciones (cancion,id_libro) VALUES('1.Conc en Re Mayor, K.218, Mozart',10)



--Insert tipo responsables
INSERT INTO Tipo_Responsable(tipo_responsable) VALUES 
('Madre'),
('Padre'),
('Abuela/o'),
('Hermana/o');

--INSERT Provincias
INSERT INTO Provincias(provincia) VALUES 
('Cordoba'),
('Buenos Aires');

--INSERT Ciudades
INSERT INTO Ciudades(ciudad, id_provincia) VALUES
('Alta Gracia', 1),
('Capital Federal', 2),
('Cordoba Capital',1)
GO

DBCC CHECKIDENT ('Ciudades', RESEED, 0)

--SP CARGAR COMBO PROVINCIA
CREATE PROCEDURE SP_CARGAR_COMBO_PROVINCIA
as
begin
SELECT * FROM Provincias
end
go

--SP CARGAR COMBO CIUDAD
CREATE PROCEDURE SP_CARGAR_COMBO_CIUDAD
@id_provincia int
as
begin
SELECT * FROM Ciudades
WHERE id_provincia = @id_provincia
end
go

select * from Ciudades
GO

--SP CARGAR ALUMNO
CREATE PROCEDURE SP_CARGAR_ALUMNO
@nombre varchar(50),
@apellido varchar(50),
@dni int,
@calle varchar(50),
@altura varchar(50),
@id_ciudad int,
@observaciones varchar(150),
--parametros particulares de alumnos
@colegio varchar(50),
@fecha_nac datetime
AS
BEGIN
INSERT INTO Alumnos(nombre,apellido,dni,calle,altura,id_ciudad,fec_alta,fec_nac,colegio,observaciones)
VALUES(@nombre,@apellido,@dni,@calle,@altura,@id_ciudad,getdate(),@fecha_nac,@colegio,@observaciones)
END
GO
--SP CARGAR COMBO TIPO RESPONSABLE
CREATE PROCEDURE SP_CARGAR_COMBO_TIPO_RESPONSABLE
AS
BEGIN
	SELECT * FROM Tipo_Responsable
END
GO
--SP INSERTAR CONTACTO
CREATE procedure SP_INSERTAR_CONTACTO
@id_alumno int = null,
@id_responsable int = null,
@id_tipo_contacto int,
@contacto varchar(100)
AS
BEGIN
	INSERT INTO Contactos (id_alumno, id_responsable, id_tipo_contacto, contacto)
VALUES (@id_alumno, @id_responsable, @id_tipo_contacto, @contacto)

end
GO
--SP OBTENER ID ALUMNO
CREATE PROCEDURE SP_OBTENER_ID_ALUMNO
AS
BEGIN
    SELECT TOP 1 *
    FROM Alumnos
    ORDER BY id_alumno DESC;
END
GO
--SP OBTENER ID RESPONSABLE
CREATE PROCEDURE SP_OBTENER_ID_RESPONSABLE
AS
BEGIN
    SELECT TOP 1 *
    FROM Responsables
    ORDER BY id_responsable DESC;
END
GO
--SP CARGAR COMBO MEDIDA
CREATE PROCEDURE SP_CARGAR_COMBO_MEDIDAS
AS
BEGIN
	SELECT * FROM Medidas
END
GO
--SP CARGAR COMBO MARCAS
CREATE PROCEDURE SP_CARGAR_COMBO_MARCAS
AS
BEGIN
	SELECT * FROM Marcas
END
GO

--SP LISTAR ALUMNOS 
CREATE PROCEDURE SP_LISTAR_ALUMNOS
AS
BEGIN
    SELECT * FROM Alumnos
END
GO

--SP INSERTAR RESPONSABLE
GO
CREATE PROCEDURE [dbo].[SP_CARGAR_RESPONSABLE]
@nombre varchar(50),
@apellido varchar(50),
@dni int,
@calle varchar(50),
@altura varchar(50),
@id_ciudad int,
@observaciones varchar(150),
--parametros particulares de responsables
@id_tipo_responsable int
AS
BEGIN
INSERT INTO Responsables(nombre,apellido,dni, calle, altura,id_ciudad, fec_alta, id_tipo_responsable, observaciones)
VALUES(@nombre,@apellido,@dni,@calle,@altura,@id_ciudad,getdate(),@id_tipo_responsable,@observaciones)
END



--SP INSERTAR VIOLIN
CREATE PROCEDURE SP_CARGAR_VIOLIN
	@modelo varchar(50),
	@id_medida int,
	@id_marca int,
	@precio money,
	@id_alumno int = null
AS 
BEGIN
	INSERT INTO Violines(modelo,id_medida,id_marca,precio,id_alumno)
	VALUES (@modelo,@id_medida,@id_marca,@precio,@id_alumno)
END
go
--SP LISTAR RESPONSABLE
CREATE PROCEDURE SP_LISTAR_RESPONSABLES
AS
BEGIN
    select r.id_responsable, r.nombre, r.apellido,T.tipo_responsable, r.id_tipo_responsable 
    from Responsables r, Tipo_Responsable T
    WHERE R.id_tipo_responsable = T.id_tipo_responsable
END
GO
--SP CONSULTAR ULTIMO ID PROGRESO
CREATE PROCEDURE SP_ULTIMO_ID_PROGRESO
AS
BEGIN
	    SELECT TOP 1 *
    FROM Progresos
    ORDER BY id_responsable DESC;	
END
GO
-- SP INSERTAR MAESTRO
CREATE PROCEDURE SP_INSERTAR_MAESTRO
@idAlumno int,
@idResponsable int=null,
@progresoNro int OUTPUT
AS
BEGIN
	INSERT INTO Progresos(fecha, id_alumno, id_responsable)
	VALUES(GETDATE(),@idAlumno, @idResponsable)
	SET @progresoNro = SCOPE_IDENTITY()
END
GO
-- SP INSERTAR DETALLE
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@progresoNro int,
	@detalle int, 
	@idCancion int, 
	@observaciones varchar(150)
AS
BEGIN
	INSERT INTO Detalles_Progreso(id_progreso, id_detalle_progreso,id_cancion, observaciones)
    VALUES (@progresoNro, @detalle, @idCancion, @observaciones);
END
GO
--SP CARGAR COMBO LIBRO
CREATE PROCEDURE SP_CARGAR_COMBO_LIBROS
AS
BEGIN
	SELECT * FROM Libros_Suzuki
END
GO
--SP CARGAR COMBO CANCION
CREATE PROCEDURE SP_CARGAR_COMBO_CANCION
@idLibro int
AS
BEGIN
	SELECT * FROM Canciones
	WHERE id_libro = @idLibro
END
GO
--VISTA PARA SP CONSULTAR ALUMNOS
CREATE VIEW V_CONSULTAR_ALUMNOS
AS
SELECT A.id_alumno as ID, A.nombre+ ' '+ A.apellido as Nombre, dni as DNI, A.calle+ ' ' + A.altura as DIRECCION, C.ciudad as CIUDAD, A.fec_nac as FECHA_DE_NACIMIENTO, A.colegio as COLEGIO,(SELECT contacto from Contactos con where con.id_alumno = a.id_alumno and con.id_tipo_contacto=1) as TELEFONO,(SELECT contacto from Contactos con where con.id_alumno = a.id_alumno and con.id_tipo_contacto=2) as EMAIL,A.observaciones as OBSERVACIONES, A.fec_alta as FECHA_DE_ALTA
	FROM ALUMNOS A, CIUDADES C
	WHERE C.id_ciudad = A.id_ciudad
--SP CONSULTAR ALUMNOS
CREATE PROCEDURE SP_CONSULTAR_ALUMNOS
AS
BEGIN
	SELECT * FROM V_CONSULTAR_ALUMNOS
END
GO
--VISTA PARA SP CONSULTAR RESPONSABLES
CREATE VIEW V_CONSULTAR_RESPONSABLES
AS
SELECT R.id_responsable as ID,  R.nombre+ ' '+ R.apellido as Nombre,R.dni as DNI ,R.calle+ ' ' + R.altura as DIRECCION,C.ciudad as CIUDAD, (SELECT contacto from Contactos con where con.id_responsable= R.id_responsable and con.id_tipo_contacto=1) as TELEFONO,(SELECT contacto from Contactos con where con.id_responsable = R.id_responsable and con.id_tipo_contacto=2) as EMAIL,R.observaciones as OBSERVACIONES, R.fec_alta as FECHA_DE_ALTA
FROM Responsables R, Ciudades C
WHERE R.id_ciudad = C.id_ciudad
--SP CONSULTAR RESPONSABLES
CREATE PROCEDURE SP_CONSULTAR_RESPONSABLES
AS
BEGIN
	SELECT * FROM V_CONSULTAR_RESPONSABLES
END
GO
--VISTA PARA SP CONSULTAR VIOLINES
CREATE VIEW V_CONSULTAR_VIOLINES
AS
SELECT V.id_violin AS ID, M.medida AS MEDIDA, MA.marca AS MARCA, V.precio AS PRECIO, A.nombre+ ' ' + A.apellido AS 'PERTENECE A:'
FROM Violines V, Medidas M, Marcas MA, Alumnos A
WHERE V.id_alumno = A.id_alumno
AND V.id_medida = M.id_medida
AND V.id_marca = MA.id_marca
--SP CONSULTAR VIOLINES
CREATE PROCEDURE SP_CONSULTAR_VIOLINES
AS
BEGIN
	SELECT * FROM V_CONSULTAR_VIOLINES
END
GO





