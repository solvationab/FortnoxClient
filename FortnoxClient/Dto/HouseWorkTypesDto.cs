using System.Runtime.Serialization;

namespace FortnoxClient.Dto
{
    public enum HouseWorkTypesDto
    {
        [EnumMember(Value = "CONSTRUCTION")]
        Construction,

        [EnumMember(Value = "ELECTRICITY")]
        Electricity,

        [EnumMember(Value = "GLASSMETALWORK")]
        GlassMetalWork,

        [EnumMember(Value = "GROUNDDRAINAGEWORK")]
        GroundDrainageWork,

        [EnumMember(Value = "MASONRY")]
        Masonry,

        [EnumMember(Value = "PAINTINGWALLPAPERING")]
        PaintingWallpapering,

        [EnumMember(Value = "MOVINGSERVICES")]
        MovingServices,

        [EnumMember(Value = "ITSERVICES")]
        ItServices,

        [EnumMember(Value = "CLEANING")]
        Cleaning,

        [EnumMember(Value = "TEXTILECLOTHING")]
        TextileClothing,

        [EnumMember(Value = "SNOWPLOWING")]
        SnowPlowing,

        [EnumMember(Value = "GARDENING")]
        Gardening,

        [EnumMember(Value = "BABYSITTING")]
        BabySitting,

        [EnumMember(Value = "OTHERCARE")]
        OtherCare,

        [EnumMember(Value = "OTHERCOSTS")]
        OtherCosts
    }
}