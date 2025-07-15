namespace My.Home.Work.Oop.Positioning;

public class RendererPlayerProperties //ДЗ: Работа со свойствами
{
    public void DrawPlayerProperties(PlayerProperties playerProperties)
    {
        Console.WriteLine($"Игрок находится по координатах: X = {playerProperties.X}, Y = {playerProperties.Y}" );
    }
}