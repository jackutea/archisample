using System;

namespace ArchiSample.Models {

    public class StartGameEvent {

        public int chapter;
        public int level;
        
        bool isTrigger;
        public bool IsTrigger => isTrigger;
        public void SetIsTrigger(bool isTrigger) => this.isTrigger = isTrigger;

    }

}