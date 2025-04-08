using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller{
    [HttpGet("listar-casa-banos")]
    public IActionResult ListarCasaBans(int bas){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Banios,bas);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-terre-me")]
    public IActionResult ListarTerraria(int terra){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Terreno");
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.MetrosTerrenos,terra);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-basc")]
    public IActionResult ListarBasc(int basc, string tipo){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Banios,basc);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-cosco")]
    public IActionResult ListarCosto(int money, string tipo){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Banios,money);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-norenta")]
    public IActionResult ListarOperacion(string opera, string tipo){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,tipo);
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion,opera);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }
}