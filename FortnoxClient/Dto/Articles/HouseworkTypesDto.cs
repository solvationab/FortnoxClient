using System.Runtime.Serialization;

namespace FortnoxClient.Dto.Articles
{
    public enum HouseworkTypesDto
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

        [EnumMember(Value = "HVAC")]
        Hvac,

        [EnumMember(Value = "CLEANING")]
        Cleaning,

        [EnumMember(Value = "TEXTILECLOTHING")]
        TextileClothing,

        [EnumMember(Value = "COOKING")]
        Cooking,

        [EnumMember(Value = "SNOWPLOWING")]
        SnowPlowing,

        [EnumMember(Value = "GARDENING")]
        Gardening,

        [EnumMember(Value = "BABYSITTING")]
        Babysitting,

        [EnumMember(Value = "OTHERCARE")]
        OtherCare,

        [EnumMember(Value = "TUTORING")]
        Tutoring,

        [EnumMember(Value = "OTHERCOSTS")]
        OtherCosts
    }
}