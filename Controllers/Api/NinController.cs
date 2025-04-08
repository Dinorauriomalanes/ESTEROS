using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/nin")]
public class NinController : Controller{
    [HttpGet("listar-casa-patio")]
    public IActionResult ListarCasaPatio([FromQuery] string tipo, [FromQuery]List<bool> patios){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.TienePatio,patios);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

        [HttpGet("listar-casa-agente")]
    public IActionResult ListarCasaAgente([FromQuery] string tipo, [FromQuery]List<string> agente){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente,agente);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

        [HttpGet("listar-terreno-agencia")]
    public IActionResult ListarTerrenoAgencia([FromQuery] string tipo, [FromQuery]List<string> agencia){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Agencia,agencia);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

     [HttpGet("listar-registro-terrenos")]
    public IActionResult ListarRegistroTerrenos([FromQuery] string tipo, [FromQuery]List<string> renta){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion,renta);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-registro-casas")]
    public IActionResult ListarRegistroCasas([FromQuery] string tipo, [FromQuery]List<int> costo){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo,costo);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }
}