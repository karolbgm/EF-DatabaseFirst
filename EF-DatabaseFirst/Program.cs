using Microsoft.EntityFrameworkCore;

namespace EF_DatabaseFirst;

internal class Program
{
    static void Main(string[] args)
    {
        //create instance of DbContext
        var _context = new TqlprsdbContext();

        //USER
        //Needs: id, username, password, firstname, lastname, isreviewer, isadmin
        //Optional: phone, email

        //create new user
        var user = new User
        {
            Id = 0,
            Username = "km",
            Password = "123",
            Firstname = "Karol",
            Lastname = "Morgan",
            IsReviewer = true,
            IsAdmin = true
        };

        //add new user to Db
        //_context.Add(user);
        //save changes
        //_context.SaveChanges();

        //VENDOR
        //Needs: id, code, name, address, city, state, zip
        //Optional: phone, email

        var vendor = new Vendor
        {
            Id = 0,
            Code = "WM",
            Name = "Walmart",
            Address = "4040 Clepper Ln",
            City = "Cincinnati",
            State = "OH",
            Zip = "45240"
        };

        //_context.Add(vendor);
        //_context.SaveChanges();


        //PRODUCT
        //Needs: id, partnbr, name, price, unit, vendorId
        //Optional: photopath

        var product = new Product
        {
            Id = 0,
            PartNbr = "TOOL",
            Name = "Drill bit set",
            Price = 10,
            Unit = "Each",
            VendorId = 8
        };

        //_context.Add(product);
        //_context.SaveChanges();

        //REQUEST
        //Needs: id, description, justification, deliverymode, status, total, userid
        //Optional: rejectionreason
        var request = new Request
        {
            Id = 0,
            Description = "I need a drill bit set to mount a tv",
            Justification = "I can't mount my tv wihtout it",
            DeliveryMode = "Pickup",
            Status = "NEW",
            UserId = 5
            //UserId = _context.Users.Single(x => x.Username == "km").Id
        };

        //_context.Add(request);
        //_context.SaveChanges();


        //REQUEST LINE
        //Needs: id, quantity, requestid, productid

        var requestLine = new Requestline
        {
            Id = 0,
            Quantity = 2,
            RequestId = 7,
            ProductId = 15
        };

        var requestLine2 = new Requestline
        {
            Id = 0,
            Quantity = 3,
            RequestId = 7,
            ProductId = 15
        };

        //_context.Add(requestLine2);
        //_context.SaveChanges();

        //DELETING
        //var deletedVendor = _context.Vendors.Find(7);
        //_context.Remove(deletedVendor!); //--IT WORKED

        //var deletedRequestline = _context.Requestlines.Find(4);
        //_context.Remove(deletedRequestline!);

        //var deletedRequest = _context.Requests.Find(5);
        //_context.Remove(deletedRequest!);

        //var deletedProduct1 = _context.Products.Find(12);
        //_context.Remove(deletedProduct1!);
        //var deletedProduct2 = _context.Products.Find(13);
        //_context.Remove(deletedProduct2!);
        //var deletedProduct3 = _context.Products.Find(14);
        //_context.Remove(deletedProduct3!);

        //_context.SaveChanges();

    }
}
