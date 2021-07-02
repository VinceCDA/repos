using System;

namespace ModelSyntax
{
    class Program
    {
        private event EventHandler Event;

        static void Main(string[] args)
        {
            Trigger(EventArgs.Empty);
            Event += Action;
        }
        

        protected virtual void Trigger(EventArgs e)
        {
            if (Event != null)
            {
                Event(this, EventArgs.Empty);
            }

        }
        private void Action(object sender, EventArgs e)
        {

        }
    }
        
       
    

    


        
    
    
    
}
    

