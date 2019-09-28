using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ItemClass
    {
        List<ItemClass> Ilist = new List<ItemClass>();
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int ItemNumber { get; set; }


        public void SetDetails()
        {

            Ilist.Add(new ItemClass() { Name = "Sugar", Brand = "kg", Price =85, Quantity =25, Discount =2,ItemNumber=1});
            Ilist.Add(new ItemClass() { Name = "Noodles", Brand = "piece", Price =20, Quantity =45, Discount =1,ItemNumber=2});
            Ilist.Add(new ItemClass() { Name = "Salt", Brand = "kg", Price =20, Quantity =30, Discount =2, ItemNumber = 3 });
            Ilist.Add(new ItemClass() { Name = "Tea", Brand = "piece", Price =100, Quantity =50, Discount =3, ItemNumber = 4 });
            Ilist.Add(new ItemClass() { Name = "Puffrice", Brand = "piece", Price =30, Quantity =100, Discount =3, ItemNumber = 19 });
            Ilist.Add(new ItemClass() { Name = "Chocofun", Brand = "piece", Price =5, Quantity =55, Discount =1, ItemNumber = 5 });
            Ilist.Add(new ItemClass() { Name = "Copy", Brand = "piece", Price =50, Quantity =120, Discount =5, ItemNumber = 6 });
            Ilist.Add(new ItemClass() { Name = "Gluestick", Brand = "piece", Price =35, Quantity =15, Discount =5, ItemNumber = 7 });
            Ilist.Add(new ItemClass() { Name = "Geometry", Brand = "piece", Price =120, Quantity =130, Discount =5, ItemNumber = 8 });
            Ilist.Add(new ItemClass() { Name = "Pencil", Brand = "piece", Price =10, Quantity =250, Discount =5, ItemNumber = 9 });
            Ilist.Add(new ItemClass() { Name = "Pen", Brand = "piece", Price =15, Quantity =250, Discount =5, ItemNumber = 10 });
            Ilist.Add(new ItemClass() { Name = "Rice", Brand = "kg", Price =65, Quantity =50, Discount =4, ItemNumber = 11 });
            Ilist.Add(new ItemClass() { Name = "Dal", Brand = "kg", Price =110, Quantity =55, Discount =4, ItemNumber = 12 });
            Ilist.Add(new ItemClass() { Name = "Vasaline", Brand = "piece", Price =250, Quantity =35, Discount =5, ItemNumber = 13 });
            Ilist.Add(new ItemClass() { Name = "Lip Balm", Brand = "piece", Price =50, Quantity =38, Discount =2, ItemNumber = 14 });
            Ilist.Add(new ItemClass() { Name = "Soap", Brand = "piece", Price =32, Quantity =465, Discount =3, ItemNumber = 15 });
            Ilist.Add(new ItemClass() { Name = "Poatato", Brand = "kg", Price =65, Quantity =95, Discount =3,ItemNumber = 16 });
            Ilist.Add(new ItemClass() { Name = "Onion", Brand = "kg", Price =150, Quantity =65, Discount =4, ItemNumber = 17 });
            Ilist.Add(new ItemClass() { Name = "Washer", Brand = "piece", Price =45, Quantity =23, Discount =5, ItemNumber = 18 });
            
        }
        public List<ItemClass> Details()
        {
            return Ilist.ToList();
        }
    }
}
