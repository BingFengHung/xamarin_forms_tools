using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsTools
{
    // RoutingEffect 會去套用指定平台的 Effect
    class FocusEffect : RoutingEffect
    {
        public FocusEffect() : base($"MyCompany.{nameof(FocusEffect)}")
        {
        }

    }
}
