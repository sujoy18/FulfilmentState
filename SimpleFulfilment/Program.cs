using System;

namespace SimpleFulfilment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             * Get the current state. If the state is null or policy creating state then 
             * initialize plicy creating state and perform all validate, create. exit. In exit of
             * every successful state, assign the current state to next so that next state can be executed.
             * If any of the execution failed at any state, the save it there
             */
        }
    }
}
