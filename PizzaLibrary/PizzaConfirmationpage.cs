using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibrary
{
    public class PizzaConfirmationpage
    {
        static List<PizzaSelectionpage> listPizzaSelectionpages = new List<PizzaSelectionpage>()
        {

          new PizzaSelectionpage()

          {
            Cid=1,Typeofpizza="BurgerPizza",Quantity=340,Amount=56000,Price=45
          },
          new PizzaSelectionpage()
          {
            Cid=2,Typeofpizza="ChickenPizza",Quantity=540,Amount=86000,Price=56
          },
          new PizzaSelectionpage()
          {
            Cid=3,Typeofpizza="BurgerPizza",Quantity=786,Amount=46000,Price=76
          },
          new PizzaSelectionpage()
          {
            Cid=4,Typeofpizza="AmletPizza",Quantity=340,Amount=26000,Price=78
          },
          new PizzaSelectionpage()
          {
            Cid=5,Typeofpizza="BurgerPizza",Quantity=440,Amount=34000,Price=89
          },
        };
        

        public List<PizzaSelectionpage> AllPizzas()
        {
            return listPizzaSelectionpages;
        }
        public List<PizzaSelectionpage> SelectionPizza(int cid)
        {
            List<PizzaSelectionpage> searchList = listPizzaSelectionpages.FindAll(e => e.Cid == cid);
            return searchList;

        }


    }
}
