using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ussd.Dial.RNUssdDial
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNUssdDialModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNUssdDialModule"/>.
        /// </summary>
        internal RNUssdDialModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNUssdDial";
            }
        }
    }
}
