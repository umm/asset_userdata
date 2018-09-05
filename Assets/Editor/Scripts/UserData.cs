using System.Xml.Serialization;

namespace UnityModule.Asset
{
    /// <summary>
    /// AssetImporter.userData に書き込むデータ構造
    /// </summary>
    /// <remarks>本来は各 umm で閉じさせるべき構造体だが、モジュール同士の AssetImporter.userData 上書き合戦を回避するために依存が逆になっている状態を許容する</remarks>
    /// <remarks>これでも umm 以外のアセットによって AssetImporter.userData が上書きされる可能性は残るが、それは管理範疇外とみなす</remarks>
    [XmlRoot("userData")]
    public struct UserData
    {
        [XmlElement("version")] public int Version { get; set; }
    }

}