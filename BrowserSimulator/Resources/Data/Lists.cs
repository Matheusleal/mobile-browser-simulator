using BrowserSimulator.Resources.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator.Resources.Data
{
    public static class Lists
    {
        #region [Props]
        private static List<PhoneType> PhoneTypeList { get; set; } = new();

        #endregion

        #region [Props Data]
        public static List<PhoneType> GetPhoneTypes()
        {
            if (PhoneTypeList.Count > 0) return PhoneTypeList;

            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Apple", Model = "iPhone 5", Resolution = { Width = 640, Height = 1136 }, ViewPort = { Width = 320, Height = 568 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Apple", Model = "iPhone 6/6S/7/8", Resolution = { Width = 750, Height = 1334 }, ViewPort = { Width = 375, Height = 667 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Apple", Model = "iPhone XR", Resolution = { Width = 828, Height = 1792 }, ViewPort = { Width = 414, Height = 896 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Apple", Model = "iPhone Plus 6/6S/7/8", Resolution = { Width = 1080, Height = 1920 }, ViewPort = { Width = 414, Height = 736 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Apple", Model = "iPhone X/SX", Resolution = { Width = 1125, Height = 2436 }, ViewPort = { Width = 375, Height = 812 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Apple", Model = "iPhone XS Max", Resolution = { Width = 1242, Height = 2688 }, ViewPort = { Width = 414, Height = 896 } });
            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Apple", Model = "iPad Mini", Resolution = { Width = 768, Height = 1024 }, ViewPort = { Width = 768, Height = 1024 } });
            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Apple", Model = "iPad 3/4 & Air 1/2 & Mini 2/3", Resolution = { Width = 1536, Height = 2048 }, ViewPort = { Width = 768, Height = 1024 } });
            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Apple", Model = "iPad Pro", Resolution = { Width = 2048, Height = 2732 }, ViewPort = { Width = 1024, Height = 1366 } });

            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel", Resolution = { Width = 1080, Height = 1920 }, ViewPort = { Width = 412, Height = 732 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel 3 XL", Resolution = { Width = 1080, Height = 2160 }, ViewPort = { Width = 412, Height = 824 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel 3", Resolution = { Width = 1080, Height = 2220 }, ViewPort = { Width = 412, Height = 846 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel 4", Resolution = { Width = 1080, Height = 2280 }, ViewPort = { Width = 412, Height = 869 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel 3", Resolution = { Width = 1080, Height = 2160 }, ViewPort = { Width = 412, Height = 824 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel 4 XL", Resolution = { Width = 1440, Height = 869 }, ViewPort = { Width = 412, Height = 869 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = "Nexus 5X", Resolution = { Width = 1080, Height = 1920 }, ViewPort = { Width = 412, Height = 732 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = "Nexus 6P", Resolution = { Width = 1440, Height = 2560 }, ViewPort = { Width = 412, Height = 732 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel XL", Resolution = { Width = 1440, Height = 2560 }, ViewPort = { Width = 412, Height = 732 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Google", Model = " Pixel 2 XL/3 XL", Resolution = { Width = 1440, Height = 2560 }, ViewPort = { Width = 412, Height = 732 } });

            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Samsung", Model = " Galaxy S7/S7 Edge", Resolution = { Width = 1440, Height = 2560 }, ViewPort = { Width = 360, Height = 640 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Samsung", Model = " Galaxy Note 5/9", Resolution = { Width = 1440, Height = 2960 }, ViewPort = { Width = 360, Height = 740 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Samsung", Model = " Galaxy S8/S8+/S9/S9+", Resolution = { Width = 1440, Height = 2960 }, ViewPort = { Width = 360, Height = 740 }, IsDefault = true });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Samsung", Model = " Galaxy Note 10", Resolution = { Width = 1080, Height = 2280 }, ViewPort = { Width = 412, Height = 869 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "Samsung", Model = " Galaxy Note 10+", Resolution = { Width = 1440, Height = 3040 }, ViewPort = { Width = 412, Height = 869 } });


            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "LG", Model = "G5", Resolution = { Width = 1440, Height = 2560 }, ViewPort = { Width = 480, Height = 853 } });
            PhoneTypeList.Add(new PhoneType { Type = "Phone", Brand = "One Plus", Model = "One Plus 3", Resolution = { Width = 1080, Height = 1920 }, ViewPort = { Width = 480, Height = 853 } });

            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Google", Model = "Nexus 7 (2013)", Resolution = { Width = 1200, Height = 1920 }, ViewPort = { Width = 600, Height = 960 } });
            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Google", Model = "Nexus 9", Resolution = { Width = 1536, Height = 2048 }, ViewPort = { Width = 768, Height = 1024 } });
            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Google", Model = "Pixel C", Resolution = { Width = 1800, Height = 2560 }, ViewPort = { Width = 900, Height = 1280 } });
            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Google", Model = "Chromebook Pixel", Resolution = { Width = 2560, Height = 1700 }, ViewPort = { Width = 1280, Height = 850 } });
            PhoneTypeList.Add(new PhoneType { Type = "Tablet", Brand = "Samsung", Model = "Galaxy Tab 10", Resolution = { Width = 800, Height = 1280 }, ViewPort = { Width = 800, Height = 1280 } });

            return PhoneTypeList;
        }
        #endregion
    }
}
