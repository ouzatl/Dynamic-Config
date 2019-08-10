using ProtoBuf;

namespace Dynamic.Config.Data.Model
{
    [ProtoContract]
    public class Configuration
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public string Type { get; set; }

        [ProtoMember(4)]
        public object Value { get; set; }

        [ProtoMember(5)]
        public bool IsActive { get; set; }

        [ProtoMember(6)]
        public string ApplicationName { get; set; }
    }
}