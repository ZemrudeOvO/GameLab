using Godot;
using System;

public partial class Keyboard : Label
{
    int cout = 0;

    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventKey inputEventKey && inputEventKey.IsPressed())
        {
            cout++;
            this.Text = cout.ToString();
        }
    }
}
