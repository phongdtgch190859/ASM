using System;
namespace DanToProject
{
    public class SGBreadStore:BreadStore
    {
        protected override Bread Createbread(string type)
        {
            switch (type)
            {
                case "Mixed":
                    return new SGMixedBread();
                case "Pate":
                    return new SGPateBread();
                case "Garlic":
                    return new SGGarlicBread();
                default:
                    return null;
            }
        }
    }
}