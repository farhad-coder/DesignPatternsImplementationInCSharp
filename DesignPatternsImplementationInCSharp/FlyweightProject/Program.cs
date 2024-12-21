
using FlyweightProject;

for (int i = 0; i < 20; i++)
{
    Circle circle = CircleFactory.GetCircle(CircleFactory.GetRandomColor());
    circle.SetX(CircleFactory.GetRandomX());
    circle.SetY(CircleFactory.GetRandomY());
    circle.SetRadius(100);
    circle.Draw();
}
