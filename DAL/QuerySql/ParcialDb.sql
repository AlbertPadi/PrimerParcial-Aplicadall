use ParcialDb

create table Preguntas(
			PreguntaId int identity primary key,
			Fecha varchar(12),
			Descripcion nvarchar(200),
			RespuestasPosibles varchar(500)
)
select *from Preguntas