using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]
public class InController : Controller{
    [HttpGet("listar-casa-imo")]
    public IActionResult ListarCasaImo([FromQuery] string tipo, [FromQuery]List<string> agencia){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.In(x => x.Agencia,agencia);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-casa-patio")]
    public IActionResult ListarCasaPatio([FromQuery] string tipo, [FromQuery]List<bool> patio){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.In(x => x.TienePatio,patio);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-casa-fecha")]
    public IActionResult ListarCasaFecha([FromQuery] string tipo, [FromQuery]List<string> fecha){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.In(x => x.FechaPublicacion,fecha);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-terreno-renta")]
    public IActionResult ListarTerrenoRenta([FromQuery] string tipo, [FromQuery]List<string> renta){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.In(x => x.Operacion,renta);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-terreno-agente")]
    public IActionResult ListarTerrenoAgente([FromQuery] string tipo, [FromQuery]List<string> agente){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.In(x => x.NombreAgente,agente);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }    
}