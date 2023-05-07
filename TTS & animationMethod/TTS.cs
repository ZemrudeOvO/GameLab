using Godot;
using System;

public partial class TTS : Node2D
{
    public void tts()
    {
        string[] voices = DisplayServer.TtsGetVoicesForLanguage("zh");
        string voidId = voices[0];

        DisplayServer.TtsSpeak("你好，世界", voidId);
    }
}
