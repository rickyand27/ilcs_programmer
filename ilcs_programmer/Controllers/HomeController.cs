using Microsoft.AspNetCore.Mvc;

namespace ilcs_programmer.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ILCSController : ControllerBase
    {
        [HttpGet("Form")]
        public IActionResult GetExample(
            [FromQuery] string Negara,
            [FromQuery] string Pelabuhan,
            [FromQuery] string Barang,
            [FromQuery] double Harga,
            [FromQuery] double TarifBeaMasuk)
        {
            var totalBiaya = TarifBeaMasuk / 100 * Harga;

            var result = new List<string>
            {
                $"Negara : {Negara}",
                $"Pelabuhan : {Pelabuhan}",
                $"Barang : {Barang}",
                $"Detail Barang {Barang} berupa seperti yang disebutkan",
                $"Harga : {Harga}",
                $"Tarif Bea Masuk : {TarifBeaMasuk}",
                $"Total Biaya : {totalBiaya}"

            };
            return Ok(result);
        }
    }

}
