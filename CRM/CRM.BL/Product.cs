using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.BL
{
public class Product
{
public Product()
{

}
public Product(int productID)
{
    ProductID = productID;
}
public int ProductID { get; set; }
public string ProductName { get; set; }
public string Description { get; set; }                                                 
public decimal CurrentPrice { get; set; }
public bool Validate()
{
    var isValid = true;
    if (string.IsNullOrWhiteSpace(ProductName))
    {
        isValid = false;
    }
    return isValid;
}
    public Product Retrieve(int productId)
    {
        return new Product();
    }
    public List<Product> Retrieve()
    {
        return new List<Product>();
    }
    public bool Save()
    {

    return true;
    }
   
}
   
}
