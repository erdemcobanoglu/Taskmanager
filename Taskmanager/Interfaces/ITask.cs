using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ITask
    {
        /// <summary>
        /// Gets the name of task
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the description of the task
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets the current status of the task.
        /// </summary>
        TaskStatus Status { get; }

        /// <summary>
        /// Runs the task
        /// </summary>
        void Run();

        /// <summary>
        /// Cancels the running task if applicable
        /// </summary>
        void Cancel();

        /// <summary>
        /// Sets the trigger for when the task should run automatically.
        /// </summary>
        /// <param name="trigger">The trigger object defining the schedule.</param>
        void SetTrigger(ITrigger trigger);


        public interface ITrigger
        {
            // Define properties and method 
        }

    }
}
