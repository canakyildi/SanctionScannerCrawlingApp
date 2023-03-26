namespace Read_Sahibinden.Service.MyModel;
public class AdvertisementMinModel
{
    public string Price { get; set; }
    public string Title { get; set; }
    public decimal DecimalPrice { get; set; }
    public static string GetStr(List<AdvertisementMinModel> models)
    {
        return  string.Join(",", models.Select(x => $"{nameof(x.Title)} : {x.Title}, {nameof(x.Price)} :{x.Price}"));   
    }
}
