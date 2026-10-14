using System.Collections;

namespace LevLesson
{
    internal class EnemyWave : IEnumerable<Enemy>
    {
        private List<Enemy> _vanguard = new List<Enemy>();
        private List<Enemy> _reinforcements = new List<Enemy>();

        public void AddVanguard(Enemy enemy)
        {
            _vanguard.Add(enemy);
        }

        public void AddReinforcement(Enemy enemy)
        {
            _reinforcements.Add(enemy);
        }

        public IEnumerator<Enemy> GetEnumerator()
        {
            // return new EnemyWaveIterator(_vanguard, _reinforcements);
            foreach (var enemy in _vanguard)
            {
                yield return enemy;
            }

            foreach (var enemy in _reinforcements)
            {
                yield return enemy;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
