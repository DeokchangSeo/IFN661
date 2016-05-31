
using System;

namespace MVVMPatern
{
  
    public class MainViewModel 
    {
        
        public MainViewModel(NewProject.Model.Demo demo)
        {
            title = demo.title;
        }
        public string title { get; set; }
       
        public static NewProject.Model.Demo GetDemo()
        {
            var demo = new NewProject.Model.Demo()
            {
                title = "rice growing Advisors"
            };
            return demo;
        }
    }
}