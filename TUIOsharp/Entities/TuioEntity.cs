/*
 * @author Valentin Simonov / http://va.lent.in/
 */

namespace TUIOsharp.Entities
{
    public abstract class TuioEntity
    {
        public string Source { get; internal set; }
        public int Id { get; private set; }
        public float X { get; internal set; }
        public float Y { get; internal set; }
        public float VelocityX { get; internal set; }
        public float VelocityY { get; internal set; }
        public float Acceleration { get; internal set; }

        protected TuioEntity(int id, string source) : this(id, source, 0, 0, 0, 0, 0)
        {}

        protected TuioEntity(int id, string source, float x, float y, float velocityX, float velocityY, float acceleration)
        {
            Source = source;
            Id = id;
            X = x;
            Y = y;
            VelocityX = velocityX;
            VelocityY = velocityY;
            Acceleration = acceleration;
        }

    }
}