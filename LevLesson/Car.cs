using LevLesson.Enums;

namespace LevLesson
{
    internal class Car
    {
        private string _make;
        private string _model;
        private Color _color;

        private int _speed;

        public Car(string make, string model, Color color)
        {
            _make = make;
            _model = model;
            _color = color;
        }

        /// <summary>
        /// Rides the car at the specified speed.
        /// </summary>
        /// <param name="speed">Speed at which to ride the car</param>
        internal void Ride(int speed)
        {
            _speed = speed;

            // Logic of riding the car can be implemented here
        }

        /// <summary>
        /// Stops the car by setting its speed to zero.
        /// </summary>
        internal void Stop()
        {
            _speed = 0;

            // Logic of stopping the car can be implemented here
        }

        /// <summary>
        /// Returns information about the car, including its make, model, and color.
        /// </summary>
        /// <returns>Info about the car</returns>
        internal string Info()
        {
            return $"Make: {_make}, Model: {_model}, Color: {_color}";
        }
    }
}
