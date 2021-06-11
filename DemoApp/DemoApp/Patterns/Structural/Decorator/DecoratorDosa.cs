using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Decorator
{
    public interface IDosa
    {
        string GetDescription();
        float GetPrice();
    }

    public class PlainDosa : IDosa
    {
        private string description = "Plain Dosa";
        private float price = 25;
        public string GetDescription()
        {
            return string.Format("{0} : Rs. {1}", description, price);
        }

        public float GetPrice()
        {
            return price;
        }
    }

    public abstract class DosaDecorator : IDosa
    {
        protected IDosa _dosaDecorator;

        public DosaDecorator(IDosa dosaDecorator)
        {
            _dosaDecorator = dosaDecorator;
        }

        public abstract string GetDescription();
        public abstract float GetPrice();
    }

    public class PeasSpices : DosaDecorator
    {
        private string description = string.Empty;
        private float price = 10;
        public PeasSpices(IDosa dosaDecorator) : base(dosaDecorator)
        {
            description = _dosaDecorator.GetDescription();
        }

        public override string GetDescription()
        {
            return string.Format("{0}, PeasSpices : Rs. {1}", description, price);
        }

        public override float GetPrice()
        {
            return price + _dosaDecorator.GetPrice();
        }
    }

    public class Onion : DosaDecorator
    {
        private string description = string.Empty;
        private float price = 10;
        public Onion(IDosa dosaDecorator) : base(dosaDecorator)
        {
            description = _dosaDecorator.GetDescription();
        }

        public override string GetDescription()
        { 
            return string.Format("{0}, Onion : Rs. {1}", description, price);
        }

        public override float GetPrice()
        {
            return price + _dosaDecorator.GetPrice();
        }
    }

    public class Ghee : DosaDecorator
    {
        private string description = string.Empty;
        private float price = 15;

        public Ghee(IDosa dosaDecorator) : base(dosaDecorator)
        {
            description = _dosaDecorator.GetDescription();            
        }

        public override string GetDescription()
        {
            return string.Format("{0}, Ghee : Rs. {1}", description, price);
        }

        public override float GetPrice()
        {
            return price + _dosaDecorator.GetPrice();
        }
    }

    public class Powder : DosaDecorator
    {
        private string description = string.Empty;
        private float price = 8;

        public Powder(IDosa dosaDecorator) : base(dosaDecorator)
        {
            description = _dosaDecorator.GetDescription();           
        }

        public override string GetDescription()
        {
            return string.Format("{0}, Powder : Rs. {1}", description, price);
        }

        public override float GetPrice()
        {
            return price + _dosaDecorator.GetPrice();
        }
    }

}
