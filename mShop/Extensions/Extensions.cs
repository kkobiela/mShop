using System.IO;
using System.Runtime.Serialization;

namespace mShop.Extensions
{
    public static class Extensions
    {
        public static products_in_shop DeepCopy(this products_in_shop source)
        {
            var ser = new DataContractSerializer(typeof(products_in_shop));
            using (var stream = new MemoryStream())
            {
                ser.WriteObject(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                return (products_in_shop)ser.ReadObject(stream);
            }
        }
    }
}
