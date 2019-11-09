using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace XamlBrewer.Uwp.ItemsRepeater.Sample
{
    public class ImageCompress : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return "https://www.viu.com/ott/hk/v1/imgprocess/reduceImage.php?p=50&img=" + value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
