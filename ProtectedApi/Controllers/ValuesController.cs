using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        var userInfo = new
        {
            Name = "Patrick M. Padilla",
            Section = "32E3",
            Course = "BSIT",
            FunFacts = new string[]
            {
                "I'm Currently Studying At Lyceum of Alabang",
                "BSIT 3rd Year Student",
                "I'm 21 Years Old",
                "Loves To Play Online Games",
                "Loves To Walk Around",
                "I Also Like Cyling",
                "Eating and Drinking Coffee",
                "Play Billiards With My Friends",
                "I'm Having A Hard Time Doing This Activity",
                "But I'm Glad To Do Something"
            }
        };

        return Ok(userInfo);
    }
}