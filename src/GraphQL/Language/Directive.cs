namespace GraphQL.Language
{
    public class Directive : AbstractNode
    {
        public string Name { get; set; }

        public Arguments Arguments { get; set; }

        public override string ToString()
        {
            return "Directive{{name='{0}',arguments={1}}}".ToFormat(Name, Arguments);
        }

        protected bool Equals(Directive other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool IsEqualTo(INode obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Directive) obj);
        }
    }
}
