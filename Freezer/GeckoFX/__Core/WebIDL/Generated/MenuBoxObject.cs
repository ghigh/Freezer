namespace Gecko.WebIDL
{
    using System;
    
    
    internal class MenuBoxObject : WebIDLBase
    {
        
        public MenuBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsIDOMElement ActiveChild
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("activeChild");
            }
            set
            {
                this.SetProperty("activeChild", value);
            }
        }
        
        public bool OpenedWithKey
        {
            get
            {
                return this.GetProperty<bool>("openedWithKey");
            }
        }
        
        public void OpenMenu(bool openFlag)
        {
            this.CallVoidMethod("openMenu", openFlag);
        }
        
        public bool HandleKeyPress(nsISupports keyEvent)
        {
            return this.CallMethod<bool>("handleKeyPress", keyEvent);
        }
    }
}
