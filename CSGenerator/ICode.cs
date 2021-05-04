using System.Text;

namespace CSGenerator
{
    public interface ICode
    {
        int indentCount { get; }// => parent.startIndentCount + 1;
        bool useIndent { get; }// parent.useIndent;
    }
}