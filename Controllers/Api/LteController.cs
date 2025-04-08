using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]
public class LteController : Controller{
    [HttpGet("listar-casa-bano")]
    public IActionResult ListarCasaBan(int ba){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Banios,ba);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-terreno-cost")]
    public IActionResult ListarTerenoCost(int cost){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Terreno");
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo,cost);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-piso")]
    public IActionResult ListarCaspiso(int pis){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos,pis);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-metro")]
    public IActionResult ListarCasmetro(int metro){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion,metro);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-patio")]
    public IActionResult ListarCaspatip(bool patio){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.TienePatio,patio);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }
}