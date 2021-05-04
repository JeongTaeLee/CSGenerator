using System.Text;

namespace CSGenerator
{
    public interface IChildCode : ICode
    {
        ICode parent { get; }

        void WriteCode(StringBuilder strBldr);
    }
}