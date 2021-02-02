using SimpleTrading.SettingsReader;

namespace Service.SomeLogic.Settings
{
    [YamlAttributesOnly]
    public class SettingsModel
    {
        [YamlProperty("SomeLogic.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }
    }
}