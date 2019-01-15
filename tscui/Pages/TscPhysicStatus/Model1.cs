using System;
using Apex.MVVM;

namespace tscui.Pages.TscPhysicStatus
{
    /// <summary>
    /// The <see cref="Model1"/> Model class.
    /// This class implements the <see cref="IModel1"/> Model interface.
    /// You can retrieve the model with:
    /// <code>IModel1 model = ApexBroker.GetModel<IModel1>()</code>
    /// </summary>
    [Model]
    public sealed class Model1 : IModel1, IModel
    {
        /// <summary>
        /// Called by the Apex framework to initialise the model.
        /// </summary>
        public void OnInitialised()
        {
            //  TODO: Initialise the model.
        }
    }
}
