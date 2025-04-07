using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]
public class LtController : Controller{
    [HttpGet("listar-casa-piso")]
    public IActionResult ListarCasaPisos(int piso){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos,piso);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

    [HttpGet("listar-terreno-metro")]
    public IActionResult ListarTerrenosMetros(int metro){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Terreno");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerrenos,metro);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }

     [HttpGet("listar-casa-banio")]
    public IActionResult ListarCasaBanio(int banio){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Banios,banio);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }    

    [HttpGet("listar-casa-cons")]
    public IActionResult ListarCasaCons(int cons){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Casa");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion,cons);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }  

    [HttpGet("listar-terreno-costo")]
    public IActionResult ListarTerrenoCosto(int costo){
        //listar todos los terrenos
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroCas = Builders<Inmueble>.Filter.Eq(x => x.Tipo,"Terreno");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo,costo);

        var filtrocompuesto = Builders<Inmueble>.Filter.And(filtroCas, filtro);
        var lista = collection.Find(filtrocompuesto).ToList();
        return Ok(lista);
    }  
}
