namespace DanToProject
{
    public class HueBreadStore:BreadStore
    {
        protected override Bread Createbread(string type)
        {
            switch (type)
            {
                case "Mixed":
                    return new HueMixedBread();
                case "Pate":
                    return new HuePateBread();
                case "Garlic":
                    return new HueGarlicBread();
                default:
                    return null;
            }
        }
    }
}