using LouisPhilippeLoeckx_Kort_List.Interfaces;
using System.Text;


namespace LouisPhilippeLoeckx_Kort_List.Models
{
    public class Product : IProduct
    {
        public string Merk { get; set ; }
        public string Naam { get; set; }
        public string Volume { get; set; }

        public string GetCode()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder LiquidAmount = new StringBuilder();

            sb.Append($"{Merk[0]}{Merk[1]}{Merk[2]}");

            sb.Append($"{Naam[0]}{Naam[1]}{Naam[2]}");

            LiquidAmount.Append(Volume.Replace(' ','_'));
            sb.Append(LiquidAmount);



            return sb.ToString();
        }
    }
}
