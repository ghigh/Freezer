namespace Gecko.WebIDL
{
    using System;
    
    
    internal class OfflineAudioContext : WebIDLBase
    {
        
        public OfflineAudioContext(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > StartRendering()
        {
            return this.CallMethod<Promise < nsISupports >>("startRendering");
        }
    }
}
