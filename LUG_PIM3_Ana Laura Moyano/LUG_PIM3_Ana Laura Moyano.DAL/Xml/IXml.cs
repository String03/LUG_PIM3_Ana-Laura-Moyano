namespace LUG_PIM3_Ana_Laura_Moyano.DAL.Xml
{
    public interface IXml
    {
        T Deserialize<T>(string xml);
        string Serialize<T>(T o);
    }
}
