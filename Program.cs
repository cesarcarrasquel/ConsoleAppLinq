// See https://aka.ms/new-console-template for more information


using System.Linq;

static IEnumerable<string> Personas(){
    yield return "Francisco";
    yield return "Misael";
    yield return "Andres";
    yield return "Pedro";
    yield return "Pablo";
    yield return "Javier";
}

/////////// DOS METODOS PARA CONSULTAS ////////
// Query syntax (Se parece a SQL)
//var personas = (from p in Personas()
//            select p);

// Method syntax (Se parece a expresiones lambda)
var personas = Personas().Select(p => p);


// ejecutar consulta
// debemos recorrer en foreach, o utilizar ToList() o ToArray() 
foreach(var p in personas)
    Console.WriteLine(p);
