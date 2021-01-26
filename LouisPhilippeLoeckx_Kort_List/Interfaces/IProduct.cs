

namespace LouisPhilippeLoeckx_Kort_List.Interfaces
{
    interface IProduct
    {
        string Merk { get; set; }
        string Naam { get; set; }
        string Volume { get; set; }
        string GetCode();
    }
}
