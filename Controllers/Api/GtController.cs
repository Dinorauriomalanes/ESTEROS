using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller{
    [HttpGet("listar-casa-construccion")]
    public IActionResult ListarCasaConstruccion(int metrosConstruccion){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtroCons = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion,metrosConstruccion);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtroCons);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-casa-banio1")]
    public IActionResult ListarCasaBanio1(int banios){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtroBa = Builders<Inmueble>.Filter.Gt(x => x.Banios,banios);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtroBa);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-metro-terreno")]
    public IActionResult ListarMetrosTerrenos(int metrosTerrenos){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtroTerreno = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerrenos,metrosTerrenos);

        var lista = collection.Find(filtroTerreno).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-casa-pisos")]
    public IActionResult ListarCasaPisos(int pisos){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtroPisos = Builders<Inmueble>.Filter.Gt(x => x.Pisos,pisos);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtroPisos);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-terreno-costo")]
    public IActionResult ListarTerrenoCosto(int costo){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Terreno");
        var filtroCosto = Builders<Inmueble>.Filter.Gt(x => x.Costo,costo);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtroCosto);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}