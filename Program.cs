using MinimalAPIPeliculas.Entidades;

var builder = WebApplication.CreateBuilder(args);
// Inicio de area de servicios (Inyeccion de dependencias)


// Fin de area de servicios
var app = builder.Build();
// Inicio de area de los middleware


app.MapGet("/", () => "Hola mundo!");


app.MapGet("/generos", () =>
{
    var generos = new List<Genero>
    {
        new Genero
        {
            Id = 1,
            Nombre = "Drama"
        },
        new Genero
        {
            Id = 2,
            Nombre = "Acción"
        },
        new Genero
        {
            Id = 2,
            Nombre = "Comedia"
        },
    };
    return generos;
});

// Fin de area de los middleware
app.Run();