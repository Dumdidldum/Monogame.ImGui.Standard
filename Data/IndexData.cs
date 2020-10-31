using Microsoft.Xna.Framework.Graphics;

namespace MonoGame.ImGui.Standard.Data
{
    /// <summary>
    /// Contains information regarding the index buffer used by the GUIRenderer.
    /// </summary>
    public class IndexData
    {
        public byte[] Data;
        public int BufferSize;
        public IndexBuffer Buffer;
    }
}
