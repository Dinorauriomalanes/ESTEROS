using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-terreno")]
    public IActionResult ListarTerrenos(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Terreno");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-operacion-renta")]
    public IActionResult ListarOperacionRenta(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion,"Renta");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-nombre-agente")]
    public IActionResult ListarNombreAgente(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente,"Ana Torres");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-agencia")]
    public IActionResult ListarAgencia(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia,"García Propiedades");
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-casa-banio")]
    public IActionResult ListarCasaBanio(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtrobanio = Builders<Inmueble>.Filter.Eq(x => x.Banios,0);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtrobanio);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}

