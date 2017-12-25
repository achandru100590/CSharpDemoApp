using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Structural.Proxy
{
    public interface IImage
    {
        void DisplayImage();
    }

    public class Image : IImage
    {
        string name;

        public Image(string name)
        {
            this.name = name;
        }

        public void DisplayImage()
        {
            Console.WriteLine("{0} imaged loaded.", name);
        }
    }

    public class ImageProxy : IImage
    {
        string _fileName;
        Image realImage = null;

        public ImageProxy(string fileName)
        {
            this._fileName = fileName;
        }

        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new Image(_fileName);
            }

            realImage.DisplayImage();
        }
    }
}
