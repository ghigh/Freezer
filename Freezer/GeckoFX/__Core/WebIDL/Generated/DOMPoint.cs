namespace Gecko.WebIDL
{
    using System;
    
    
    internal class DOMPoint : WebIDLBase
    {
        
        public DOMPoint(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double X
        {
            get
            {
                return this.GetProperty<double>("x");
            }
            set
            {
                this.SetProperty("x", value);
            }
        }
        
        public double Y
        {
            get
            {
                return this.GetProperty<double>("y");
            }
            set
            {
                this.SetProperty("y", value);
            }
        }
        
        public double Z
        {
            get
            {
                return this.GetProperty<double>("z");
            }
            set
            {
                this.SetProperty("z", value);
            }
        }
        
        public double W
        {
            get
            {
                return this.GetProperty<double>("w");
            }
            set
            {
                this.SetProperty("w", value);
            }
        }
    }
}
