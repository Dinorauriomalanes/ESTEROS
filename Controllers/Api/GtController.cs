using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api-eq")]
public class GtController : Controller{
    [HttpGet("listar-casa-construccion")]
    public IActionResult ListarCasaConstruccion(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentaVenta");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtroCons = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion,100);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtroCons);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-casa-banio")]
    public IActionResult ListarCasaBanio(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentaVenta");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtroBa = Builders<Inmueble>.Filter.Gt(x => x.Banios,0);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtroBa);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-metro-terreno")]
    public IActionResult ListarMetrosTerrenos(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentaVenta");
        var filtroTerreno = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerrenos,500);

        var lista = collection.Find(filtroTerreno).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-casa-pisos")]
    public IActionResult ListarCasaPisos(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentaVenta");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtroPisos = Builders<Inmueble>.Filter.Gt(x => x.Pisos,1);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtroPisos);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-terreno-costo")]
    public IActionResult ListarTerrenoCosto(){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentaVenta");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Terreno");
        var filtroCosto = Builders<Inmueble>.Filter.Gt(x => x.Costo,100000);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtro, filtroCosto);
        var lista = collection.Find(filtro).ToList();
        return Ok(lista);
    }
}