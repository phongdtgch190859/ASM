namespace DanToProject
{
    public class DNBreadStore:BreadStore
    {
        protected override Bread Createbread(string type)
        {
            switch (type)
            {
                case "Mixed":
                    return new DNMixedBread();
                case "Pate":
                    return new DNPateBread();
                case "Garlic":
                    return new DNGarlicBread();
                default:
                    return null;
            }
        }
    }
}