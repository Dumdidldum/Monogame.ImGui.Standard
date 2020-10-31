namespace MonoGame.ImGui.Standard
{
    public static class DrawText
    {
        public static void Perform(string text)
        {
            ImGuiNET.ImGui.Text(text);
        }
    }
}
