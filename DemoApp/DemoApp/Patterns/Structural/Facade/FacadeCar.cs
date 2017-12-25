using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Structural.Facade
{
    public class Model
    {
        string _model;
        public Model(string model)
        {
            this._model = model;
        }

        public void CreateModel()
        {
            Console.WriteLine("Car Model : {0}", this._model);
        }
    }
    public class Engine
    {
        string _engine;

        public Engine(string engine)
        {
            this._engine = engine;
        }

        public void CreateEngine()
        {
            Console.WriteLine("Care Egine : {0}", _engine);
        }
    }
    public class Body
    {
        string _body;
        public Body(string body)
        {
            this._body = body;
        }

        public void CreateBody()
        {
            Console.WriteLine("Car Body : {0}", _body);
        }
    }
    public class Accessories
    {
        string _accessories;
        public Accessories(string accessories)
        {
            this._accessories = accessories;
        }

        public void CreateAccessories()
        {
            Console.WriteLine("Care Accessories : {0}", _accessories);
        }
    }
    public class CarFacade
    {
        Model _model = null;
        Engine _engine = null;
        Body _body = null;
        Accessories _accessories = null;

        public CarFacade()
        {
        }

        public CarFacade(Model model, Engine engine, Body body, Accessories accessories)
        {
            _model = model;
            _engine = engine;
            _body = body;
            _accessories = accessories;
        }

        public void MakeCar()
        {
            _model.CreateModel();
            _body.CreateBody();
            _engine.CreateEngine();
            _accessories.CreateAccessories();
        }
    }
}
