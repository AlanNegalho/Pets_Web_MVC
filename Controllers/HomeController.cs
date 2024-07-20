using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pets_Web_MVC.Models;

namespace Pets_Web_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira",
                "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");

        Cliente cliente2 = new Cliente(02, "João da Silva",
                "857.032.950-41", "Joao.dev@gmail.com", "Bidu");

        Cliente cliente3 = new Cliente(03, "Maria Castro da Silva",
                "857.032.950-41", "mariasilva@outlook.com", "Rex");

        Cliente cliente4 = new Cliente(04, "José de Oliveira",
                "857.032.950-41", "jose@sp.senai.br", "jó");

        Cliente cliente5 = new Cliente(05, "Ana Barreto",
                "857.032.950-41", "anabarreto@psque.com", "Luna");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;


        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A",
                "14.182.102/0001-80", "c-sharp@pet.org", "(11) 4002-8922");

        Fornecedor fornecedor2 = new Fornecedor(02, "Java Pets Ltda",
                "11.123.456/0001-99", "java@pets.com", "(21) 5555-1234");

        Fornecedor fornecedor3 = new Fornecedor(03, "Python Paws Co.",
                "22.987.654/0001-88", "python@paws.org", "(31) 9999-5678");

        Fornecedor fornecedor4 = new Fornecedor(04, "Ruby Tails LLC",
                "33.876.543/0001-77", "ruby@tails.net", "(41) 8888-4321");

        Fornecedor fornecedor5 = new Fornecedor(05, "JavaScript Fins Inc.",
                "44.765.432/0001-66", "js@fins.org", "(51) 7777-8765");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();

    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
