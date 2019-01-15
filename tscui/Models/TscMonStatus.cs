using System;
using Apex.MVVM;

namespace tscui.Models
{
    /// <summary>
    /// The <see cref="TscMonStatus"/> Model class.
    /// This class implements the <see cref="ITscMonStatus"/> Model interface.
    /// You can retrieve the model with:
    /// <code>ITscMonStatus model = ApexBroker.GetModel<ITscMonStatus>()</code>
    /// </summary>
    [Model]
    public sealed class TscMonStatus : ITscMonStatus, IModel
    {
        /// <summary>
        /// Called by the Apex framework to initialise the model.
        /// </summary>
        public void OnInitialised()
        {
            //  TODO: Initialise the model.
        }
        private static byte _StrongVoltage;

        public static byte StrongVoltage
        {
            get { return _StrongVoltage; }
            set { _StrongVoltage = value; }
        }

        public static byte WeakVoltage { get; set; }
        public static byte BusVoltage { get; set; }
        public static byte FrontDoor { get; set; }
        public static byte BackDoor { get; set; }
        public static byte LocalLight { get; set; }
        public static byte LocalAlarm { get; set; }
        public static byte Humidity { get; set; }
        public static byte Temperature { get; set; }

        public static byte RemoteExport1 { get; set; }
        public static byte RemoteExport2 { get; set; }
        public static byte RemoteInput1 { get; set; }
        public static byte RemoteInput2 { get; set; }

        public static byte Heater { get; set; }
        public static byte Radiator { get; set; }

        public static byte MachineVibration { get; set; }
        public static byte PSC { get; set; }

        public static bool bTscMonStatus { get; set; }
        public static bool resportTscStatusFlag { get; set; }

        }
    }

