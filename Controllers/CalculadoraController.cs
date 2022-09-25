using Microsoft.AspNetCore.Mvc;

namespace CalculadoraMvc.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Calcular()
    {
        return View();
    } 
    
    public IActionResult Resultado([FromForm] double num1, [FromForm] double num2, [FromForm] string operacao)
    {
        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.operacao = operacao;
        
        switch(operacao)
        {
            case "+":
                ViewBag.Resultado = num1 + num2;
                break;
        
            case "-": 
                ViewBag.Resultado = num1 - num2;
                break;
            
            case "*":
                ViewBag.Resultado = num1 * num2;
                break;
            
            case "/":
                ViewBag.Resultado = num1 / num2;
                break;

            default:
                ViewBag.Resultado = "Essa operação não existe!";
                break;
        }

        return View();
    }
}