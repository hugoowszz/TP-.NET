using _12.Models;
using _12.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _12.Pages;

public class Cadastrar : PageModel
{
    private readonly EventService _eventService;
    
    [BindProperty]
    public Event NewEvent { get; set; }

    public Cadastrar(EventService eventService)
    {
        _eventService = eventService;
        
        _eventService.OnEventCreated += (e) => Console.WriteLine("Evento criado: " + e.titulo + " em: " + e.data + "no local: " + e.local); 
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        else
        {
            _eventService.add(NewEvent);
            return RedirectToPage("Index");
        }
    }
    
    public void OnGet()
    {
        
    }
}
